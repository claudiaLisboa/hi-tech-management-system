using Hitech.Business;
using Hitech.Data;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class SoftwareForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private ProductForm productForm;

        private Software software = new Software();
        private int softwareId = default(int);
        private string softwareName = string.Empty;
        private int supplierId = default(int);
        private int categoryId = default(int);
        private int quantityOnHand = default(int);
        private double unitPrice = default(double);

        public SoftwareForm()
        {
            InitializeComponent();
        }

        public SoftwareForm(User user, ProductForm productForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.productForm = productForm;
        }

        private void SoftwareForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadSofwares();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.software = new Software(this.softwareId, ProductType.Software, this.categoryId, this.softwareName,
                this.supplierId, this.unitPrice, this.quantityOnHand);

            // Retrieving category/supplier associated with this software in order to show the description/name.
            Category category = CategoriesCollection.GetCategory(this.categoryId);
            Supplier supplier = SuppliersCollection.GetSupplier(this.supplierId);

            if (SoftwaresCollection.AddSoftware(this.software))
            {
                this.grdSoftwares.Rows.Add(this.softwareId, this.softwareName,
                    this.supplierId, supplier.Name, this.categoryId, category.Description,
                    this.quantityOnHand, this.quantityOnHand);
                ClearFields();
            }
            else
            {
                MessageBox.Show("This Software Id already exists.", this.Text,
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

            // Updating the properties of the Software this.software.
            this.software.ProductName = this.softwareName;
            this.software.SupplierId = this.supplierId;
            this.software.CategoryId = this.categoryId;
            this.software.QuantityOnHand = this.quantityOnHand;
            this.software.UnitPrice = this.unitPrice;

            // At this point this.software refers to an object inside SoftwaresCollection.
            // So the property updates above have also updated the Software object inside
            // that collection (refer to grdSoftwares_CellMouseDoubleClick).

            // Grabbing the selected row.
            int selectedRow = this.grdSoftwares.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdSoftwares.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colSoftwareId"].Value = this.software.ProductId;
            row.Cells["colProductName"].Value = this.software.ProductName;
            row.Cells["colSupplierId"].Value = this.software.SupplierId;
            row.Cells["colSupplierName"].Value = this.txtSupplier.Text;
            row.Cells["colCategoryId"].Value = this.software.CategoryId;
            row.Cells["colCategoryDescription"].Value = this.txtCategory.Text;
            row.Cells["colQuantityOnHand"].Value = this.software.QuantityOnHand;
            row.Cells["colUnitPrice"].Value = this.software.UnitPrice;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GetSelection();

            //TODO: check if the software appears in any client order.

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this software?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdSoftwares.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdSoftwares.Rows.RemoveAt(selectedRow);
                // Removing the software from SoftwaresCollection.
                SoftwaresCollection.RemoveSoftware(this.software);
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

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            // This button shows SupplierForm so that the user can choose a supplier for the software.

            SupplierForm frm = new SupplierForm(this.userLoggedIn, this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Supplier supplier = frm.SelectedSupplier();
                this.txtSupplierId.Text = supplier.SupplierId.ToString();
                this.txtSupplier.Text = supplier.Name;
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            // This button shows CategoryForm so that the user can choose a category for the software.

            CategoryForm frm = new CategoryForm(this.userLoggedIn, this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Category category = frm.SelectedCategory();
                this.txtCategoryId.Text = category.CategoryId.ToString();
                this.txtCategory.Text = category.Description;
            }
        }

        private void grdSoftwares_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignoring double-clicks on the fixed cells.
            if (e.RowIndex >= 0)
            {
                GetSelection();
            }
        }

        private void ClearFields()
        {
            // Clearing the textboxes.
            foreach (Control ctrl in grpSoftwareInformation.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }

            this.txtSoftwareId.Text = SoftwaresCollection.NextSoftwareId().ToString();

            if (this.Visible)
            {
                this.txtSoftwareName.Focus();
            }
        }

        private void GetSelection()
        {
            // Retrieves software information from the selected row in grdSoftwares.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdSoftwares.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdSoftwares.Rows[selectedRow];

                // Retrieving software information from the selected row.
                this.softwareId = default(int);
                bool parseOKSoftwareId = int.TryParse(row.Cells["colSoftwareId"].Value.ToString(), out this.softwareId);
                this.softwareName = row.Cells["colProductName"].Value.ToString();
                this.supplierId = default(int);
                bool parseOKSupplierId = int.TryParse(row.Cells["colSupplierId"].Value.ToString(), out this.supplierId);
                string supplierFullName = row.Cells["colSupplierName"].Value.ToString();
                this.categoryId = default(int);
                bool parseOKCategoryId = int.TryParse(row.Cells["colCategoryId"].Value.ToString(), out this.categoryId);
                string categoryDescription = row.Cells["colCategoryDescription"].Value.ToString();
                this.quantityOnHand = 0;
                bool parseOKQuantityOnHand = int.TryParse(row.Cells["colQuantityOnHand"].Value.ToString(), out this.quantityOnHand);
                this.unitPrice = 0;
                bool parseOKUnitPrice = double.TryParse(row.Cells["colUnitPrice"].Value.ToString(), out this.unitPrice);

                // Retrieving the selected software from SoftwaresCollection
                // and storing it in the Software this.software.
                this.software = SoftwaresCollection.GetSoftware(this.softwareId);

                // Showing the software information in the UI fields.
                if (this.software != null)
                {
                    this.txtSoftwareId.Text = this.softwareId.ToString();
                    this.txtSoftwareName.Text = this.softwareName;
                    this.txtSupplierId.Text = this.supplierId.ToString();
                    this.txtSupplier.Text = supplierFullName;
                    this.txtCategoryId.Text = this.categoryId.ToString();
                    this.txtCategory.Text = categoryDescription;
                    this.txtQuantityOnHand.Text = this.quantityOnHand.ToString();
                    this.txtUnitPrice.Text = this.unitPrice.ToString();
                }
            }
        }

        private void LoadSofwares()
        {
            GenericList<int, Software> softwareList = SoftwaresCollection.GetCollection();

            this.grdSoftwares.Rows.Clear();

            for (int i = 0; i < softwareList.GetCount(); i++)
            {
                Software software = softwareList[i];
                Supplier supplier = SuppliersCollection.GetSupplier(software.SupplierId);
                Category category = CategoriesCollection.GetCategory(software.CategoryId);

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdSoftwares.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdSoftwares.Rows[rowId];

                // Adding the data.
                row.Cells["colSoftwareId"].Value = software.ProductId;
                row.Cells["colProductName"].Value = software.ProductName;
                row.Cells["colSupplierId"].Value = software.SupplierId;
                row.Cells["colSupplierName"].Value = supplier.Name;
                row.Cells["colCategoryId"].Value = software.CategoryId;
                row.Cells["colCategoryDescription"].Value = category.Description;
                row.Cells["colQuantityOnHand"].Value = software.QuantityOnHand;
                row.Cells["colUnitPrice"].Value = software.UnitPrice;
            }
        }

        private bool ValidateFields()
        {
            // Loading the provided software information into the
            // non-UI fields (declared at the beginning of this class).
            this.softwareId = default(int);
            bool parseOKSoftwareId = int.TryParse(this.txtSoftwareId.Text.Trim(), out this.softwareId);
            this.softwareName = this.txtSoftwareName.Text.Trim();
            this.supplierId = default(int);
            bool parseOKSupplierId = int.TryParse(this.txtSupplierId.Text.Trim(), out this.supplierId);
            this.categoryId = default(int);
            bool parseOKCategoryId = int.TryParse(this.txtCategoryId.Text.Trim(), out this.categoryId);
            this.quantityOnHand = 0;
            bool parseOKQuantityOnHand = int.TryParse(this.txtQuantityOnHand.Text.Trim(), out this.quantityOnHand);
            this.unitPrice = 0;
            bool parseOKUnitPrice = double.TryParse(this.txtUnitPrice.Text.Trim(), out this.unitPrice);

            if (string.IsNullOrEmpty(this.softwareName))
            {
                MessageBox.Show("Please enter the software's name.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtSoftwareName.Focus();
                return false;
            }

            if (!parseOKSupplierId || (this.supplierId == default(int)))
            {
                MessageBox.Show("Please enter the software's supplier.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtSupplier.Focus();
                return false;
            }

            if (!parseOKCategoryId || (this.categoryId == default(int)))
            {
                MessageBox.Show("Please select a category for this software.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCategory.Focus();
                return false;
            }

            if (!parseOKQuantityOnHand || (this.quantityOnHand < 0))
            {
                // Just checking whether the value entered is a valid number or whether the value is negative.
                // Not checking if it is greater than zero because the software might be out of stock.

                MessageBox.Show("Please enter a valid quantity on hand. Enter 0 (zero) if the software is out of stock.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtQuantityOnHand.Focus();
                return false;
            }

            if (!parseOKUnitPrice || (this.unitPrice <= 0))
            {
                MessageBox.Show("Please enter a valid unit price for this software.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUnitPrice.Focus();
                return false;
            }

            return true;
        }
    }
}
