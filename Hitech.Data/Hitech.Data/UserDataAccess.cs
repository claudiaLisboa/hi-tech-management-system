using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class UserDataAccess
    {
        private static string FileName = "Users.xml";

        public static GenericList<string, User> ReadXML()
        {
            List<User> listTmp = new List<User>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    listTmp = (List<User>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the username.
            GenericList<string, User> listResult = new GenericList<string, User>();
            foreach (User user in listTmp)
            {
                listResult.Add(user.Username, user);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<string, User> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<User> listTmp = new List<User>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                User user = list[i];
                listTmp.Add(user);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
