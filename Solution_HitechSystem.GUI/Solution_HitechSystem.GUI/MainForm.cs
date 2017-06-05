using Hitech.Business;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class MainForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User user)
        {
            InitializeComponent();

            this.userLoggedIn = user;
            this.lblStatusBar.Text = $"User: {this.userLoggedIn.Username}";

            // Enablind/disabling the buttons according to user's permissions.
            CheckPermissions();
        }

        public User UserLoggedIn
        {
            get { return userLoggedIn; }
        }

        private void CheckPermissions()
        {
            // Retrieving the user's permissions.
            Permission permissions = PermissionsCollection.GetPermission(this.userLoggedIn.Username);

            this.btnEmployees.Enabled = (permissions.EmployeeSaveUpdateDelete || permissions.EmployeeSearchList);
            this.btnUsers.Enabled = (permissions.UserSaveUpdateDelete || permissions.UserSearchList);
            this.btnClients.Enabled = (permissions.ClientSaveUpdateDelete || permissions.ClientSearchList);
            this.btnOrders.Enabled = (permissions.ClientOrderSaveUpdateCancel || permissions.ClientOrderSearchList);
            this.btnProducts.Enabled = (permissions.ProductSaveUpdateDelete || permissions.ProductSearchList);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm frm = new EmployeeForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm frm = new OrderForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frm = new ChangePasswordForm(this);
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
