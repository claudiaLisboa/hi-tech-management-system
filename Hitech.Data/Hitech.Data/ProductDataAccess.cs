using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class ProductDataAccess
    {
        private static string FileName = "Products.xml";

        public static GenericList<int, Product> ReadXML()
        {
            List<Product> listTmp = new List<Product>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                    listTmp = (List<Product>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the product ID.
            GenericList<int, Product> listResult = new GenericList<int, Product>();
            foreach (Product product in listTmp)
            {
                listResult.Add(product.ProductId, product);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Product> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Product> listTmp = new List<Product>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Product product = list[i];
                listTmp.Add(product);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
