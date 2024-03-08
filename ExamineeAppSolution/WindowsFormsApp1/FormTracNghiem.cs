using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class FormTracNghiem : Form
    {
        private string testID;
        private HttpClient httpClient;
        private readonly string postApiUrl = Constaints.POST_RECORDS(APIKey.Key);
        private readonly string apiUrl = Constaints.GET_ALL_TEST(APIKey.Key); // Thay thế bằng URL của API
        private TestList testList;
        private float score = 0;
        private int currentQuestionIndex = 0;

        private int timeLimit;
        private int timeLimitInSeconds; // Thời gian giới hạn tính bằng giây
        private int elapsedTimeInSeconds; // Thời gian đã trôi qua tính bằng giây
        // Định nghĩa một danh sách để lưu trạng thái của các CheckBox
        private List<List<bool>> radioButtonStates = new List<List<bool>>();
        public FormTracNghiem(string testID)
        {
            InitializeComponent();
            this.testID = testID;
            this.httpClient = new HttpClient();
        }

        private void FormTracNghiem_Load(object sender, EventArgs e)
        {
            LoadDataFromApi();
            tmCount.Start();
      
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                currentQuestionIndex = e.RowIndex; // Gán giá trị của currentQuestionIndex bằng vị trí hàng được chọn

                DisplayQuestionContent(currentQuestionIndex);

            }

        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {

            tmCount.Stop();
           
            SubmitExam();

        }

            

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestionContent(currentQuestionIndex);
               dataGridView1.Rows[currentQuestionIndex].Selected = true;
                
            }

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < dataGridView1.Rows.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestionContent(currentQuestionIndex);
                dataGridView1.Rows[currentQuestionIndex].Selected = true;
               
            }
        }
        private async void LoadDataFromApi()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseXml = await response.Content.ReadAsStringAsync();
                    testList = DeserializeXml<TestList>(responseXml);
                    // Khởi tạo radioButtonStates
                    foreach (var test in testList.Tests)
                    {
                        if (test.TestID == testID)
                        {
                            foreach (var question in test.QuestionList.Questions)
                            {
                                radioButtonStates.Add(new List<bool>());
                            }
                            break; // Sau khi tìm thấy bài test cần, có thể thoát khỏi vòng lặp
                        }
                    }

                    // Hiển thị dữ liệu lên DataGridView
                    // Tạo DataTable để hiển thị dữ liệu trên DataGridView
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("QuestionContent", typeof(string));

                    // Lặp qua danh sách các bài test và các câu hỏi trong mỗi bài test để lấy dữ liệu câu hỏi và câu trả lời

                    foreach (var test in testList.Tests)
                    {

                        if (test.TestID == testID)
                        {
                            // Lấy thời gian giới hạn từ đối tượng Test
                            timeLimit = test.TimeLimit;
                           //timeLimit = 1;

                            foreach (var question in test.QuestionList.Questions)
                            {
                                dataTable.Rows.Add(question.QuestionContent);
                            }


                            break; // Sau khi tìm thấy bài test cần, có thể thoát khỏi vòng lặp
                        }
                    }

                    // Hiển thị dữ liệu trên DataGridView
                    dataGridView1.DataSource = dataTable;
                    if (dataGridView1.Rows.Count > 0)
                    {
                        DisplayQuestionContent(0);
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi khi gửi yêu cầu đến API.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private T DeserializeXml<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
        private void DisplayQuestionContent(int rowIndex)
        {
           
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            string questionContent = selectedRow.Cells["QuestionContent"].Value.ToString();
            lbCauHoi.Text = questionContent;

            // Xóa các RadioButton cũ trước khi thêm mới
            panelRadio.Controls.Clear();

            // Lấy các câu trả lời tương ứng với câu hỏi được chọn
            var answers = GetAnswersForQuestion(questionContent);

            int yOffset = 20; // Offset the y-position of the RadioButton

            foreach (var answer in answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = answer.AnswerContent;
                radioButton.AutoSize = true;
                radioButton.Location = new Point(20, yOffset);
                yOffset += radioButton.Height + 5;
                panelRadio.Controls.Add(radioButton);
                // Thiết lập trạng thái cho RadioButton dựa trên dữ liệu đã lưu
                if (radioButtonStates[rowIndex] != null && radioButtonStates[rowIndex].Count > 0)
                {
                    radioButton.Checked = radioButtonStates[rowIndex][panelRadio.Controls.Count - 1];
                }


                radioButton.CheckedChanged += (sender, e) =>
                {
                    if (radioButton.Checked)
                    {
                        // Cập nhật trạng thái của nút radio
                        if (radioButtonStates.Count > currentQuestionIndex)
                        {
                            while (radioButtonStates[currentQuestionIndex].Count < panelRadio.Controls.Count)
                            {
                                radioButtonStates[currentQuestionIndex].Add(false);
                            }
                            radioButtonStates[currentQuestionIndex][panelRadio.Controls.IndexOf(radioButton)] = true;
                        }
                       
                        
                        // Cập nhật điểm số nếu câu trả lời hiện tại là đúng
                        if (answer.IsCorrect)
                        {
                            score += 5;
                            Console.WriteLine("Bạn được cộng " + score);
                        }
                    }
                    else
                    {
                        // Cập nhật trạng thái của nút radio
                        if (radioButtonStates.Count > currentQuestionIndex)
                        {
                            while (radioButtonStates[currentQuestionIndex].Count < panelRadio.Controls.Count)
                            {
                                radioButtonStates[currentQuestionIndex].Add(false);
                            }
                            radioButtonStates[currentQuestionIndex][panelRadio.Controls.IndexOf(radioButton)] = false;
                        }
                    }
                };
            }
        }
        
        private List<Answer> GetAnswersForQuestion(string questionContent)
        {
            // Tìm câu hỏi trong testList dựa trên nội dung của câu hỏi
            var question = testList.Tests.SelectMany(t => t.QuestionList.Questions)
                                          .FirstOrDefault(q => q.QuestionContent == questionContent);

            // Trả về danh sách câu trả lời của câu hỏi được chọn
            return question != null ? question.Answers.Answers : new List<Answer>();
        }
        


       
        private void tmCount_Tick(object sender, EventArgs e)
        {

            elapsedTimeInSeconds++; // Tăng thời gian đã trôi qua lên 1 giây
            timeLimitInSeconds = timeLimit * 60;
            // Kiểm tra xem đã hết thời gian giới hạn chưa
            if (elapsedTimeInSeconds >= timeLimitInSeconds)
            {
                tmCount.Stop(); // Dừng Timer khi hết thời gian giới hạn

                // Thực hiện các thao tác khi hết thời gian, ví dụ: thông báo cho người dùng
                MessageBox.Show("Đã hết thời gian xin vui lòng nộp bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubmitExam();

            }

            // Cập nhật giao diện người dùng để hiển thị thời gian đếm ngược mới
            int remainingTimeInSeconds = timeLimitInSeconds - elapsedTimeInSeconds;
            TimeSpan remainingTime = TimeSpan.FromSeconds(remainingTimeInSeconds);
            lbSec.Text = remainingTime.ToString(@"mm\:ss"); // Hiển thị thời gian dưới dạng "giờ:phút:giây"



        }
       
        private async void SubmitExam()
        {
            tmCount.Stop();

            // Lấy thời gian đã trôi qua tính bằng giây
            int elapsedTimeInSeconds = this.elapsedTimeInSeconds;
            string time = elapsedTimeInSeconds.ToString();
            // Lấy giá trị của testID đã được truyền vào trong hàm khởi tạo của form
            string testID = this.testID;

            // Lấy giá trị điểm thi
            float score = this.score;

            string xmlData = $@"<?xml version='1.0' encoding='utf-8'?>
                            <Record>
                                <TestID>{testID}</TestID>
                                <Score>{score}</Score>
                                <SubmittedTime>{time}</SubmittedTime>
                            </Record>";
    

            try
            {
                var content = new StringContent(xmlData, Encoding.UTF8, "application/xml");
                HttpResponseMessage response = await httpClient.PostAsync(postApiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi gửi yêu cầu đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

    }




}
