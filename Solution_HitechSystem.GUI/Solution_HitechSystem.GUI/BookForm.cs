using Hitech.Business;
using Hitech.Data;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class BookForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private ProductForm productForm;

        private Book book = new Book();
        private int bookId = default(int);
        private string title = string.Empty;
        private string isbn = string.Empty;
        private int yearPublished = 1900;
        private int supplierId = default(int);
        private int authorId = default(int);
        private int categoryId = default(int);
        private int quantityOnHand = default(int);
        private double unitPrice = default(double);

        public BookForm()
        {
            InitializeComponent();
        }

        public BookForm(User user, ProductForm productForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.productForm = productForm;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.book = new Book(this.bookId, ProductType.Book, this.categoryId, this.title,
                this.supplierId, this.unitPrice, this.quantityOnHand, this.isbn, this.authorId, this.yearPublished);

            // Retrieving category/supplier/author associated with this book in order to show the description/name.
            Category category = CategoriesCollection.GetCategory(this.categoryId);
            Supplier supplier = SuppliersCollection.GetSupplier(this.supplierId);
            Author author = AuthorsCollection.GetAuthor(this.authorId);

            if (BooksCollection.AddBook(this.book))
            {
                this.grdBooks.Rows.Add(this.bookId, this.title, this.isbn, this.yearPublished,
                    this.supplierId, supplier.Name, this.authorId, author.FullName, this.categoryId, category.Description,
                    this.quantityOnHand, this.quantityOnHand);
                ClearFields();
            }
            else
            {
                MessageBox.Show("This Book Id already exists.", this.Text,
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

            // Updating the properties of the Book this.book.
            this.book.ProductName = this.title;
            this.book.ISBN = this.isbn;
            this.book.YearPublished = this.yearPublished;
            this.book.SupplierId = this.supplierId;
            this.book.AuthorId = this.authorId;
            this.book.CategoryId = this.categoryId;
            this.book.QuantityOnHand = this.quantityOnHand;
            this.book.UnitPrice = this.unitPrice;

            // At this point this.book refers to an object inside BooksCollection.
            // So the property updates above have also updated the Book object inside
            // that collection (refer to grdBooks_CellMouseDoubleClick).

            // Grabbing the selected row.
            int selectedRow = this.grdBooks.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdBooks.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colBookId"].Value = this.book.ProductId;
            row.Cells["colProductName"].Value = this.book.ProductName;
            row.Cells["colISBN"].Value = this.book.ISBN;
            row.Cells["colYearPublished"].Value = this.book.YearPublished;
            row.Cells["colSupplierId"].Value = this.book.SupplierId;
            row.Cells["colSupplierName"].Value = this.txtSupplier.Text;
            row.Cells["colAuthorId"].Value = this.book.AuthorId;
            row.Cells["colAuthorFullName"].Value = this.txtAuthor.Text;
            row.Cells["colCategoryId"].Value = this.book.CategoryId;
            row.Cells["colCategoryDescription"].Value = this.txtCategory.Text;
            row.Cells["colQuantityOnHand"].Value = this.book.QuantityOnHand;
            row.Cells["colUnitPrice"].Value = this.book.UnitPrice;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GetSelection();

            //TODO: check if the book appears in any client order.
            // Checking if the category is assigned to any product (book/software).
            //if ((BooksCollection.GetBookByCategory(this.category.CategoryId) != null)
            //    || (SoftwaresCollection.GetSoftwareByCategory(this.category.CategoryId) != null))
            //{
            //    MessageBox.Show("Removal is not possible. This category is assigned to one or more books/softwares.", this.Text,
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this book?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdBooks.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdBooks.Rows.RemoveAt(selectedRow);
                // Removing the book from BooksCollection.
                BooksCollection.RemoveBook(this.book);
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
            // This button shows SupplierForm so that the user can choose a supplier for the book.

            SupplierForm frm = new SupplierForm(this.userLoggedIn, this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Supplier supplier = frm.SelectedSupplier();
                this.txtSupplierId.Text = supplier.SupplierId.ToString();
                this.txtSupplier.Text = supplier.Name;
            }
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            // This button shows AuthorForm so that the user can choose an author for the book.

            AuthorForm frm = new AuthorForm(this.userLoggedIn, this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Author author = frm.SelectedAuthor();
                this.txtAuthorId.Text = author.AuthorId.ToString();
                this.txtAuthor.Text = author.FullName;
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            // This button shows CategoryForm so that the user can choose a category for the book.

            CategoryForm frm = new CategoryForm(this.userLoggedIn, this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Category category = frm.SelectedCategory();
                this.txtCategoryId.Text = category.CategoryId.ToString();
                this.txtCategory.Text = category.Description;
            }
        }

        private void grdBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            foreach (Control ctrl in grpBookInformation.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }

            this.txtBookId.Text = BooksCollection.NextBookId().ToString();

            if (this.Visible)
            {
                this.txtTitle.Focus();
            }
        }

        private void GetSelection()
        {
            // Retrieves book information from the selected row in grdBooks.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdBooks.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdBooks.Rows[selectedRow];

                // Retrieving book information from the selected row.
                this.bookId = default(int);
                bool parseOKBookId = int.TryParse(row.Cells["colBookId"].Value.ToString(), out this.bookId);
                this.title = row.Cells["colProductName"].Value.ToString();
                this.isbn = row.Cells["colISBN"].Value.ToString();
                this.yearPublished = 1900;
                bool parseOKYearPublished = int.TryParse(row.Cells["colYearPublished"].Value.ToString(), out this.yearPublished);
                this.supplierId = default(int);
                bool parseOKSupplierId = int.TryParse(row.Cells["colSupplierId"].Value.ToString(), out this.supplierId);
                string supplierFullName = row.Cells["colSupplierName"].Value.ToString();
                this.authorId = default(int);
                bool parseOKAuthorId = int.TryParse(row.Cells["colAuthorId"].Value.ToString(), out this.authorId);
                string authorFullName = row.Cells["colAuthorFullName"].Value.ToString();
                this.categoryId = default(int);
                bool parseOKCategoryId = int.TryParse(row.Cells["colCategoryId"].Value.ToString(), out this.categoryId);
                string categoryDescription = row.Cells["colCategoryDescription"].Value.ToString();
                this.quantityOnHand = 0;
                bool parseOKQuantityOnHand = int.TryParse(row.Cells["colQuantityOnHand"].Value.ToString(), out this.quantityOnHand);
                this.unitPrice = 0;
                bool parseOKUnitPrice = double.TryParse(row.Cells["colUnitPrice"].Value.ToString(), out this.unitPrice);

                // Retrieving the selected book from BooksCollection
                // and storing it in the Book this.book.
                this.book = BooksCollection.GetBook(this.bookId);

                // Showing the book information in the UI fields.
                if (this.book != null)
                {
                    this.txtBookId.Text = this.bookId.ToString();
                    this.txtTitle.Text = this.title;
                    this.txtISBN.Text = this.isbn;
                    this.txtYearPublished.Text = this.yearPublished.ToString();
                    this.txtSupplierId.Text = this.supplierId.ToString();
                    this.txtSupplier.Text = supplierFullName;
                    this.txtAuthorId.Text = this.authorId.ToString();
                    this.txtAuthor.Text = authorFullName;
                    this.txtCategoryId.Text = this.categoryId.ToString();
                    this.txtCategory.Text = categoryDescription;
                    this.txtQuantityOnHand.Text = this.quantityOnHand.ToString();
                    this.txtUnitPrice.Text = this.unitPrice.ToString();
                }
            }
        }

        private void LoadBooks()
        {
            GenericList<int, Book> bookList = BooksCollection.GetCollection();

            this.grdBooks.Rows.Clear();

            for (int i = 0; i < bookList.GetCount(); i++)
            {
                Book book = bookList[i];
                Supplier supplier = SuppliersCollection.GetSupplier(book.SupplierId);
                Author author = AuthorsCollection.GetAuthor(book.AuthorId);
                Category category = CategoriesCollection.GetCategory(book.CategoryId);

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdBooks.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdBooks.Rows[rowId];

                // Adding the data.
                row.Cells["colBookId"].Value = book.ProductId;
                row.Cells["colProductName"].Value = book.ProductName;
                row.Cells["colISBN"].Value = book.ISBN;
                row.Cells["colYearPublished"].Value = book.YearPublished;
                row.Cells["colSupplierId"].Value = book.SupplierId;
                row.Cells["colSupplierName"].Value = supplier.Name;
                row.Cells["colAuthorId"].Value = book.AuthorId;
                row.Cells["colAuthorFullName"].Value = author.FullName;
                row.Cells["colCategoryId"].Value = book.CategoryId;
                row.Cells["colCategoryDescription"].Value = category.Description;
                row.Cells["colQuantityOnHand"].Value = book.QuantityOnHand;
                row.Cells["colUnitPrice"].Value = book.UnitPrice;
            }
        }

        private bool ValidateFields()
        {
            // Loading the provided book information into the
            // non-UI fields (declared at the beginning of this class).
            this.bookId = default(int);
            bool parseOKBookId = int.TryParse(this.txtBookId.Text.Trim(), out this.bookId);
            this.title = this.txtTitle.Text.Trim();
            this.isbn = this.txtISBN.Text.Trim();
            this.yearPublished = 0;
            bool parseOKYearPublished = int.TryParse(this.txtYearPublished.Text.Trim(), out this.yearPublished);
            this.supplierId = default(int);
            bool parseOKSupplierId = int.TryParse(this.txtSupplierId.Text.Trim(), out this.supplierId);
            this.authorId = default(int);
            bool parseOKAuthorId = int.TryParse(this.txtAuthorId.Text.Trim(), out this.authorId);
            this.categoryId = default(int);
            bool parseOKCategoryId = int.TryParse(this.txtCategoryId.Text.Trim(), out this.categoryId);
            this.quantityOnHand = 0;
            bool parseOKQuantityOnHand = int.TryParse(this.txtQuantityOnHand.Text.Trim(), out this.quantityOnHand);
            this.unitPrice = 0;
            bool parseOKUnitPrice = double.TryParse(this.txtUnitPrice.Text.Trim(), out this.unitPrice);

            if (string.IsNullOrEmpty(this.title))
            {
                MessageBox.Show("Please enter the book's title.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtTitle.Focus();
                return false;
            }

            //TODO: validate ISBN format.
            if (string.IsNullOrEmpty(this.isbn))
            {
                MessageBox.Show("Please enter the book's ISBN.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtISBN.Focus();
                return false;
            }

            if (!parseOKYearPublished || (this.yearPublished == default(int)))
            {
                MessageBox.Show("Please enter the year the book was published.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtYearPublished.Focus();
                return false;
            }
            else
            {
                // Checking whether this.yearPublished is within an acceptable range.
                if ((this.yearPublished < 1940) || (this.yearPublished > DateTime.Now.Year))
                {
                    MessageBox.Show("The year you entered seems incorrect. Please try again.", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtYearPublished.Focus();
                    return false;
                }
            }

            if (!parseOKSupplierId || (this.supplierId == default(int)))
            {
                MessageBox.Show("Please enter the book's supplier.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtSupplier.Focus();
                return false;
            }

            if (!parseOKAuthorId || (this.authorId == default(int)))
            {
                MessageBox.Show("Please enter the book's author.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtAuthor.Focus();
                return false;
            }

            if (!parseOKCategoryId || (this.categoryId == default(int)))
            {
                MessageBox.Show("Please select a category for this book.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCategory.Focus();
                return false;
            }

            if (!parseOKQuantityOnHand || (this.quantityOnHand < 0))
            {
                // Just checking whether the value entered is a valid number or whether the value is negative.
                // Not checking if it is greater than zero because the book might be out of stock.

                MessageBox.Show("Please enter a valid quantity on hand. Enter 0 (zero) if the book is out of stock.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtQuantityOnHand.Focus();
                return false;
            }

            if (!parseOKUnitPrice || (this.unitPrice <= 0))
            {
                MessageBox.Show("Please enter a valid unit price for this book.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtUnitPrice.Focus();
                return false;
            }

            return true;
        }
    }
}
