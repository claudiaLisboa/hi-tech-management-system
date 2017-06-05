using Hitech.Business;
using Hitech.Data;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class UserForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private MainForm mainForm;

        private User user = new User();
        private Permission permission = new Permission();
        private string username = string.Empty;
        private int employeeId = default(int);
        // To control the edition modes.
        private bool isInAdditionMode = false;
        private bool isInUpdateDeletionMode = false;

        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(User user, MainForm mainForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.mainForm = mainForm;
        }

        // Helper class to handle Combobox items.
        // From http://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source
        class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.isInAdditionMode)
            {
                return;
            }

            if (!ValidateFields())
            {
                return;
            }

            // All users are created with the password equal to the username.
            this.user = new User(this.username, this.username, "", this.employeeId);

            // Retrieving the employee associated with the user in order to show the full name.
            Employee employee = EmployeesCollection.GetEmployee(this.employeeId);

            if (UsersCollection.AddUser(this.user))
            {
                // The user was successfully added to UsersCollection.

                // Creating the Permission object.
                this.permission = new Permission(this.username,
                    chkEmployeeSaveUpdateDelete.Checked,
                    chkEmployeeSearchList.Checked,
                    chkUserSaveUpdateDelete.Checked,
                    chkUserSearchList.Checked,
                    chkClientSaveUpdateDelete.Checked,
                    chkClientSearchList.Checked,
                    chkProductSaveUpdateDelete.Checked,
                    chkProductSearchList.Checked,
                    chkClientsOrdersSaveUpdateCancel.Checked,
                    chkClientsOrdersSearchList.Checked);
                // Adding the Permission objec to PermissionsCollection.
                PermissionsCollection.AddPermission(this.permission);

                // Adding the row to grdUsers.
                this.grdUsers.Rows.Add(this.username, this.employeeId, employee.FullName,
                    chkEmployeeSaveUpdateDelete.Checked,
                    chkEmployeeSearchList.Checked,
                    chkUserSaveUpdateDelete.Checked,
                    chkUserSearchList.Checked,
                    chkClientSaveUpdateDelete.Checked,
                    chkClientSearchList.Checked,
                    chkProductSaveUpdateDelete.Checked,
                    chkProductSearchList.Checked,
                    chkClientsOrdersSaveUpdateCancel.Checked,
                    chkClientsOrdersSearchList.Checked);

                ClearFields();
            }
            else
            {
                MessageBox.Show("This Username already exists.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Once a user is created the only editing allowed is changing permissions.
            // In order to change the username or assign a different employee to it
            // the user must be removed and created again.

            if (!this.isInUpdateDeletionMode)
            {
                return;
            }

            // If the user being updated is the one logged into the system.
            if (this.user.Username == this.mainForm.UserLoggedIn.Username)
            {
                // If this is the case then the permissions to use this screen cannot be unchecked.
                if ((!chkUserSaveUpdateDelete.Checked) || (!chkUserSearchList.Checked))
                {
                    MessageBox.Show("You cannot remove your permissions to Save/Update/Delete/Search/List users.", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // Updating the properties of the Permission object this.permission.
            // The Permission object this.permission holds a reference to an object
            // inside PermissionsCollection (refer to grdUsers_CellMouseDoubleClick).
            // So the property updates below will also update the Permission object inside that collection.
            this.permission.EmployeeSaveUpdateDelete = this.chkEmployeeSaveUpdateDelete.Checked;
            this.permission.EmployeeSearchList = this.chkEmployeeSearchList.Checked;
            this.permission.UserSaveUpdateDelete = this.chkUserSaveUpdateDelete.Checked;
            this.permission.UserSearchList = this.chkUserSearchList.Checked;
            this.permission.ClientSaveUpdateDelete = this.chkClientSaveUpdateDelete.Checked;
            this.permission.ClientSearchList = this.chkClientSearchList.Checked;
            this.permission.ProductSaveUpdateDelete = this.chkProductSaveUpdateDelete.Checked;
            this.permission.ProductSearchList = this.chkProductSearchList.Checked;
            this.permission.ClientOrderSaveUpdateCancel = this.chkClientsOrdersSaveUpdateCancel.Checked;
            this.permission.ClientOrderSearchList = this.chkClientsOrdersSearchList.Checked;

            // Grabbing the selected row.
            int selectedRow = this.grdUsers.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdUsers.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colEmployeeSaveUpdateDelete"].Value = this.permission.EmployeeSaveUpdateDelete;
            row.Cells["colEmployeeSearchList"].Value = this.permission.EmployeeSearchList;
            row.Cells["colUserSaveUpdateDelete"].Value = this.permission.UserSaveUpdateDelete;
            row.Cells["colUserSearchList"].Value = this.permission.UserSearchList;
            row.Cells["colClientSaveUpdateDelete"].Value = this.permission.ClientSaveUpdateDelete;
            row.Cells["colClientSearchList"].Value = this.permission.ClientSearchList;
            row.Cells["colProductSaveUpdateDelete"].Value = this.permission.ProductSaveUpdateDelete;
            row.Cells["colProductSearchList"].Value = this.permission.ProductSearchList;
            row.Cells["colClientOrderSaveUpdateCancel"].Value = this.permission.ClientOrderSaveUpdateCancel;
            row.Cells["colClientOrderSearchList"].Value = this.permission.ClientOrderSearchList;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SetUpdateDeletionMode();

            // Checking if the user being removed is the one logged into the system.
            if (this.user.Username == this.mainForm.UserLoggedIn.Username)
            {
                MessageBox.Show("You cannot remove yourself from the system.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this user?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdUsers.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdUsers.Rows.RemoveAt(selectedRow);
                // Removing the user and the associated permissions from
                // UsersCollection and PermissionsCollection respectively.
                UsersCollection.RemoveUser(this.user);
                PermissionsCollection.RemovePermission(this.permission);
            }

            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HiTechDB.SaveData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignoring double-clicks on the fixed cells.
            if (e.RowIndex >= 0)
            {
                SetUpdateDeletionMode();
            }
        }

        private void ClearFields()
        {
            SetAdditionMode();
            LoadEmployees();

            // Clearing the permission checkboxes.
            foreach (Control ctrl in grpPermissions.Controls)
            {
                if (ctrl is CheckBox)
                {
                    (ctrl as CheckBox).Checked = false;
                }
            }

            if (this.Visible)
            {
                this.txtUsername.Focus();
            }
        }

        private void GetSelection()
        {
            // Retrieves user and permission information from the selected row in grdUsers.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdUsers.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdUsers.Rows[selectedRow];

                // Retrieving user information from the selected row.
                this.username = row.Cells["colUsername"].Value.ToString();
                this.employeeId = default(int);
                bool parseOKEmployeeId = int.TryParse(row.Cells["colEmployeeId"].Value.ToString(), out this.employeeId);
                string employeeFullName = row.Cells["colEmployeeFullName"].Value.ToString();

                // Retrieving the selected user from UsersCollection
                // and storing it in the User this.user.
                this.user = UsersCollection.GetUser(this.username);

                // Retrieving the selected user's permissions from PermissionsCollection
                // and storing it in the Permission this.permission.
                this.permission = PermissionsCollection.GetPermissionByUsername(this.username);

                // Showing the user information in the fields.
                if (this.user != null && this.permission != null)
                {
                    this.txtUsername.Text = this.username;
                    this.cmbEmployee.Text = employeeFullName;
                    // Showing the user's permissions.
                    // The permissions are being loaded from Permission object instantiated above
                    // because it is easier than loading them from grdUsers.
                    this.chkEmployeeSaveUpdateDelete.Checked = this.permission.EmployeeSaveUpdateDelete;
                    this.chkEmployeeSearchList.Checked = this.permission.EmployeeSearchList;
                    this.chkUserSaveUpdateDelete.Checked = this.permission.UserSaveUpdateDelete;
                    this.chkUserSearchList.Checked = this.permission.UserSearchList;
                    this.chkClientSaveUpdateDelete.Checked = this.permission.ClientSaveUpdateDelete;
                    this.chkClientSearchList.Checked = this.permission.ClientSearchList;
                    this.chkProductSaveUpdateDelete.Checked = this.permission.ProductSaveUpdateDelete;
                    this.chkProductSearchList.Checked = this.permission.ProductSearchList;
                    this.chkClientsOrdersSaveUpdateCancel.Checked = this.permission.ClientOrderSaveUpdateCancel;
                    this.chkClientsOrdersSearchList.Checked = this.permission.ClientOrderSearchList;
                }
            }
        }

        private void LoadEmployees()
        {
            GenericList<int, Employee> employeeList = EmployeesCollection.GetEmployeesWithNoUserAssigned();

            this.cmbEmployee.Items.Clear();
            this.cmbEmployee.DisplayMember = "Text";
            this.cmbEmployee.ValueMember = "Value";

            for (int i = 0; i < employeeList.GetCount(); i++)
            {
                Employee employee = employeeList[i];

                ComboboxItem item = new ComboboxItem();
                item.Value = employee.EmployeeId;
                item.Text = employee.FullName;

                this.cmbEmployee.Items.Add(item);
            }
        }

        private void LoadUsers()
        {
            GenericList<string, User> userList = UsersCollection.GetCollection();

            this.grdUsers.Rows.Clear();

            for (int i = 0; i < userList.GetCount(); i++)
            {
                User user = userList[i];
                Employee employee = EmployeesCollection.GetEmployee(user.EmployeeId);
                Permission permission = PermissionsCollection.GetPermissionByUsername(user.Username);

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdUsers.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdUsers.Rows[rowId];

                // Adding the data.
                row.Cells["colUsername"].Value = user.Username;
                row.Cells["colEmployeeId"].Value = employee.EmployeeId;
                row.Cells["colEmployeeFullName"].Value = employee.FullName;
                row.Cells["colEmployeeSaveUpdateDelete"].Value = permission.EmployeeSaveUpdateDelete;
                row.Cells["colEmployeeSearchList"].Value = permission.EmployeeSearchList;
                row.Cells["colUserSaveUpdateDelete"].Value = permission.UserSaveUpdateDelete;
                row.Cells["colUserSearchList"].Value = permission.UserSearchList;
                row.Cells["colClientSaveUpdateDelete"].Value = permission.ClientSaveUpdateDelete;
                row.Cells["colClientSearchList"].Value = permission.ClientSearchList;
                row.Cells["colProductSaveUpdateDelete"].Value = permission.ProductSaveUpdateDelete;
                row.Cells["colProductSearchList"].Value = permission.ProductSearchList;
                row.Cells["colClientOrderSaveUpdateCancel"].Value = permission.ClientOrderSaveUpdateCancel;
                row.Cells["colClientOrderSearchList"].Value = permission.ClientOrderSearchList;
            }
        }

        private void SetAdditionMode()
        {
            this.isInAdditionMode = true;
            this.isInUpdateDeletionMode = false;

            this.txtUsername.Clear();
            this.txtUsername.ReadOnly = false;

            this.cmbEmployee.Text = string.Empty;
            this.cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEmployee.Enabled = true;
        }

        private void SetUpdateDeletionMode()
        {
            this.isInAdditionMode = false;
            this.isInUpdateDeletionMode = true;

            this.txtUsername.ReadOnly = true;

            this.cmbEmployee.DropDownStyle = ComboBoxStyle.DropDown;
            this.cmbEmployee.Enabled = false;

            GetSelection();
        }

        private bool ValidateFields()
        {
            this.username = this.txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(this.username))
            {
                MessageBox.Show("Please enter the username.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUsername.Focus();
                return false;
            }

            if (this.cmbEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("Please assign an employee to this user.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.cmbEmployee.Focus();
                return false;
            }

            this.employeeId = default(int);
            bool parseOKEmployeeId = int.TryParse(((ComboboxItem)this.cmbEmployee.SelectedItem).Value.ToString(), out this.employeeId);

            return true;
        }
    }
}
