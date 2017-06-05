using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class OrderDataAccess
    {
        private static string FileName = "Orders.xml";

        public static GenericList<int, Order> ReadXML()
        {
            List<Order> listTmp = new List<Order>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
                    listTmp = (List<Order>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the order ID.
            GenericList<int, Order> listResult = new GenericList<int, Order>();
            foreach (Order order in listTmp)
            {
                listResult.Add(order.OrderId, order);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Order> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Order> listTmp = new List<Order>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Order order = list[i];
                listTmp.Add(order);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
