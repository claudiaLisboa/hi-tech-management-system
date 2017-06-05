namespace Hitech.Business
{
    public class Book : Product
    {
        private string isbn;
        private int authorId;
        private int yearPublished;

        public string ISBN
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public int AuthorId
        {
            get { return this.authorId; }
            set { this.authorId = value; }
        }

        public int YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        //Default Constructor
        public Book(): base ()
        {
            this.isbn = string.Empty;
            this.authorId = default(int);
            this.yearPublished = 1900;
        }

        //Parameterized Constructor
        public Book(int productId, ProductType type,
            int categoryId, string productName, int supplierId, double unitPrice, int quantityOnHand,
            string isbn, int authorId, int yearPublished)
            : base(productId, type, categoryId, productName, supplierId, unitPrice, quantityOnHand)
        {
            this.isbn = isbn;
            this.authorId = authorId;
            this.yearPublished = yearPublished;
        }
        
        public override string ToString()
        {
            return
                this.ProductId.ToString() + "|" +
                this.Type.ToString() + "|" +
                this.CategoryId.ToString() + "|" +
                this.ProductName + "|" +
                this.SupplierId.ToString() + "|" +
                this.UnitPrice.ToString() + "|" +
                this.QuantityOnHand.ToString() + "|" +
                this.isbn + "|" + 
                this.authorId.ToString() + "|" + 
                this.yearPublished.ToString();
        }
    }
}
