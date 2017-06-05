using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hitech.Business;

namespace Solution_HitechSystem.GUI
{
    public partial class LoginForm : Form
    {
        // This variable holds the user who logged in to the system.
        private User user = null;

        public User UserLoggedIn
        {
            get { return user; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text.Trim();
            string password = this.txtPassword.Text.Trim();

            if (username.Length == 0)
            {
                MessageBox.Show("Please enter your username.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUsername.Focus();
                return;
            }

            if (password.Length == 0)
            {
                MessageBox.Show("Please enter your password.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPassword.Focus();
                return;
            }

            // Retrieving the user by the username.
            this.user = UsersCollection.GetUser(username);

            if (this.user == null)
            {
                MessageBox.Show($"Username '{username}' does not exist.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUsername.Focus();
                return;
            }

            if (this.user.CheckPassword(password))
            {
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("You entered a wrong password. Try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtPassword.Focus();
                return;
            }
        }
    }
}
