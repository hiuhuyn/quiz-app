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
        private Test _test = null;
        public NewTestForm(Test test)
        {
            InitializeComponent();
            CenterForm.ToForm(this);
            this._test = test;
            if (test != null)
            {
                this.Text = "Thông tin bộ đề";
                this.btnHistory.Visible = true;
                load_data_on_view();
            }
            else
            {
                this.Text = "Tạo bộ đề mới";
                this.btnHistory.Visible = false;
            }

        }
        private void load_data_on_view()
        {
            txtID.Text = _test.TestID;
            txtTitle.Text = _test.TestName;
            txtTimeLimit.Text = _test.TimeLimit.ToString();

            dataGridView1.Rows.Clear();
            int sd = 0;
            foreach (Question i in _test.QuestionList)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sd].Cells[0].Value = i.QuestionContent;
                for(int j = 0; j < i.AnswerList.Count; j++)
                {
                    Answer answer = i.AnswerList[j];
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

                sd++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnDelTest_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOneQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
