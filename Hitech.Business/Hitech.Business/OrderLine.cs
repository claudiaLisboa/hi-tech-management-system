namespace Hitech.Business
{
    public class OrderLine
    {
        private int orderLineId;
        private int orderId; // Order to which this line belongs.
        private int productId;
        private ProductType productType;
        private double price;
        private int quantity;

        public int OrderLineId
        {
            get { return this.orderLineId; }
            set { this.orderLineId = value; }
        }

        public int OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; }
        }

        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public ProductType ProductType
        {
            get { return this.productType; }
            set { this.productType = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        //Default Constructor
        public OrderLine()
        {
            this.orderId = default(int);
            this.orderLineId = default(int);
            this.productId = default(int);
            this.productType = ProductType.Book;
            this.price = default(double);
            this.quantity = default(int);
        }

        //Parameterized Constructor 
        public OrderLine(int orderId, int orderLineId, int productId, ProductType productType, double price, int quantity)
        {
            this.orderId = orderId;
            this.orderLineId = orderLineId;
            this.productId = productId;
            this.productType = productType;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            return
                this.orderId + "|" +
                this.orderLineId + "|" +
                this.productId + "|" +
                this.productType + "|" +
                this.price + "|" +
                this.quantity;
        }
    }
}
