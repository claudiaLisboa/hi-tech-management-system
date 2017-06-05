using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class ClientDataAccess
    {
        private static string FileName = "Clients.xml";

        public static GenericList<int, Client> ReadXML()
        {
            List<Client> listTmp = new List<Client>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                    listTmp = (List<Client>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the client ID.
            GenericList<int, Client> listResult = new GenericList<int, Client>();
            foreach (Client client in listTmp)
            {
                listResult.Add(client.ClientId, client);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Client> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Client> listTmp = new List<Client>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Client client = list[i];
                listTmp.Add(client);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
