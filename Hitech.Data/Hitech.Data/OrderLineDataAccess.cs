using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Hitech.Business;

namespace Hitech.Data
{
    public class OrderLineDataAccess
    {
        private static string FileName = "OrderLines.xml";

        public static GenericList<string, OrderLine> ReadXML()
        {
            List<OrderLine> listTmp = new List<OrderLine>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<OrderLine>));
                    listTmp = (List<OrderLine>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the order line ID.
            GenericList<string, OrderLine> listResult = new GenericList<string, OrderLine>();
            foreach (OrderLine orderLine in listTmp)
            {
                listResult.Add(orderLine.OrderId + "|" + orderLine.OrderLineId, orderLine);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<string, OrderLine> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<OrderLine> listTmp = new List<OrderLine>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                OrderLine orderLine = list[i];
                listTmp.Add(orderLine);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<OrderLine>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
