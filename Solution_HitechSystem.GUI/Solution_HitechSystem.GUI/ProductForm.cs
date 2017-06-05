using Hitech.Business;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class ProductForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private MainForm mainForm;

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(User user, MainForm mainForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.mainForm = mainForm;
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            AuthorForm frm = new AuthorForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm frm = new SupplierForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm frm = new BookForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }

        private void btnSoftwares_Click(object sender, EventArgs e)
        {
            SoftwareForm frm = new SoftwareForm(this.userLoggedIn, this);
            frm.ShowDialog();
        }
    }
}
