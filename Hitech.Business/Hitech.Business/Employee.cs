namespace Hitech.Business
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;

        public int EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FullName
        {
            get { return $"{this.firstName} {this.lastName}"; }
        }

        public string JobTitle
        {
            get { return this.jobTitle; }
            set { this.jobTitle = value; }
        }

        //Default Constructor
        public Employee()
        {
            this.employeeId = default(int);
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.jobTitle = string.Empty;
        }

        //Parameterized Constructor
        public Employee(int employeeId, string firstName, string lastName, string jobTitle)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobTitle = jobTitle;
        }

        public override string ToString()
        {
            return 
                this.employeeId.ToString() + "|" + 
                this.firstName + "|" + 
                this.lastName + "|" + 
                this.jobTitle ;
        }
    }
}
