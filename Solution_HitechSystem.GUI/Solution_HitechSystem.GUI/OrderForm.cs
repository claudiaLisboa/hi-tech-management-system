using Hitech.Business;
using Hitech.Data;
using System;
using System.Windows.Forms;

namespace Solution_HitechSystem.GUI
{
    public partial class OrderForm : Form
    {
        // User logged into the system.
        private User userLoggedIn;
        private MainForm mainForm;


        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(User user, MainForm mainForm)
        {
            InitializeComponent();
            this.userLoggedIn = user;
            this.mainForm = mainForm;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClient_Click(object sender, System.EventArgs e)
        {
            // This button shows ClientForm so that the user can choose a client for the order.

            ClientForm frm = new ClientForm(this.userLoggedIn, this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Client client = frm.SelectedClient();
                this.txtClientId.Text = client.ClientId.ToString();
                this.txtClient.Text = client.Name;
            }
        }

        private void btnProduct_Click(object sender, System.EventArgs e)
        {
            // This button shows SelectProductForm so that the user can choose a product for the order line.

            SelectProductForm frm = new SelectProductForm(this.userLoggedIn, this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Product product = frm.SelectedProduct();
                Category category = CategoriesCollection.GetCategory(product.CategoryId);

                this.txtProductId.Text = product.ProductId.ToString();
                this.txtProductType.Text = product.Type.ToString();
                this.txtPrice.Text = product.UnitPrice.ToString();

                this.txtProduct.Text = string.Empty;
                this.txtProduct.AppendText(product.ProductName);
                if (product.Type == ProductType.Book)
                {
                    Book book = (Book)product;
                    Author author = AuthorsCollection.GetAuthor(book.AuthorId);
                    this.txtProduct.AppendText(Environment.NewLine);
                    this.txtProduct.AppendText(author.FullName);
                }
                this.txtProduct.AppendText(Environment.NewLine);
                this.txtProduct.AppendText(category.Description);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            HiTechDB.SaveData();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            // Clearing the textboxes.
            foreach (Control ctrl in grpOrder.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
            this.dtpOrderDate.Value = DateTime.Now;
            this.radEmail.Checked = true;
            this.txtOrderId.Text = OrdersCollection.NextOrderId().ToString();

            if (this.Visible)
            {
                this.dtpOrderDate.Focus();
            }
        }
    }
}
