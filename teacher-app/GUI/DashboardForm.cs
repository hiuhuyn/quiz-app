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
    public partial class DashboardForm : Form
    {
        private TestBUS testBUS;
        public DashboardForm()
        {
            testBUS = new TestBUS();
            InitializeComponent();
            ComponentCustome();
            CenterForm.ToForm(this);
            LoadingData();
        }
        public void LoadingData()
        {
            string req = testBUS.GetAllTestByIdTeacher();
            switch (req)
            {
                case "success": break;
                case "loading_fail":
                    MessageBox.Show("Lấy dữ liệu thất bại, hãy kiểm tra lại đường truyền!");
                    return;
                default:
                    MessageBox.Show(req);
                    return;
            }
            dataGridView1.Rows.Clear();
            int sd = 0;
            foreach (Test t in testBUS.ListTests)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sd].Cells[0].Value = t.TestID;
                dataGridView1.Rows[sd].Cells[1].Value = t.TestName;
                dataGridView1.Rows[sd].Cells[2].Value = t.Topic;
                dataGridView1.Rows[sd].Cells[3].Value = t.TimeLimit;
                dataGridView1.Rows[sd].Cells[4].Value = t.QuestionList?.Count;
                sd++;
            }
        }


        private void FileNew_click(object sender, EventArgs e)
        {
            NewTestForm newTestForm = new NewTestForm(null, this);
            newTestForm.Show();
        }
        private void FileViewInfo_click(object sender, EventArgs e)
        {
            InformationTeacherForm form = new InformationTeacherForm();
            form.Show();
        }
        private void FileLogout_click(object sender, EventArgs e)
        {
            LoginBUS.Signout();
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            Close();
        }
        private void About_click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string idTest = dataGridView1.Rows[index].Cells[0].Value.ToString();
            foreach(Test t in testBUS.ListTests)
            {
                if(t.TestID == idTest)
                {
                    NewTestForm newTestForm = new NewTestForm(t, this);
                    newTestForm.Show();
                    break;
                }
            }
        }
    }
}
