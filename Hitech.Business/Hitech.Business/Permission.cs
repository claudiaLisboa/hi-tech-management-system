namespace Hitech.Business
{
    public class Permission
    {
        private string username;
        private bool employeeSaveUpdateDelete;
        private bool employeeSearchList;
        private bool userSaveUpdateDelete;
        private bool userSearchList;
        private bool clientSaveUpdateDelete;
        private bool clientSearchList;
        private bool productSaveUpdateDelete;
        private bool productSearchList;
        private bool clientOrderSaveUpdateCancel;
        private bool clientOrderSearchList;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public bool EmployeeSaveUpdateDelete
        {
            get { return this.employeeSaveUpdateDelete; }
            set { this.employeeSaveUpdateDelete = value; }
        }

        public bool EmployeeSearchList
        {
            get { return this.employeeSearchList; }
            set { this.employeeSearchList = value; }
        }

        public bool UserSaveUpdateDelete
        {
            get { return this.userSaveUpdateDelete; }
            set { this.userSaveUpdateDelete = value; }
        }

        public bool UserSearchList
        {
            get { return this.userSearchList; }
            set { this.userSearchList = value; }
        }

        public bool ClientSaveUpdateDelete
        {
            get { return this.clientSaveUpdateDelete; }
            set { this.clientSaveUpdateDelete = value; }
        }

        public bool ClientSearchList
        {
            get { return this.clientSearchList; }
            set { this.clientSearchList = value; }
        }

        public bool ProductSaveUpdateDelete
        {
            get { return this.productSaveUpdateDelete; }
            set { this.productSaveUpdateDelete = value; }
        }

        public bool ProductSearchList
        {
            get { return this.productSearchList; }
            set { this.productSearchList = value; }
        }

        public bool ClientOrderSaveUpdateCancel
        {
            get { return this.clientOrderSaveUpdateCancel; }
            set { this.clientOrderSaveUpdateCancel = value; }
        }

        public bool ClientOrderSearchList
        {
            get { return this.clientOrderSearchList; }
            set { this.clientOrderSearchList = value; }
        }

        //Default Constructor
        public Permission()
        {
            this.username = "";
            this.employeeSaveUpdateDelete = false;
            this.employeeSearchList = false;
            this.userSaveUpdateDelete = false;
            this.userSearchList = false;
            this.clientSaveUpdateDelete = false;
            this.clientSearchList = false;
            this.productSaveUpdateDelete = false;
            this.productSearchList = false;
            this.clientOrderSaveUpdateCancel = false;
            this.clientOrderSearchList = false;
        }

        //Parameterized Constructor
        public Permission(string username,
            bool employeeSaveUpdateDelete, bool employeeSearchList,
            bool userSaveUpdateDelete, bool userSearchList,
            bool clientSaveUpdateDelete, bool clientSearchList,
            bool productSaveUpdateDelete, bool productSearchList,
            bool clientOrderSaveUpdateCancel, bool clientOrderSearchList)
        {
            this.username = username;
            this.employeeSaveUpdateDelete = employeeSaveUpdateDelete;
            this.employeeSearchList = employeeSearchList;
            this.userSaveUpdateDelete = userSaveUpdateDelete;
            this.userSearchList = userSearchList;
            this.clientSaveUpdateDelete = clientSaveUpdateDelete;
            this.clientSearchList = clientSearchList;
            this.productSaveUpdateDelete = productSaveUpdateDelete;
            this.productSearchList = productSearchList;
            this.clientOrderSaveUpdateCancel = clientOrderSaveUpdateCancel;
            this.clientOrderSearchList = clientOrderSearchList;
        }

        public override string ToString()
        {
            return 
                this.username + "|" + 
                this.employeeSaveUpdateDelete.ToString() + "|" + 
                this.employeeSearchList.ToString() + "|" +
                this.userSaveUpdateDelete.ToString() + "|" +
                this.userSearchList.ToString() + "|" +
                this.clientSaveUpdateDelete.ToString() + "|" +
                this.clientSearchList.ToString() + "|" +
                this.productSaveUpdateDelete.ToString() + "|" +
                this.productSearchList.ToString() + "|" +
                this.clientOrderSaveUpdateCancel.ToString() + "|" +
                this.clientOrderSearchList.ToString();
        }
    }
}
