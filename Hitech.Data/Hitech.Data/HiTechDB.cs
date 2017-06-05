using Hitech.Business;

namespace Hitech.Data
{
    public class HiTechDB
    {
        private static GenericList<string, User> ListUsers = new GenericList<string, User>();
        private static GenericList<string, Permission> ListPermissions = new GenericList<string, Permission>();
        private static GenericList<int, Employee> ListEmployees  = new GenericList<int, Employee>();
        private static GenericList<int, Client> ListClients = new GenericList<int, Client>();
        private static GenericList<int, Product> ListProducts = new GenericList<int, Product>();
        private static GenericList<int, Author> ListAuthors = new GenericList<int, Author>();
        private static GenericList<int, Category> ListCategories = new GenericList<int, Category>();
        private static GenericList<int, Supplier> ListSuppliers = new GenericList<int, Supplier>();
        private static GenericList<int, Book> ListBooks = new GenericList<int, Book>();
        private static GenericList<int, Software> ListSoftwares = new GenericList<int, Software>();
        private static GenericList<int, Order> ListOrders = new GenericList<int, Order>();

        public static void LoadData()
        {
            // Loading data from the XML files.
            ListUsers = UserDataAccess.ReadXML();
            ListPermissions = PermissionDataAccess.ReadXML();
            ListEmployees = EmployeeDataAccess.ReadXML();
            ListClients = ClientDataAccess.ReadXML();
            ListProducts = ProductDataAccess.ReadXML();
            ListAuthors = AuthorDataAccess.ReadXML();
            ListCategories = CategoryDataAccess.ReadXML();
            ListSuppliers = SupplierDataAccess.ReadXML();
            ListBooks = BookDataAccess.ReadXML();
            ListSoftwares = SoftwareDataAccess.ReadXML();
            ListOrders = OrderDataAccess.ReadXML();

            // Loading the data into the collection classes.
            UsersCollection.LoadCollection(ListUsers);
            PermissionsCollection.LoadCollection(ListPermissions);
            EmployeesCollection.LoadCollection(ListEmployees);
            ClientsCollection.LoadCollection(ListClients);
            ProductsCollection.LoadCollection(ListProducts);
            AuthorsCollection.LoadCollection(ListAuthors);
            CategoriesCollection.LoadCollection(ListCategories);
            SuppliersCollection.LoadCollection(ListSuppliers);
            BooksCollection.LoadCollection(ListBooks);
            SoftwaresCollection.LoadCollection(ListSoftwares);
            OrdersCollection.LoadCollection(ListOrders);
        }

        public static void SaveData()
        {
            UserDataAccess.WriteXML(ListUsers);
            PermissionDataAccess.WriteXML(ListPermissions);
            EmployeeDataAccess.WriteXML(ListEmployees);
            ClientDataAccess.WriteXML(ListClients);
            ProductDataAccess.WriteXML(ListProducts);
            AuthorDataAccess.WriteXML(ListAuthors);
            CategoryDataAccess.WriteXML(ListCategories);
            SupplierDataAccess.WriteXML(ListSuppliers);
            BookDataAccess.WriteXML(ListBooks);
            SoftwareDataAccess.WriteXML(ListSoftwares);
            OrderDataAccess.WriteXML(ListOrders);
        }
    }
}
