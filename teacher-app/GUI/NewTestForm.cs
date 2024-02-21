using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NewTestForm : Form
    {
        private TestBUS _testBus;
        private Test _test = null;
        private bool IsInsert = false;
        private DashboardForm dashboardForm;
        public NewTestForm(Test test, DashboardForm dashboardForm)
        {
            _testBus = new TestBUS();
            this.dashboardForm = dashboardForm;
            InitializeComponent();
            CenterForm.ToForm(this);

            string reqListTopic = _testBus.GetListTopic();
            if (reqListTopic == "success")
            {
                List<string> listTopic = _testBus.ListTopic;
                foreach (string topic in listTopic)
                {
                    comboBoxTopic.Items.Add(topic);
                }
            }
            else
            {
                MessageBox.Show(reqListTopic);
            }
            this._test = test;
            if (test != null)
            {
                IsInsert = false;
                this.Text = "Thông tin bộ đề";
                this.btnHistory.Visible = true;
                this.btnDelTest.Visible = true;

                _load_data_on_view();
            }
            else
            {
                IsInsert = true;
                this.Text = "Tạo bộ đề mới";
                this.btnHistory.Visible = false;
                this.btnDelTest.Visible = false;
            }

           
        }
        private void _load_data_on_view()
        {
            txtID.Text = _test.TestID;
            txtTitle.Text = _test.TestName;
            txtTimeLimit.Text = _test.TimeLimit.ToString();
            comboBoxTopic.Text = _test.Topic;

            dataGridView1.Rows.Clear();
            foreach (Question i in _test.QuestionList)
            {
                _addQuestionOnTable(i, -1);
            }
        }
        private void _addQuestionOnTable(Question question, int index)
        {
            int sd = -1;
            if (index == -1)
            {
                sd = dataGridView1.Rows.Add();
            }
            else
            {
                sd = index;
            }

            dataGridView1.Rows[sd].Cells[0].Value = question.QuestionContent;
            for (int j = 0; j < question.AnswerList.Count; j++)
            {
                Answer answer = question.AnswerList[j];
                int indexCell = j + 1;
                dataGridView1.Rows[sd].Cells[indexCell].Value = answer.AnswerContent;
                if (answer.IsCorrect)
                {
                    switch (j)
                    {
                        case 0:
                            dataGridView1.Rows[sd].Cells[5].Value = "A";
                            break;
                        case 1:
                            dataGridView1.Rows[sd].Cells[5].Value = "B";
                            break;
                        case 2:
                            dataGridView1.Rows[sd].Cells[5].Value = "C";
                            break;
                        case 3:
                            dataGridView1.Rows[sd].Cells[5].Value = "D";
                            break;
                    }
                }
            }
        }
        private Question _getQuestionByForm()
        {
            Question question = new Question(richTxtQuestion.Text, new List<Answer>
            {
                new Answer( comboBoxChooseTheCorrectAnswer.Text == "A" , richTxtA.Text),
                new Answer( comboBoxChooseTheCorrectAnswer.Text == "B" , richTxtB.Text),
                new Answer( comboBoxChooseTheCorrectAnswer.Text == "C" , richTxtC.Text),
                new Answer( comboBoxChooseTheCorrectAnswer.Text == "D" , richTxtD.Text),
            });
            return question;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string title = txtTitle.Text;
            int timeLimit = Convert.ToInt32(txtTimeLimit.Text);
            string topic = comboBoxTopic.Text;
            List<Question> list = _getQuestionsByTable();

            Teacher t = new TeacherBUS().GetTeacherOffline();

            Test newTest = new Test(id, title, topic, t.TeacherID, timeLimit, list);
            if (IsInsert)
            {
                string req = _testBus.InsertTest(newTest);
                switch(req)
                {
                    case "name_is_empty":
                        MessageBox.Show("Tiêu đề không được để trống!");
                        break;
                    case "timelimit_is_less_1":
                        MessageBox.Show("Thời gian làm bài của bạn cần lớn hơn 1 phút");
                        break;
                    case "success":
                        MessageBox.Show("Thêm thành công");
                        dashboardForm.LoadingData();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Lỗi: " + req);
                        break;
                }
            }
            else
            {
                string req = _testBus.UpdateTest(newTest);
                switch (req)
                {
                    case "name_is_empty":
                        MessageBox.Show("Tiêu đề không được để trống!");
                        break;
                    case "timelimit_is_less_1":
                        MessageBox.Show("Thời gian làm bài của bạn cần lớn hơn 1 phút");
                        break;
                    case "success":
                        MessageBox.Show("Cập nhật thành công");
                        dashboardForm.LoadingData();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Lỗi: " + req);
                        break;
                }
            }
        }
        private List<Question> _getQuestionsByTable()
        {
            List<Question> list = new List<Question>();
            for (int index = 0; index < dataGridView1.Rows.Count - 1; index++)
            {

                string questionStr = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string correct = dataGridView1.Rows[index].Cells[5].Value.ToString();
                Question qi = new Question(questionStr, new List<Answer>
                {
                    new Answer(correct == "A", dataGridView1.Rows[index].Cells[1].Value.ToString()),
                    new Answer(correct == "B", dataGridView1.Rows[index].Cells[2].Value.ToString()),
                    new Answer(correct == "C", dataGridView1.Rows[index].Cells[3].Value.ToString()),
                    new Answer(correct == "D", dataGridView1.Rows[index].Cells[4].Value.ToString()),
                });
                list.Add(qi);
            }

            return list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelTest_Click(object sender, EventArgs e)
        {
            _testBus.DeleteTest(txtID.Text);
            dashboardForm.LoadingData();
            MessageBox.Show("Xóa bộ đề thành công");
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryExameForm frm = new HistoryExameForm();
            frm.Show();
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            Question question = _getQuestionByForm();
            _addQuestionOnTable(question, -1);
        }


        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.Equals(richTxtQuestion.Text))
                {
                    Question question = _getQuestionByForm();
                    if (question != null)
                    {
                        _addQuestionOnTable(question, i);
                        break;
                    }

                }
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.Equals(richTxtQuestion.Text))
                {
                    dataGridView1.Rows.RemoveAt(i);
                    break;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            richTxtQuestion.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            richTxtA.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            richTxtB.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            richTxtC.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            richTxtD.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            comboBoxChooseTheCorrectAnswer.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
        }

        private void txtTimeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép nhập ký tự này
            }
        }
    }
}
