using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class SupplierDataAccess
    {
        private static string FileName = "Suppliers.xml";

        public static GenericList<int, Supplier> ReadXML()
        {
            List<Supplier> listTmp = new List<Supplier>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Supplier>));
                    listTmp = (List<Supplier>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the supplier ID.
            GenericList<int, Supplier> listResult = new GenericList<int, Supplier>();
            foreach (Supplier supplier in listTmp)
            {
                listResult.Add(supplier.SupplierId, supplier);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Supplier> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Supplier> listTmp = new List<Supplier>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Supplier supplier = list[i];
                listTmp.Add(supplier);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Supplier>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
