namespace Hitech.Business
{
    public class Software : Product
    {
        //Default Constructor
        public Software(): base ()
        {
        }

        //Parameterized Constructor
        public Software(int productId, ProductType type,
            int categoryId, string productName, int supplierId,
            double unitPrice, int quantityOnHand)
            : base(productId, type, categoryId, productName, supplierId, unitPrice, quantityOnHand)
        {
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
                this.QuantityOnHand.ToString();
        }
    }
}
