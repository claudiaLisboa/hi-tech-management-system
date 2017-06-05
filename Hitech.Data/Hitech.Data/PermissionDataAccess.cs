using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class PermissionDataAccess
    {
        private static string FileName = "Permissions.xml";

        public static GenericList<string, Permission> ReadXML()
        {
            List<Permission> listTmp = new List<Permission>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Permission>));
                    listTmp = (List<Permission>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the username.
            GenericList<string, Permission> listResult = new GenericList<string, Permission>();
            foreach (Permission permission in listTmp)
            {
                listResult.Add(permission.Username, permission);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<string, Permission> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Permission> listTmp = new List<Permission>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Permission permission = list[i];
                listTmp.Add(permission);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Permission>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
