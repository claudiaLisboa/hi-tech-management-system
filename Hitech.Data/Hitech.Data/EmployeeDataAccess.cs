using Hitech.Business;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Hitech.Data
{
    public class EmployeeDataAccess
    {
        private static string FileName = "Employees.xml";

        public static GenericList<int, Employee> ReadXML()
        {
            List<Employee> listTmp = new List<Employee>();

            string file = Generic.FilePath + "/" + FileName;

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                    listTmp = (List<Employee>)serializer.Deserialize(reader);
                }
            }

            // Loading the data into a GenericList indexed by the employee ID.
            GenericList<int, Employee> listResult = new GenericList<int, Employee>();
            foreach (Employee employee in listTmp)
            {
                listResult.Add(employee.EmployeeId, employee);
            }

            return listResult;
        }

        public static void WriteXML(GenericList<int, Employee> list)
        {
            Generic.CheckDirectory(Generic.FilePath);
            string file = Generic.FilePath + "/" + FileName;

            // Creating temporary list.
            List<Employee> listTmp = new List<Employee>();
            for (int i = 0; i < list.GetCount(); i++)
            {
                Employee employee = list[i];
                listTmp.Add(employee);
            }

            // Serializing temporary list.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(file, settings))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                serializer.Serialize(writer, listTmp);
            }
        }
    }
}
