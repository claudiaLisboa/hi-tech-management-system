namespace Hitech.Business
{
    public class SoftwaresCollection
    {
        private static GenericList<int, Software> SoftwareList = new GenericList<int, Software>();

        public static void LoadCollection(GenericList<int, Software> list)
        {
            SoftwareList = list;
        }

        public static GenericList<int, Software> GetCollection()
        {
            return SoftwareList;
        }

        public static bool AddSoftware(Software software)
        {
            return SoftwareList.Add(software.ProductId, software);
        }

        public static void RemoveSoftware(Software software)
        {
            SoftwareList.Remove(software.ProductId);
        }

        public static Software GetSoftware(int softwareId)
        {
            if (SoftwareList.Contains(softwareId))
            {
                return SoftwareList.GetByKey(softwareId);
            }
            else
            {
                return default(Software);
            }
        }

        public static int NextSoftwareId()
        {
            int nextSoftwareId = default(int);

            for (int i = 0; i < SoftwareList.GetCount(); i++)
            {
                Software software = SoftwareList[i];

                if (software.ProductId > nextSoftwareId)
                {
                    nextSoftwareId = software.ProductId;
                }
            }

            return (nextSoftwareId + 1);
        }

        public static Software GetSoftwareByCategory(int categoryId)
        {
            for (int i = 0; i < SoftwareList.GetCount(); i++)
            {
                Software software = SoftwareList[i];
                if (software.CategoryId == categoryId)
                {
                    return software;
                }
            }

            return default(Software);
        }

        public static Software GetSoftwareBySupplier(int supplierId)
        {
            for (int i = 0; i < SoftwareList.GetCount(); i++)
            {
                Software software = SoftwareList[i];
                if (software.SupplierId == supplierId)
                {
                    return software;
                }
            }

            return default(Software);
        }
    }
}
