namespace Hitech.Business
{
    public enum ProductType
    {
        Book = 0,
        Software = 1
    }

    public class Product
    {
        private int productId;
        private ProductType type;
        private int categoryId;
        private string productName;
        private int supplierId;
        private double unitPrice;
        private int quantityOnHand;

        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public ProductType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int CategoryId
        {
            get { return this.categoryId; }
            set { this.categoryId = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int SupplierId
        {
            get { return this.supplierId; }
            set { this.supplierId = value; }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int QuantityOnHand
        {
            get { return this.quantityOnHand; }
            set { this.quantityOnHand = value; }
        }

        //Default Constructor
        public Product()
        {
            this.productId = default(int);
            this.type = default(ProductType);
            this.categoryId = default(int);
            this.productName = string.Empty;
            this.supplierId = default(int);
            this.unitPrice = default(double);
            this.quantityOnHand = default(int);
        }

        //Parameterized constructor
        public Product(int productId, ProductType type, int categoryId,
            string productName, int supplierId, double unitPrice, int quantityOnHand)
        {
            this.productId = productId;
            this.type = type;
            this.categoryId = categoryId;
            this.productName = productName;
            this.supplierId = supplierId;
            this.unitPrice = unitPrice;
            this.quantityOnHand = quantityOnHand;
        }

        public override string ToString()
        {
            return 
                this.productId.ToString() + "|" + 
                this.type.ToString() + "|" +
                this.categoryId.ToString() + "|" +
                this.productName + "|" +
                this.supplierId.ToString() + "|" +
                this.unitPrice.ToString() + "|" +
                this.quantityOnHand.ToString();
        }
    }
}
