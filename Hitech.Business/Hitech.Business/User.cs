namespace Hitech.Business
{
    public class User
    {
        private string username;
        private string password;
        private string status;
        private int employeeId;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }

        //Constructor by default
        public User()
        {
            this.username = string.Empty;
            this.password = string.Empty;
            this.status = string.Empty;
            this.employeeId = default(int);
        }

        //Constructor 
        public User(string username, string password, string status, int employeeId)
        {
            this.username = username;
            this.password = password;
            this.status = status;
            this.employeeId = employeeId;
        }

        public override string ToString()
        {
            return this.username + "|" + 
                   this.password + "|" + 
                   this.status + "|" + 
                   this.employeeId.ToString();
        }

        public bool CheckPassword(string password)
        {
            return (password == this.password);
        }
    }
}
