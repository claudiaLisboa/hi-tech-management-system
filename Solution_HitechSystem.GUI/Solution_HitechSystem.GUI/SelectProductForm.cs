using Hitech.Business;
using Hitech.Data;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class SelectProductForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private OrderForm orderForm;

        private Product product = default(Product);

        
        public SelectProductForm()
        {
            InitializeComponent();
        }

        public SelectProductForm(User user, OrderForm orderForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.orderForm = orderForm;
        }

        public Product SelectedProduct()
        {
            return this.product;
        }

        private void SelectProductForm_Load(object sender, System.EventArgs e)
        {
            LoadBooks();
            LoadSofwares();

            // These settings will make this form behave like
            // a dialog window that returns an answer when a button is clicked.
            // This way the calling form will know whether the user
            // selected a product (book/sofware) or cancelled the operation.
            btnSelectBook.DialogResult = DialogResult.OK;
            btnSelectSoftware.DialogResult = DialogResult.OK;
            btnClose.DialogResult = DialogResult.Cancel;
        }

        private void btnSelectBook_Click(object sender, System.EventArgs e)
        {
            this.product = GetBookSelection();

            if (this.product != default(Product))
            {
                // A book has been selected in grdBooks.
                // Since btnSelectBook.DialogResult is equal to DialogResult.OK
                // then this form will be automatically closed and the calling
                // form will receive the answer DialogResult.OK.
            }
            else
            {
                // No book has been selected.
                // Changing this form's DialogResult so that the calling form
                // will know that no book has been selected.
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSelectSoftware_Click(object sender, System.EventArgs e)
        {
            this.product = GetSoftwareSelection();

            if (this.product != default(Product))
            {
                // A software has been selected in grdSoftwares.
                // Since btnSelectSoftware.DialogResult is equal to DialogResult.OK
                // then this form will be automatically closed and the calling
                // form will receive the answer DialogResult.OK.
            }
            else
            {
                // No software has been selected.
                // Changing this form's DialogResult so that the calling form
                // will know that no software has been selected.
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private Product GetBookSelection()
        {
            // Retrieves the book from the selected row in grdBooks.

            int selectedRow = this.grdBooks.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdBooks.Rows[selectedRow];

                // Retrieving book information from the selected row.
                int bookId = default(int);
                bool parseOKBookId = int.TryParse(row.Cells["colBookId"].Value.ToString(), out bookId);

                // Retrieving the selected book from BooksCollection.
                return BooksCollection.GetBook(bookId);
            }
            else
            {
                return default(Product);
            }
        }

        private Product GetSoftwareSelection()
        {
            // Retrieves the software from the selected row in grdSoftwares.

            int selectedRow = this.grdSoftwares.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdSoftwares.Rows[selectedRow];

                // Retrieving software information from the selected row.
                int softwareId = default(int);
                bool parseOKSoftwareId = int.TryParse(row.Cells["colSoftwareId"].Value.ToString(), out softwareId);

                // Retrieving the selected software from SoftwaresCollection
                return SoftwaresCollection.GetSoftware(softwareId);
            }
            else
            {
                return default(Product);
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
    }
}
