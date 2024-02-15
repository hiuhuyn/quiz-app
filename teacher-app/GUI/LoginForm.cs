using System;
using System.Windows.Forms;
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string getUser = null;

            if(getUser != null ) {
                MessageBox.Show(getUser);
                return;
            }
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.ShowDialog();
            this.Close();
        }
    }
}
