using Hitech.Business;
using Hitech.Data;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class CategoryForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private ProductForm productForm;
        private BookForm bookForm;
        private SoftwareForm softwareForm;

        private Category category = new Category();
        private int categoryId = default(int);
        private string description = string.Empty;


        public CategoryForm()
        {
            InitializeComponent();
        }

        public CategoryForm(User user, ProductForm productForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.productForm = productForm;
            this.btnSelectCategory.Visible = false;
        }

        public CategoryForm(User user, BookForm bookForm)
        {
            // This form can be opened via BookForm so that the user can choose
            // a category for the book she/he is adding/updating.
            //
            // If the category does not exist the user can add it in this window
            // and then select it by clicking btnSelectCategory. This button is
            // visible only when this form is opened from BookForm.
            //
            // If the user does not want to select a category she/he can click
            // on btnClose. This way no category will be sent back to BookForm.

            InitializeComponent();
            this.userLoggedIn = user;
            this.bookForm = bookForm;
            this.btnSelectCategory.Visible = true;
        }

        public CategoryForm(User user, SoftwareForm softwareForm)
        {
            // This form can be opened via SoftwareForm so that the user can choose
            // a category for the software she/he is adding/updating.
            //
            // If the category does not exist the user can add it in this window
            // and then select it by clicking btnSelectCategory. This button is
            // visible only when this form is opened from SoftwareForm.
            //
            // If the user does not want to select a category she/he can click
            // on btnClose. This way no category will be sent back to SoftwareForm.

            InitializeComponent();
            this.userLoggedIn = user;
            this.softwareForm = softwareForm;
            this.btnSelectCategory.Visible = true;
        }

        public Category SelectedCategory()
        {
            return this.category;
        }

        private void btnSelectCategory_Click(object sender, EventArgs e)
        {
            GetSelection();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadCategories();

            // These settings will make this form behave like
            // a dialog window that returns an answer when a button is clicked.
            // This way the calling form will know whether the user
            // selected a category or cancelled the operation.
            btnSelectCategory.DialogResult = DialogResult.OK;
            btnClose.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.category = new Category(this.categoryId, this.description);

            if (CategoriesCollection.AddCategory(this.category))
            {
                this.grdCategories.Rows.Add(this.categoryId, this.description);
                ClearFields();
            }
            else
            {
                MessageBox.Show("This Category Id already exists.", this.Text,
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

            // Updating the properties of the Category this.category.
            this.category.Description = this.description;

            // At this point this.category refers to an object inside CategoriesCollection.
            // So the property updates above have also updated the Category object inside
            // that collection (refer to grdCategories_CellMouseDoubleClick).

            // Grabbing the selected row.
            int selectedRow = this.grdCategories.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdCategories.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colCategoryId"].Value = this.category.CategoryId;
            row.Cells["colDescription"].Value = this.category.Description;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GetSelection();

            // Checking if the category is assigned to any product (book/software).
            if ((BooksCollection.GetBookByCategory(this.category.CategoryId) != null)
                || (SoftwaresCollection.GetSoftwareByCategory(this.category.CategoryId) != null))
            {
                MessageBox.Show("Removal is not possible. This category is assigned to one or more books/softwares.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this category?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdCategories.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdCategories.Rows.RemoveAt(selectedRow);
                // Removing the category from CategoriesCollection.
                CategoriesCollection.RemoveCategory(this.category);
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

        private void grdCategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignoring double-clicks on the fixed cells.
            if (e.RowIndex >= 0)
            {
                GetSelection();
            }
        }

        private void ClearFields()
        {
            this.txtCategoryId.Text = CategoriesCollection.NextCategoryId().ToString();
            this.txtDescription.Clear();

            if (this.Visible)
            {
                this.txtDescription.Focus();
            }
        }

        private void GetSelection()
        {
            // Retrieves category information from the selected row in grdCategories.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdCategories.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdCategories.Rows[selectedRow];

                // Retrieving category information from the selected row.
                this.categoryId = default(int);
                bool parseOKCategoryId = int.TryParse(row.Cells["colCategoryId"].Value.ToString(), out this.categoryId);
                this.description = row.Cells["colDescription"].Value.ToString();

                // Retrieving the selected category from CategoriesCollection
                // and storing it in the Category this.category.
                this.category = CategoriesCollection.GetCategory(this.categoryId);

                // Showing the category information in the UI fields.
                if (this.category != null)
                {
                    this.txtCategoryId.Text = this.categoryId.ToString();
                    this.txtDescription.Text = this.description;
                }
            }
        }

        private void LoadCategories()
        {
            GenericList<int, Category> categoryList = CategoriesCollection.GetCollection();

            this.grdCategories.Rows.Clear();

            for (int i = 0; i < categoryList.GetCount(); i++)
            {
                Category category = categoryList[i];

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdCategories.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdCategories.Rows[rowId];

                // Adding the data.
                row.Cells["colCategoryId"].Value = category.CategoryId;
                row.Cells["colDescription"].Value = category.Description;
            }
        }

        private bool ValidateFields()
        {
            // Loading the provided category information into the
            // non-UI fields (declared at the beginning of this class).
            this.categoryId = default(int);
            bool parseOKCategoryId = int.TryParse(this.txtCategoryId.Text.Trim(), out this.categoryId);
            this.description = this.txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(this.description))
            {
                MessageBox.Show("Please enter the category's description.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtDescription.Focus();
                return false;
            }

            return true;
        }
    }
}
