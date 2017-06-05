namespace Hitech.Business
{
    public class ProductsCollection
    {
        private static GenericList<int, Product> ProductList = new GenericList<int, Product>();

        public static void LoadCollection(GenericList<int, Product> list)
        {
            ProductList = list;
        }

        public static GenericList<int, Product> GetCollection()
        {
            return ProductList;
        }

        public static bool AddProduct(Product product)
        {
            return ProductList.Add(product.ProductId, product);
        }

        public static void RemoveProduct(Product product)
        {
            ProductList.Remove(product.ProductId);
        }

        public static Product GetProduct(int productId)
        {
            if (ProductList.Contains(productId))
            {
                return ProductList.GetByKey(productId);
            }
            else
            {
                return default(Product);
            }
        }

        public static int NextProductId()
        {
            int nextProductId = default(int);

            for (int i = 0; i < ProductList.GetCount(); i++)
            {
                Product product = ProductList[i];

                if (product.ProductId > nextProductId)
                {
                    nextProductId = product.ProductId;
                }
            }

            return (nextProductId + 1);
        }
    }
}
