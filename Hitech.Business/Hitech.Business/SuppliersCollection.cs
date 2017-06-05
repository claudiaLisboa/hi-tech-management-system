namespace Hitech.Business
{
    public class SuppliersCollection
    {
        private static GenericList<int, Supplier> SupplierList = new GenericList<int, Supplier>();

        public static void LoadCollection(GenericList<int, Supplier> list)
        {
            SupplierList = list;
        }

        public static GenericList<int, Supplier> GetCollection()
        {
            return SupplierList;
        }

        public static bool AddSupplier(Supplier supplier)
        {
            return SupplierList.Add(supplier.SupplierId, supplier);
        }

        public static void RemoveSupplier(Supplier supplier)
        {
            SupplierList.Remove(supplier.SupplierId);
        }

        public static Supplier GetSupplier(int supplierId)
        {
            if (SupplierList.Contains(supplierId))
            {
                return SupplierList.GetByKey(supplierId);
            }
            else
            {
                return default(Supplier);
            }
        }

        public static int NextSupplierId()
        {
            int nextSupplierId = default(int);

            for (int i = 0; i < SupplierList.GetCount(); i++)
            {
                Supplier supplier = SupplierList[i];

                if (supplier.SupplierId > nextSupplierId)
                {
                    nextSupplierId = supplier.SupplierId;
                }
            }

            return (nextSupplierId + 1);
        }
    }
}
