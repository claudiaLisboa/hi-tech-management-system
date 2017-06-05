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
    public class PublisherDataAccess
    {
        public static string FileName = "../../DATA/Publishers.xml";

        public static GenericList<long, Publisher> ReadXML(string file)
        {

            List<Publisher> listTmp = null;

            using (StreamReader reader = new StreamReader(file))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Publisher>));
                listTmp = (List<Publisher>)serializer.Deserialize(reader);
            }
            //----- Create GenericList
            GenericList<long, Publisher> listResult = new GenericList<long, Publisher>();
            foreach (Publisher publisher in listTmp)
            {
                listResult.Add(publisher.PublisherId, publisher);
            }

            return listResult;
        }
        public static void WriteXML(string file, GenericList<long, Publisher> list)
        {
            //---Create Temporary List<Publisher>
            List<Publisher> listTmp = new List<Publisher>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Publisher publisher = list[i];
                listTmp.Add(publisher);
            }
            //---Serialize Temporary List<Publisher>
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Publisher>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
