using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class ChangePasswordForm : Form
    {
        private MainForm mainForm;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.mainForm.UserLoggedIn.Password = this.txtNewPassword.Text;

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFields()
        {
            string currentPassword = this.txtCurrentPassword.Text;
            string newPassword = this.txtNewPassword.Text;
            string retypedPassword = this.txtRetypePassword.Text;

            if (string.IsNullOrEmpty(currentPassword))
            {
                MessageBox.Show("Please enter your current password.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCurrentPassword.Focus();
                return false;
            }

            // Checking whether the password entered in
            // this.txtCurrentPassword is indeed this user's password.
            if (!this.mainForm.UserLoggedIn.CheckPassword(currentPassword))
            {
                MessageBox.Show("This is not your current password. Please try again.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCurrentPassword.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter your new password.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNewPassword.Focus();
                return false;
            }

            // The new password must be different from the current one.
            if (this.mainForm.UserLoggedIn.CheckPassword(newPassword))
            {
                MessageBox.Show("The new password must be different from the current one. Please try again.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNewPassword.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(retypedPassword))
            {
                MessageBox.Show("Please retype your new password.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtRetypePassword.Focus();
                return false;
            }

            if (retypedPassword != newPassword)
            {
                MessageBox.Show("The new and the retyped passwords must match. Please try again.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtRetypePassword.Focus();
                return false;
            }

            return true;
        }
    }
}
