using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class AuthorDataAccess
    {
        private static string FileName = "Authors.xml";

        public static GenericList<int, Author> ReadXML()
        {
            List<Author> listTmp = new List<Author>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Author>));
                    listTmp = (List<Author>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the author ID.
            GenericList<int, Author> listResult = new GenericList<int, Author>();
            foreach (Author author in listTmp)
            {
                listResult.Add(author.AuthorId, author);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Author> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Author> listTmp = new List<Author>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Author author = list[i];
                listTmp.Add(author);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Author>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
