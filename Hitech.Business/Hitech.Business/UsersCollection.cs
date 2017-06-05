namespace Hitech.Business
{
    public class UsersCollection
    {
        private static GenericList<string, User> UserList = new GenericList<string, User>();

        public static void LoadCollection(GenericList<string, User> list)
        {
            UserList = list;
        }

        public static GenericList<string, User> GetCollection()
        {
            return UserList;
        }

        public static bool AddUser(User user)
        {
            return UserList.Add(user.Username, user);
        }

        public static void RemoveUser(User user)
        {
            UserList.Remove(user.Username);
        }

        public static User GetUser(string username)
        {
            if (UserList.Contains(username))
            {
                return UserList.GetByKey(username);
            }
            else
            {
                return default(User);
            }
        }

        public static User GetUserByEmployee(int employeeId)
        {
            for (int i = 0; i < UserList.GetCount(); i++)
            {
                User user = UserList[i];
                if (user.EmployeeId == employeeId)
                {
                    return user;
                }
            }

            return default(User);
        }
    }
}
