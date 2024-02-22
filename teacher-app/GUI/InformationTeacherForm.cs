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
    public partial class InformationTeacherForm : Form
    {
        TeacherBUS teacherBUS;
        public InformationTeacherForm()
        {
            teacherBUS = new TeacherBUS();
            teacherBUS.InitOnline();
            InitializeComponent();
            CenterForm.ToForm(this);
            _loaddata();
        }
        private void _loaddata()
        {
            string req = teacherBUS.GetTeacherOffline();
            switch (req)
            {
                case "success":
                    Teacher t = teacherBUS.Teacher;
                    txtID.Text = t.TeacherID;
                    txtName.Text = t.TeacherName;
                    break;
                case "fail":
                    MessageBox.Show("Lấy dữ liệu lỗi");
                    break;
            }
            
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {

        }
    }
}
