using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           CenterForm.ToForm(this);
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUsername.Text;
            string password = txtPassword.Text;

            string check_login = LoginBUS.CheckLoginByIdAndPassword(id, password, checkBoxRememberLogin.Checked);
            switch (check_login)
            {
                case "login_success":
                    Hide();
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.ShowDialog();
                    Close();
                    return;
                default:
                    MessageBox.Show(check_login);
                    return;
            }
            
        }
    }
}
