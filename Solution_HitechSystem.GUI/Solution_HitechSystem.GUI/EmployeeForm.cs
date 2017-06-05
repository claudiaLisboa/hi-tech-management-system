using Hitech.Business;
using Hitech.Data;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class EmployeeForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private MainForm mainForm;

        private Employee employee = new Employee();
        private int employeeId = default(int);
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string jobTitle = string.Empty;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(User user, MainForm mainForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.mainForm = mainForm;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.employee = new Employee(this.employeeId, this.firstName, this.lastName, this.jobTitle);
            if (EmployeesCollection.AddEmployee(this.employee))
            {
                this.grdEmployees.Rows.Add(this.employeeId, this.firstName, this.lastName, this.jobTitle);
                ClearFields();
            }
            else
            {
                MessageBox.Show("This Employee Id already exists.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            // Updating the properties of the Employee this.employee.
            this.employee.FirstName = this.firstName;
            this.employee.LastName = this.lastName;
            this.employee.JobTitle = this.jobTitle;

            // At this point this.employee refers to an object inside EmployeesCollection.
            // So the property updates above have also updated the Employee object inside
            // that collection (refer to grdEmployees_CellMouseDoubleClick).

            // Grabbing the selected row.
            int selectedRow = this.grdEmployees.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdEmployees.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colEmployeeId"].Value = this.employee.EmployeeId;
            row.Cells["colFirstName"].Value = this.employee.FirstName;
            row.Cells["colLastName"].Value = this.employee.LastName;
            row.Cells["colJobTitle"].Value = this.employee.JobTitle;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GetSelection();

            // Checking if the employee being removed has a user in the system.
            if (UsersCollection.GetUserByEmployee(this.employee.EmployeeId) != null)
            {
                MessageBox.Show("You cannot remove this employee because there is a user assigned to her/him.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this employee?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdEmployees.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdEmployees.Rows.RemoveAt(selectedRow);
                // Removing the employee from EmployeesCollection.
                EmployeesCollection.RemoveEmployee(this.employee);
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

        private void LoadEmployees()
        {
            GenericList<int, Employee> employeeList = EmployeesCollection.GetCollection();

            this.grdEmployees.Rows.Clear();

            for (int i = 0; i < employeeList.GetCount(); i++)
            {
                Employee employee = employeeList[i];

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdEmployees.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdEmployees.Rows[rowId];

                // Adding the data.
                row.Cells["colEmployeeId"].Value = employee.EmployeeId;
                row.Cells["colFirstName"].Value = employee.FirstName;
                row.Cells["colLastName"].Value = employee.LastName;
                row.Cells["colJobTitle"].Value = employee.JobTitle;
            }
        }

        private void ClearFields()
        {
            this.txtEmployeeId.Text = EmployeesCollection.NextEmployeeId().ToString();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtJobTitle.Clear();

            if (this.Visible)
            {
                this.txtFirstName.Focus();
            }
        }

        private bool ValidateFields()
        {
            // Loading the provided employee information into the
            // non-UI fields (declared at the beginning of this class).
            this.employeeId = default(int);
            bool parseOKEmployeeId = int.TryParse(this.txtEmployeeId.Text.Trim(), out this.employeeId);
            this.firstName = this.txtFirstName.Text.Trim();
            this.lastName = this.txtLastName.Text.Trim();
            this.jobTitle = this.txtJobTitle.Text.Trim();

            if (string.IsNullOrEmpty(this.firstName))
            {
                MessageBox.Show("Please enter the employee's first name.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.lastName))
            {
                MessageBox.Show("Please enter the employee's last name.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.jobTitle))
            {
                MessageBox.Show("Please enter the employee's job title.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtJobTitle.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void GetSelection()
        {
            // Retrieves employee information from the selected row in grdEmployees.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdEmployees.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdEmployees.Rows[selectedRow];

                // Retrieving employee information from the selected row.
                this.employeeId = default(int);
                bool parseOKEmployeeId = int.TryParse(row.Cells["colEmployeeId"].Value.ToString(), out this.employeeId);
                this.firstName = row.Cells["colFirstName"].Value.ToString();
                this.lastName = row.Cells["colLastName"].Value.ToString();
                this.jobTitle = row.Cells["colJobTitle"].Value.ToString();

                // Retrieving the selected employee from EmployeesCollection
                // and storing it in the Employee this.employee.
                this.employee = EmployeesCollection.GetEmployee(this.employeeId);

                // Showing the employee information in the UI fields.
                if (this.employee != null)
                {
                    this.txtEmployeeId.Text = this.employeeId.ToString();
                    this.txtFirstName.Text = this.firstName;
                    this.txtLastName.Text = this.lastName;
                    this.txtJobTitle.Text = this.jobTitle;
                }
            }
        }

        private void grdEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignoring double-clicks on the fixed cells.
            if (e.RowIndex >= 0)
            {
                GetSelection();
            }
        }
    }
}
