using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public  class BookDataAccess
    {
        private static string FileName = "Books.xml";

        public static GenericList<int, Book> ReadXML()
        {
            List<Book> listTmp = new List<Book>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                    listTmp = (List<Book>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the book ID.
            GenericList<int, Book> listResult = new GenericList<int, Book>();
            foreach (Book book in listTmp)
            {
                listResult.Add(book.ProductId, book);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Book> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Book> listTmp = new List<Book>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Book book = list[i];
                listTmp.Add(book);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
