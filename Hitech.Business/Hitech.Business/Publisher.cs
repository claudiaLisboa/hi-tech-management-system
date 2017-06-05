namespace Hitech.Business
{
    public class Publisher
    {
        private int publisherId;
        private string companyName;
        private string address;
        private string city;
        private string phone;

        public int PublisherId
        {
            get { return publisherId; }
            set { publisherId = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        //Default Constructor
        public Publisher()
        {
            this.publisherId = default(int);
            this.companyName = string.Empty;
            this.address = string.Empty;
            this.city = string.Empty;
            this.phone = string.Empty;
        }

        //Paremeterized Constructor
        public Publisher(int publisherId, string companyName, string address, string city, string phone)
        {
            this.publisherId = publisherId;
            this.companyName = companyName;
            this.address = address;
            this.city = city;
            this.phone = phone;
        }

        public override string ToString()
        {
            return 
                this.publisherId.ToString() + "|" + 
                this.companyName + "|" + 
                this.address + "|" +
                this.city + "|" +
                this.phone;
        }
    }
}
