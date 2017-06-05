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
    public class PaymentDataAccess
    {
        public static string FileName = "../../DATA/Payments.xml";

        public static GenericList<long, Payment> ReadXML(string file)
        {

            List<Payment> listTmp = null;

            using (StreamReader reader = new StreamReader(file))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Payment>));
                listTmp = (List<Payment>)serializer.Deserialize(reader);
            }
            //----- Create GenericList
            GenericList<long, Payment> listResult = new GenericList<long, Payment>();
            foreach (Payment payment in listTmp)
            {
                listResult.Add(payment.PaymentId, payment);
            }

            return listResult;
        }
        public static void WriteXML(string file, GenericList<long, Payment> list)
        {
            //---Create Temporary List<Payment>
            List<Payment> listTmp = new List<Payment>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Payment payment = list[i];
                listTmp.Add(payment);
            }
            //---Serialize Temporary List<Payment>
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Payment>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
