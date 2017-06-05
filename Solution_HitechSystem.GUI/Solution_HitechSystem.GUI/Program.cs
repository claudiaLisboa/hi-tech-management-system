using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hitech.Business;
using Hitech.Data;

namespace Solution_HitechSystem.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HiTechDB.LoadData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            User user = loginForm.UserLoggedIn;
            if (user != null)
            {
                Application.Run(new MainForm(user));
            }
            
            HiTechDB.SaveData();
        }
    }
}
