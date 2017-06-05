using Hitech.Business;
using Hitech.Data;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class ClientForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private MainForm mainForm;
        private OrderForm orderForm;

        private Client client = new Client();
        private int clientId     = default(int);
        private string clientName   = string.Empty;
        private string address      = string.Empty;
        private string city         = string.Empty;
        private string postalCode   = string.Empty;
        private string phoneNumber  = string.Empty;
        private string faxNumber    = string.Empty;
        private string bankNumber   = string.Empty;
        private string branchNumber = string.Empty;
        private string bankAccount  = string.Empty;
        private double creditLimit  = default(double);

        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(User user, MainForm mainForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.mainForm = mainForm;
            this.btnSelectClient.Visible = false;

            // Enablind/disabling the buttons according to user's permissions.
            CheckPermissions();
        }

        public ClientForm(User user, OrderForm orderForm)
        {
            // This form can be opened via OrderForm so that the user can choose
            // a client for the order she/he is adding/updating.
            //
            // If the client does not exist the user can add it in this window
            // (if the user's permissions allow it) and then select it by clicking
            // btnSelectClient. This button is visible only when this form is opened from OrderForm.
            //
            // If the user does not want to select a client she/he can click
            // on btnClose. This way no client will be sent back to OrderForm.

            InitializeComponent();
            this.userLoggedIn = user;
            this.orderForm = orderForm;
            this.btnSelectClient.Visible = true;

            // Enablind/disabling the buttons according to user's permissions.
            CheckPermissions();
        }

        public Client SelectedClient()
        {
            return this.client;
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            GetSelection();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadClients();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.client = new Client(this.clientId, this.clientName,
                this.address, this.city, this.postalCode, this.phoneNumber, this.faxNumber,
                this.creditLimit, this.bankNumber, this.branchNumber, this.bankAccount);

            if (ClientsCollection.AddClient(this.client))
            {
                this.grdClients.Rows.Add(this.clientId, this.clientName, this.phoneNumber, this.faxNumber,
                    this.address, this.city, this.postalCode,
                    this.bankNumber, this.branchNumber, this.bankAccount, this.creditLimit);
                ClearFields();
            }
            else
            {
                MessageBox.Show("This Client Id already exists.", this.Text,
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

            // Updating the properties of the Client this.client.
            this.client.ClientId = this.clientId;
            this.client.Name = this.clientName;
            this.client.PhoneNumber = this.phoneNumber;
            this.client.FaxNumber = this.faxNumber;
            this.client.Address = this.address;
            this.client.City = this.city;
            this.client.PostalCode = this.postalCode;
            this.client.BankNumber = this.bankNumber;
            this.client.BranchNumber = this.branchNumber;
            this.client.BankAccount = this.bankAccount;
            this.client.CreditLimit = this.creditLimit;

            // At this point this.client refers to an object inside ClientsCollection.
            // So the property updates above have also updated the Client object inside
            // that collection (refer to grdClients_CellMouseDoubleClick).

            // Grabbing the selected row.
            int selectedRow = this.grdClients.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdClients.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colClientId"].Value = this.client.ClientId;
            row.Cells["colClientName"].Value = this.client.Name;
            row.Cells["colPhoneNumber"].Value = this.client.PhoneNumber;
            row.Cells["colFaxNumber"].Value = this.client.FaxNumber;
            row.Cells["colAddress"].Value = this.client.Address;
            row.Cells["colCity"].Value = this.client.City;
            row.Cells["colPostalCode"].Value = this.client.PostalCode;
            row.Cells["colBankNumber"].Value = this.client.BankNumber;
            row.Cells["colBranchNumber"].Value = this.client.BranchNumber;
            row.Cells["colBankAccount"].Value = this.client.BankAccount;
            row.Cells["colCreditLimit"].Value = this.client.CreditLimit;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GetSelection();

            // Checking if the client has already placed any order.
            if ((OrdersCollection.GetOrderByClient(this.client.ClientId) != null))
            {
                MessageBox.Show("Removal is not possible. This client has already placed an order.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this client?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdClients.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdClients.Rows.RemoveAt(selectedRow);
                // Removing the client from ClientsCollection.
                ClientsCollection.RemoveClient(this.client);
            }

            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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

        private void grdClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignoring double-clicks on the fixed cells.
            if (e.RowIndex >= 0)
            {
                GetSelection();
            }
        }

        private void CheckPermissions()
        {
            // Retrieving the user's permissions.
            Permission permissions = PermissionsCollection.GetPermission(this.userLoggedIn.Username);

            this.btnAdd.Enabled = (permissions.ClientSaveUpdateDelete);
            this.btnUpdate.Enabled = (permissions.ClientSaveUpdateDelete);
            this.btnRemove.Enabled = (permissions.ClientSaveUpdateDelete);
        }

        private void ClearFields()
        {
            // Clearing the textboxes and maskedtextboxes.
            foreach (Control ctrl in grpClientInformation.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
                if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Clear();
                }
            }

            this.txtClientId.Text = ClientsCollection.NextClientId().ToString();

            if (this.Visible)
            {
                this.txtClientName.Focus();
            }
        }

        private void GetSelection()
        {
            // Retrieves client information from the selected row in grdClients.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdClients.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdClients.Rows[selectedRow];

                // Retrieving client information from the selected row.
                this.clientId = default(int);
                bool parseOKClientId = int.TryParse(row.Cells["colClientId"].Value.ToString(), out this.clientId);
                this.clientName = row.Cells["colClientName"].Value.ToString();
                this.phoneNumber = row.Cells["colPhoneNumber"].Value.ToString();
                this.faxNumber = row.Cells["colFaxNumber"].Value.ToString();
                this.address = row.Cells["colAddress"].Value.ToString();
                this.city = row.Cells["colCity"].Value.ToString();
                this.postalCode = row.Cells["colPostalCode"].Value.ToString();
                this.bankNumber = row.Cells["colBankNumber"].Value.ToString();
                this.branchNumber = row.Cells["colBranchNumber"].Value.ToString();
                this.bankAccount = row.Cells["colBankAccount"].Value.ToString();
                this.creditLimit = 0;
                bool parseOKCreditLimit = double.TryParse(row.Cells["colCreditLimit"].Value.ToString(), out this.creditLimit);

                // Retrieving the selected client from ClientsCollection
                // and storing it in the Client this.client.
                this.client = ClientsCollection.GetClient(this.clientId);

                // Showing the client information in the UI fields.
                if (this.client != null)
                {
                    this.txtClientId.Text = this.clientId.ToString();
                    this.txtClientName.Text = this.clientName;
                    this.mskPhoneNumber.Text = this.phoneNumber;
                    this.mskFaxNumber.Text = this.faxNumber;
                    this.txtAddress.Text = this.address;
                    this.txtCity.Text = this.city;
                    this.mskPostalCode.Text = this.postalCode;
                    this.mskBankNumber.Text = this.bankNumber;
                    this.mskBranchNumber.Text = this.branchNumber;
                    this.mskBankAccount.Text = this.bankAccount;
                    this.txtCreditLimit.Text = this.creditLimit.ToString();
                }
            }
        }

        private void LoadClients()
        {
            GenericList<int, Client> clientList = ClientsCollection.GetCollection();

            this.grdClients.Rows.Clear();

            for (int i = 0; i < clientList.GetCount(); i++)
            {
                Client client = clientList[i];

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdClients.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdClients.Rows[rowId];

                // Adding the data.
                row.Cells["colClientId"].Value = client.ClientId;
                row.Cells["colClientName"].Value = client.Name;
                row.Cells["colPhoneNumber"].Value = client.PhoneNumber;
                row.Cells["colFaxNumber"].Value = client.FaxNumber;
                row.Cells["colAddress"].Value = client.Address;
                row.Cells["colCity"].Value = client.City;
                row.Cells["colPostalCode"].Value = client.PostalCode;
                row.Cells["colBankNumber"].Value = client.BankNumber;
                row.Cells["colBranchNumber"].Value = client.BranchNumber;
                row.Cells["colBankAccount"].Value = client.BankAccount;
                row.Cells["colCreditLimit"].Value = client.CreditLimit;
            }
        }

        private bool ValidateFields()
        {
            // Loading the provided client information into the
            // non-UI fields (declared at the beginning of this class).
            this.clientId = default(int);
            bool parseOKClientId = int.TryParse(this.txtClientId.Text.Trim(), out this.clientId);
            this.clientName = this.txtClientName.Text.Trim();
            this.phoneNumber = this.mskPhoneNumber.Text.Trim();
            this.faxNumber = this.mskFaxNumber.Text.Trim();
            this.address = this.txtAddress.Text.Trim();
            this.city = this.txtCity.Text.Trim();
            this.postalCode = this.mskPostalCode.Text.Trim();
            this.bankNumber = this.mskBankNumber.Text.Trim();
            this.branchNumber = this.mskBranchNumber.Text.Trim();
            this.bankAccount = this.mskBankAccount.Text.Trim();
            this.creditLimit = 0;
            bool parseOKCreditLimit = double.TryParse(this.txtCreditLimit.Text.Trim(), out this.creditLimit);

            if (string.IsNullOrEmpty(this.clientName))
            {
                MessageBox.Show("Please enter the client's name.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtClientName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.phoneNumber))
            {
                MessageBox.Show("Please enter the client's phone number (format: XXX XXX XXXX).", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mskPhoneNumber.Focus();
                return false;
            }
            else
            {
                // this.phoneNumber does not contain the mask of mskPhoneNumber.
                // Checking if it contains only digits.
                Match m = Regex.Match(this.phoneNumber, @"^\d{10}$");
                if (!m.Success)
                {
                    MessageBox.Show("The client's phone number is in an incorrect format. Please use: XXX XXX XXXX", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.mskPhoneNumber.Focus();
                    return false;
                }
            }

            // Fax number can be empty, but if provided must follow the correct phone format.
            if (!string.IsNullOrEmpty(this.faxNumber))
            {
                // this.faxNumber does not contain the mask of mskFaxNumber.
                // Checking if it contains only digits.
                Match m = Regex.Match(this.faxNumber, @"^\d{10}$");
                if (!m.Success)
                {
                    MessageBox.Show("The client's fax number is in an incorrect format. Please use: XXX XXX XXXX", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.mskFaxNumber.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(this.address))
            {
                MessageBox.Show("Please enter the client's address.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.city))
            {
                MessageBox.Show("Please enter the client's city.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCity.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.postalCode))
            {
                MessageBox.Show("Please enter the client's postal code (format A1A 1A1, where A is a letter and 1 is a digit).", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mskPostalCode.Focus();
                return false;
            }
            else
            {
                // Canadian postal code regular expression validation taken from:
                // http://stackoverflow.com/questions/1146202/canadian-postal-code-validation
                Match m = Regex.Match(this.postalCode, @"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]$");
                if (!m.Success)
                {
                    MessageBox.Show("This is not a valid postal code. Please try again.", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.mskPostalCode.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(this.bankNumber))
            {
                MessageBox.Show("Please enter the client's bank number.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mskBankNumber.Focus();
                return false;
            }
            else
            {
                Match m = Regex.Match(this.faxNumber, @"^\d{3}$");
                if (!m.Success)
                {
                    MessageBox.Show("The bank number should be composed of 3 digits. Please try again.", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.mskBankNumber.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(this.branchNumber))
            {
                MessageBox.Show("Please enter the client's branch (transit) number.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mskBranchNumber.Focus();
                return false;
            }
            {
                Match m = Regex.Match(this.faxNumber, @"^\d{5}$");
                if (!m.Success)
                {
                    MessageBox.Show("The branch number should be composed of 5 digits. Please try again.", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.mskBranchNumber.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(this.bankAccount))
            {
                MessageBox.Show("Please enter the client's account number.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mskBankAccount.Focus();
                return false;
            }

            if (!parseOKCreditLimit || (this.creditLimit == 0))
            {
                MessageBox.Show("Please enter a valid non-zero credit limit for this client.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCreditLimit.Focus();
                return false;
            }

            return true;
        }
    }
}
