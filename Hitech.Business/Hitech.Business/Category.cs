namespace Hitech.Business
{
    public class Category
    {
        private int categoryId;
        private string description;

        public int CategoryId
        {
            get { return this.categoryId; }
            set { this.categoryId = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        //Default Constructor
        public Category()
        {
           this.categoryId = default(int);
           this.description = string.Empty;
        }

        //Parameterized Constructor
        public Category(int categoryId, string description)
        {
            this.categoryId = categoryId;
            this.description = description;
        }

        public override string ToString()
        {
            return this.categoryId.ToString() + "|" + this.description;
        }
    }
}
