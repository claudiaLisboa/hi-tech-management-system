using Hitech.Business;
using Hitech.Data;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class AuthorForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private ProductForm productForm;
        private BookForm bookForm;
        
        private Author author = new Author();
        private int authorId = default(int);
        private string firstName = string.Empty;
        private string lastName = string.Empty;


        public AuthorForm()
        {
            InitializeComponent();
        }

        public AuthorForm(User user, ProductForm productForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.productForm = productForm;
            this.btnSelectAuthor.Visible = false;
        }

        public AuthorForm(User user, BookForm bookForm)
        {
            // This form can be opened via BookForm so that the user can choose
            // an author for the book she/he is adding/updating.
            //
            // If the author does not exist the user can add it in this window
            // and then select it by clicking btnSelectAuthor. This button is
            // visible only when this form is opened from BookForm.
            //
            // If the user does not want to select an author she/he can click
            // on btnClose. This way no author will be sent back to BookForm.

            InitializeComponent();
            this.userLoggedIn = user;
            this.bookForm = bookForm;
            this.btnSelectAuthor.Visible = true;
        }

        public Author SelectedAuthor()
        {
            return this.author;
        }

        private void btnSelectAuthor_Click(object sender, EventArgs e)
        {
            GetSelection();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            LoadAuthors();

            // These settings will make this form behave like
            // a dialog window that returns an answer when a button is clicked.
            // This way the calling form will know whether the user
            // selected an author or cancelled the operation.
            btnSelectAuthor.DialogResult = DialogResult.OK;
            btnClose.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            this.author = new Author(this.authorId, this.firstName, this.lastName);

            if (AuthorsCollection.AddAuthor(this.author))
            {
                this.grdAuthors.Rows.Add(this.authorId, this.firstName, this.lastName);
                ClearFields();
            }
            else
            {
                MessageBox.Show("This Author Id already exists.", this.Text,
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

            // Updating the properties of the Author this.author.
            this.author.FirstName = this.firstName;
            this.author.LastName = this.lastName;

            // At this point this.author refers to an object inside AuthorsCollection.
            // So the property updates above have also updated the Author object inside
            // that collection (refer to grdAuthors_CellMouseDoubleClick).

            // Grabbing the selected row.
            int selectedRow = this.grdAuthors.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataGridViewRow row = this.grdAuthors.Rows[selectedRow];

            // Updating the row data.
            row.Cells["colAuthorId"].Value = this.author.AuthorId;
            row.Cells["colFirstName"].Value = this.author.FirstName;
            row.Cells["colLastName"].Value = this.author.LastName;

            ClearFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GetSelection();

            // Checking whether is already assigned to a book.
            if (BooksCollection.GetBookByAuthor(this.author.AuthorId) != null)
            {
                MessageBox.Show("Removal is not possible. This author is assigned to one or more books.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Confirming the removal.
            string msgConfirmation = "Are you sure you want to remove this author?";
            DialogResult dlgResult = MessageBox.Show(msgConfirmation, this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResult == DialogResult.No)
            {
                return;
            }

            // Grabbing the selected row and removing it.
            int selectedRow = this.grdAuthors.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                // Removing the selected row.
                this.grdAuthors.Rows.RemoveAt(selectedRow);
                // Removing the author from AuthorsCollection.
                AuthorsCollection.RemoveAuthor(this.author);
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

        private void grdAuthors_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignoring double-clicks on the fixed cells.
            if (e.RowIndex >= 0)
            {
                GetSelection();
            }
        }

        private void ClearFields()
        {
            this.txtAuthorId.Text = AuthorsCollection.NextAuthorId().ToString();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();

            if (this.Visible)
            {
                this.txtFirstName.Focus();
            }
        }

        private void GetSelection()
        {
            // Retrieves author information from the selected row in grdAuthors.
            // The information is loaded into the non-UI fields (declared at the
            // beginning of this class) and is shown in the UI fields so the
            // logged in user can update/remove it.

            int selectedRow = this.grdAuthors.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selectedRow >= 0)
            {
                DataGridViewRow row = this.grdAuthors.Rows[selectedRow];

                // Retrieving author information from the selected row.
                this.authorId = default(int);
                bool parseOKAuthorId = int.TryParse(row.Cells["colAuthorId"].Value.ToString(), out this.authorId);
                this.firstName = row.Cells["colFirstName"].Value.ToString();
                this.lastName = row.Cells["colLastName"].Value.ToString();

                // Retrieving the selected author from AuthorsCollection
                // and storing it in the Author this.author.
                this.author = AuthorsCollection.GetAuthor(this.authorId);

                // Showing the author information in the UI fields.
                if (this.author != null)
                {
                    this.txtAuthorId.Text = this.authorId.ToString();
                    this.txtFirstName.Text = this.firstName;
                    this.txtLastName.Text = this.lastName;
                }
            }
        }

        private void LoadAuthors()
        {
            GenericList<int, Author> authorList = AuthorsCollection.GetCollection();

            this.grdAuthors.Rows.Clear();

            for (int i = 0; i < authorList.GetCount(); i++)
            {
                Author author = authorList[i];

                // Creating a new row first as it will include the columns created at design-time.
                int rowId = this.grdAuthors.Rows.Add();

                // Grabbing the new row.
                DataGridViewRow row = this.grdAuthors.Rows[rowId];

                // Adding the data.
                row.Cells["colAuthorId"].Value = author.AuthorId;
                row.Cells["colFirstName"].Value = author.FirstName;
                row.Cells["colLastName"].Value = author.LastName;
            }
        }

        private bool ValidateFields()
        {
            // Loading the provided author information into the
            // non-UI fields (declared at the beginning of this class).
            this.authorId = default(int);
            bool parseOKAuthorId = int.TryParse(this.txtAuthorId.Text.Trim(), out this.authorId);
            this.firstName = this.txtFirstName.Text.Trim();
            this.lastName = this.txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(this.firstName))
            {
                MessageBox.Show("Please enter the author's first name.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.lastName))
            {
                MessageBox.Show("Please enter the author's last name.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtLastName.Focus();
                return false;
            }

            return true;
        }
    }
}
