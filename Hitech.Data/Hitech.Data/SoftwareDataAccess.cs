using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class SoftwareDataAccess
    {
        private static string FileName = "Softwares.xml";

        public static GenericList<int, Software> ReadXML()
        {
            List<Software> listTmp = new List<Software>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Software>));
                    listTmp = (List<Software>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the sofware ID.
            GenericList<int, Software> listResult = new GenericList<int, Software>();
            foreach (Software software in listTmp)
            {
                listResult.Add(software.ProductId, software);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Software> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Software> listTmp = new List<Software>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Software software = list[i];
                listTmp.Add(software);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Software>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
