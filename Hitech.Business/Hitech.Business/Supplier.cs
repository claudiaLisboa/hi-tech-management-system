namespace Hitech.Business
{
    public class Supplier
    {
        private int supplierId;
        private string name;
        private string address;
        private string city;
        private string postalCode;
        private string phoneNumber;

        public int SupplierId
        {
            get { return this.supplierId; }
            set { this.supplierId = value; }
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

        //Default Constructor
        public Supplier()
        {
            this.supplierId = default(int);
            this.name = string.Empty;
            this.address = string.Empty;
            this.city = string.Empty;
            this.postalCode = string.Empty;
            this.phoneNumber = string.Empty;
        }

        //Parameterized Constructor
        public Supplier(int supplierId, string name, string address, string city, string postalCode, string phoneNumber)
        {
            this.supplierId = supplierId;
            this.name = name;
            this.address = address;
            this.city = city;
            this.postalCode = postalCode;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return 
                this.supplierId.ToString() + "|" +
                this.name + "|" +
                this.address + "|" +
                this.city + "|" +
                this.postalCode + "|" +
                this.phoneNumber;
        }
    }
}
