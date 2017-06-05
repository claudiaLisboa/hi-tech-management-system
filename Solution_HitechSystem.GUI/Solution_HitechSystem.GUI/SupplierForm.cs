using Hitech.Business;
using Hitech.Data;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class SupplierForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private ProductForm productForm;
        private BookForm bookForm;
        private SoftwareForm softwareForm;

        private Supplier supplier = new Supplier();
        private int supplierId = default(int);
        private string supplierName = string.Empty;
        private string address = string.Empty;
        private string city = string.Empty;
        private string postalCode = string.Empty;
        private string phoneNumber = string.Empty;


        public SupplierForm()
        {
            InitializeComponent();
        }

        public SupplierForm(User user, ProductForm productForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.productForm = productForm;
            this.btnSelectSupplier.Visible = false;
        }

        public SupplierForm(User user, BookForm bookForm)
        {
            // This form can be opened via BookForm so that the user can choose
            // a supplier for the book she/he is adding/updating.
            //
            // If the supplier does not exist the user can add it in this window
            // and then select it by clicking btnSelectSupplier. This button is
            // visible only when this form is opened from BookForm.
            //
            // If the user does not want to select a supplier she/he can click
            // on btnClose. This way no supplier will be sent back to BookForm.

            InitializeComponent();
            this.userLoggedIn = user;
            this.bookForm = bookForm;
            this.btnSelectSupplier.Visible = true;
        }

        public SupplierForm(User user, SoftwareForm softwareForm)
        {
            // This form can be opened via SoftwareForm so that the user can choose
            // a supplier for the software she/he is adding/updating.
            //
            // If the supplier does not exist the user can add it in this window
            // and then select it by clicking btnSelectSupplier. This button is
            // visible only when this form is opened from SoftwareForm.
            //
            // If the user does not want to select a supplier she/he can click
            // on btnClose. This way no supplier will be sent back to SoftwareForm.

            InitializeComponent();
            this.userLoggedIn = user;
            this.softwareForm = softwareForm;
            this.btnSelectSupplier.Visible = true;
        }

        public Supplier SelectedSupplier()
        {
            return this.supplier;
        }

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            GetSelection();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadSuppliers();

            // These settings will make this form behave like
            // a dialog window that returns an answer when a button is clicked.
            // This way the calling form will know whether the user
            // selected a supplier or cancelled the operation.
            btnSelectSupplier.DialogResult = DialogResult.OK;
            btnClose.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.supplier = new Supplier(this.supplierId, this.supplierName,
                this.address, this.city, this.postalCode, this.phoneNumber);

            if (SuppliersCollection.AddSupplier(this.supplier))
            {
                this.grdSuppliers.Rows.Add(this.supplierId, this.supplierName, this.phoneNumber,
                    this.address, this.city, this.postalCode);
                ClearFields();
            }
            else
            {
                MessageBox.Show("This Supplier Id already exists.", this.Text,
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

            // Updating the properties of the Supplier this.supplier.
            this.supplier.SupplierId = this.supplierId;
            this.supplier.Name = this.supplierName;
            this.supplier.PhoneNumber = this.phoneNumber;
            this.supplier.Address = this.address;
            this.supplier.City = this.city;
            this.supplier.PostalCode = this.postalCode;

            // At this point this.supplier refers to an object inside SuppliersCollection.
            // So the property updates above have also updated the Supplier object inside
            // that collection (refer to grdSuppliers_CellMouseDoubleClick).

            // Grabbing the selected row.
            int selectedRow = this.grdSuppliers.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdSuppliers.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colSupplierId"].Value = this.supplier.SupplierId;
            row.Cells["colSupplierName"].Value = this.supplier.Name;
            row.Cells["colPhoneNumber"].Value = this.supplier.PhoneNumber;
            row.Cells["colAddress"].Value = this.supplier.Address;
            row.Cells["colCity"].Value = this.supplier.City;
            row.Cells["colPostalCode"].Value = this.supplier.PostalCode;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GetSelection();

            // Checking if the supplier is assigned to any product (book/software).
            if ((BooksCollection.GetBookBySupplier(this.supplier.SupplierId) != null)
                || (SoftwaresCollection.GetSoftwareBySupplier(this.supplier.SupplierId) != null))
            {
                MessageBox.Show("Removal is not possible. This supplier is assigned to one or more books/softwares.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this supplier?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdSuppliers.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdSuppliers.Rows.RemoveAt(selectedRow);
                // Removing the supplier from SuppliersCollection.
                SuppliersCollection.RemoveSupplier(this.supplier);
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

        private void grdSuppliers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignoring double-clicks on the fixed cells.
            if (e.RowIndex >= 0)
            {
                GetSelection();
            }
        }

        private void ClearFields()
        {
            // Clearing the textboxes and maskedtextboxes.
            foreach (Control ctrl in grpSupplierInformation.Controls)
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

            this.txtSupplierId.Text = SuppliersCollection.NextSupplierId().ToString();

            if (this.Visible)
            {
                this.txtSupplierName.Focus();
            }
        }

        private void GetSelection()
        {
            // Retrieves supplier information from the selected row in grdSuppliers.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdSuppliers.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdSuppliers.Rows[selectedRow];

                // Retrieving supplier information from the selected row.
                this.supplierId = default(int);
                bool parseOKSupplierId = int.TryParse(row.Cells["colSupplierId"].Value.ToString(), out this.supplierId);
                this.supplierName = row.Cells["colSupplierName"].Value.ToString();
                this.phoneNumber = row.Cells["colPhoneNumber"].Value.ToString();
                this.address = row.Cells["colAddress"].Value.ToString();
                this.city = row.Cells["colCity"].Value.ToString();
                this.postalCode = row.Cells["colPostalCode"].Value.ToString();

                // Retrieving the selected supplier from SuppliersCollection
                // and storing it in the Supplier this.supplier.
                this.supplier = SuppliersCollection.GetSupplier(this.supplierId);

                // Showing the supplier information in the UI fields.
                if (this.supplier != null)
                {
                    this.txtSupplierId.Text = this.supplierId.ToString();
                    this.txtSupplierName.Text = this.supplierName;
                    this.mskPhoneNumber.Text = this.phoneNumber;
                    this.txtAddress.Text = this.address;
                    this.txtCity.Text = this.city;
                    this.mskPostalCode.Text = this.postalCode;
                }
            }
        }

        private void LoadSuppliers()
        {
            GenericList<int, Supplier> supplierList = SuppliersCollection.GetCollection();

            this.grdSuppliers.Rows.Clear();

            for (int i = 0; i < supplierList.GetCount(); i++)
            {
                Supplier supplier = supplierList[i];

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdSuppliers.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdSuppliers.Rows[rowId];
                
                // Adding the data.
                row.Cells["colSupplierId"].Value = supplier.SupplierId;
                row.Cells["colSupplierName"].Value = supplier.Name;
                row.Cells["colPhoneNumber"].Value = supplier.PhoneNumber;
                row.Cells["colAddress"].Value = supplier.Address;
                row.Cells["colCity"].Value = supplier.City;
                row.Cells["colPostalCode"].Value = supplier.PostalCode;
            }
        }

        private bool ValidateFields()
        {
            // Loading the provided supplier information into the
            // non-UI fields (declared at the beginning of this class).
            this.supplierId = default(int);
            bool parseOKSupplierId = int.TryParse(this.txtSupplierId.Text.Trim(), out this.supplierId);
            this.supplierName = this.txtSupplierName.Text.Trim();
            this.phoneNumber = this.mskPhoneNumber.Text.Trim();
            this.address = this.txtAddress.Text.Trim();
            this.city = this.txtCity.Text.Trim();
            this.postalCode = this.mskPostalCode.Text.Trim();

            if (string.IsNullOrEmpty(this.supplierName))
            {
                MessageBox.Show("Please enter the supplier's name.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtSupplierName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.phoneNumber))
            {
                MessageBox.Show("Please enter the supplier's phone number (format: XXX XXX XXXX).", this.Text,
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
                    MessageBox.Show("The supplier's phone number is in an incorrect format. Please use: XXX XXX XXXX", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.mskPhoneNumber.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(this.address))
            {
                MessageBox.Show("Please enter the supplier's address.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.city))
            {
                MessageBox.Show("Please enter the supplier's city.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCity.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.postalCode))
            {
                MessageBox.Show("Please enter the supplier's postal code (format A1A 1A1, where A is a letter and 1 is a digit).", this.Text,
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

            return true;
        }
    }
}
