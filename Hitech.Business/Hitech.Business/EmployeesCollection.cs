namespace Hitech.Business
{
    public class EmployeesCollection
    {
        private static GenericList<int, Employee> EmployeeList = new GenericList<int, Employee>();

        public static void LoadCollection(GenericList<int, Employee> list)
        {
            EmployeeList = list;
        }

        public static GenericList<int, Employee> GetCollection()
        {
            return EmployeeList;
        }

        public static GenericList<int, Employee> GetEmployeesWithNoUserAssigned()
        {
            GenericList<int, Employee> listResult = new GenericList<int, Employee>();

            for (int i = 0; i < EmployeeList.GetCount(); i++)
            {
                Employee employee = EmployeeList[i];
                if (UsersCollection.GetUserByEmployee(employee.EmployeeId) == null)
                {
                    listResult.Add(employee.EmployeeId, employee);
                }
            }
            return listResult;
        }

        public static bool AddEmployee(Employee employee)
        {
            return EmployeeList.Add(employee.EmployeeId, employee);
        }

        public static void RemoveEmployee(Employee employee)
        {
            EmployeeList.Remove(employee.EmployeeId);
        }

        public static Employee GetEmployee(int employeeId)
        {
            if (EmployeeList.Contains(employeeId))
            {
                return EmployeeList.GetByKey(employeeId);
            }
            else
            {
                return default(Employee);
            }
        }

        public static int NextEmployeeId()
        {
            int nextEmployeeId = default(int);

            for (int i = 0; i < EmployeeList.GetCount(); i++)
            {
                Employee employee = EmployeeList[i];

                if (employee.EmployeeId > nextEmployeeId)
                {
                    nextEmployeeId = employee.EmployeeId;
                }
            }

            return (nextEmployeeId + 1);
        }
    }
}
