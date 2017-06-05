namespace Hitech.Business
{
    public class Client
    {
        private int clientId;
        private string name;
        private string address;
        private string city;
        private string postalCode;
        private string phoneNumber;
        private string faxNumber;
        private double creditLimit;
        private string bankNumber;
        private string branchNumber;
        private string bankAccount;

        public int ClientId
        {
            get { return this.clientId; }
            set { this.clientId = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string FaxNumber
        {
            get { return this.faxNumber; }
            set { this.faxNumber = value; }
        }

        public double CreditLimit
        {
            get { return this.creditLimit; }
            set { this.creditLimit = value; }
        }

        public string BankNumber
        {
            get { return this.bankNumber; }
            set { this.bankNumber = value; }
        }

        public string BranchNumber
        {
            get { return this.branchNumber; }
            set { this.branchNumber = value; }
        }

        public string BankAccount
        {
            get { return this.bankAccount; }
            set { this.bankAccount = value; }
        }

        //Default Constructor
        public Client()
        {
            this.clientId = default(int);
            this.name = string.Empty;
            this.address = string.Empty;
            this.city = string.Empty;
            this.postalCode = string.Empty;
            this.phoneNumber = string.Empty;
            this.faxNumber = string.Empty;
            this.creditLimit = 0.0;
            this.bankNumber = string.Empty;
            this.branchNumber = string.Empty;
            this.bankAccount = string.Empty;
        }

        //Parameterized Constructor
        public Client(int clientId, string name, string address, string city, 
                      string postalCode, string phoneNumber, string faxNumber, 
                      double creditLimit, string bankNumber, string branchNumber, string bankAccount)
        {
            this.clientId = clientId;
            this.name = name;
            this.address = address;
            this.city = city;
            this.postalCode = postalCode;
            this.phoneNumber = phoneNumber;
            this.faxNumber = faxNumber;
            this.creditLimit = creditLimit;
            this.bankNumber = bankNumber;
            this.branchNumber = branchNumber;
            this.bankAccount = bankAccount;
        }

        public override string ToString()
        {
            return 
                this.clientId.ToString() + "|" + 
                this.name + "|" + 
                this.address + "|" + 
                this.city + "|" + 
                this.postalCode + "|" + 
                this.phoneNumber + "|" + 
                this.faxNumber + "|" + 
                this.creditLimit.ToString() + "|" + 
                this.bankNumber + "|" +
                this.branchNumber + "|" +
                this.bankAccount;
        }
    }
}
