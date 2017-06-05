namespace Hitech.Business
{
    public class Author
    {
        private int authorId;
        private string firstName;
        private string lastName;

        public int AuthorId
        {
            get { return this.authorId; }
            set { this.authorId = value; }
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

        //Default Constructor
        public Author()
        {
            this.authorId = default(int);
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }

        //Parameterized Constructor
        public Author(int authorId, string firstName, string lastName)
        {
            this.authorId = authorId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return this.authorId.ToString() + "|" + this.firstName + "|" + this.lastName;
        }
    }
}
