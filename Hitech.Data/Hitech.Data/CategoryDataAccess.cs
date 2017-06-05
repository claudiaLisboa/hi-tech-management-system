using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class CategoryDataAccess
    {
        private static string FileName = "Categories.xml";

        public static GenericList<int, Category> ReadXML()
        {
            List<Category> listTmp = new List<Category>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Category>));
                    listTmp = (List<Category>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the category ID.
            GenericList<int, Category> listResult = new GenericList<int, Category>();
            foreach (Category category in listTmp)
            {
                listResult.Add(category.CategoryId, category);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Category> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Category> listTmp = new List<Category>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Category category = list[i];
                listTmp.Add(category);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Category>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
