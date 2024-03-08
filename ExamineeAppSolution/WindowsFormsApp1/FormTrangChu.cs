using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WindowsFormsApp1.DataXML;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class FormTrangChu : Form

    {
        private HttpClient httpClient;
        private XMLDataRetrieval xmlData;
        private string id;
        private string name;
        private string sex;
        private string address;
        private string phone;
        private string email;
        private TestList testList;


        private readonly string apiUrl = Constaints.GET_ALL_TEST(APIKey.Key); // Thay thế bằng URL của API
        public FormTrangChu()
        {
            InitializeComponent();
            httpClient = new HttpClient();

            xmlData = new XMLDataRetrieval("D:\\C#\\quiz-app\\ExamineeAppSolution\\WindowsFormsApp1\\DataXML\\Examinee.xml");
            id = Examinee.ExamineeID.ToString();
            xmlData.AddExaminee(id, null, null, null, null, null);
            LoadDataFromApi();
            loadExamineeInFor();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }



        private void dataGridViewCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCauHoi.Rows[e.RowIndex];
                string testID = row.Cells["TestID"].Value.ToString();

                // Chuyển sang form mới và truyền TestID
                FormTracNghiem tr = new FormTracNghiem(testID);
                this.Hide();
                tr.ShowDialog();
                this.Show();

            }
        }




        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ExamineeInFor();
            try
            {
                xmlData.UpdateData(id, name, sex, address, phone, email);
                MessageBox.Show("Cập nhật thành công");
                loadExamineeInFor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    Test emptyTest = new Test();
                    testList.Tests.Insert(0, emptyTest);

                    // Hiển thị dữ liệu lên DataGridView
                    dataGridViewCauHoi.DataSource = testList.Tests;
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

        private void ExamineeInFor()
        {

            name = txtName.Text.Trim();
            sex = txtGioiTinh.Text.Trim();
            address = txtDiaChi.Text.Trim();
            phone = txtSDT.Text.Trim();
            email = txtEmail.Text.Trim();
        }
        private void loadExamineeInFor()
        {

            lbID.Text = id;

            try
            {
                var data = xmlData.RetrieveDataById(id);
                txtName.Text = data.Item1;
                txtGioiTinh.Text = data.Item2;
                txtDiaChi.Text = data.Item3;
                txtSDT.Text = data.Item4;
                txtEmail.Text = data.Item5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchQuery = txtTimKiem.Text.Trim();
            SearchAndUpdateData(searchQuery);
        }
        private void SearchAndUpdateData(string searchQuery)
        {
            if (testList != null)
            {
                // Tạo một danh sách mới để lưu trữ kết quả tìm kiếm
                List<Test> searchResults = new List<Test>();

                // Duyệt qua từng phần tử trong dữ liệu gốc
                foreach (var test in testList.Tests)
                {
                    // Kiểm tra xem TestName có null hay không trước khi sử dụng
                    if (test.TestName != null && test.TestName.Contains(searchQuery))
                    {
                        searchResults.Add(test);
                    }
                }

                // Tạo một TestList mới từ kết quả tìm kiếm
                TestList searchResultList = new TestList
                {
                    Tests = searchResults
                };

                // Hiển thị kết quả tìm kiếm trên DataGridView
                dataGridViewCauHoi.DataSource = searchResultList.Tests;
            }
        }

    }
}


