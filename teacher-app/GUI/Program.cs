using BUS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                string check_login = LoginBUS.CheckLoginByToken();
                switch (check_login)
                {
                    case "login_again":
                        Application.Run(new LoginForm());
                        break;
                    case "login_success":
                        Application.Run(new DashboardForm());
                        break;
                    default:
                        Application.Run(new LoginForm());
                        break;
                }
                Console.WriteLine($"Error1: {check_login}");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine($"Program error: {ex.Message}");
            }



        }
    }
}
