namespace Hitech.Business
{
    public class PermissionsCollection
    {
        private static GenericList<string, Permission> PermissionList = new GenericList<string, Permission>();

        public static void LoadCollection(GenericList<string, Permission> list)
        {
            PermissionList = list;
        }

        public static GenericList<string, Permission> GetCollection()
        {
            return PermissionList;
        }

        public static bool AddPermission(Permission permission)
        {
            return PermissionList.Add(permission.Username, permission);
        }

        public static void RemovePermission(Permission permission)
        {
            PermissionList.Remove(permission.Username);
        }

        public static Permission GetPermission(string username)
        {
            if (PermissionList.Contains(username))
            {
                return PermissionList.GetByKey(username);
            }
            else
            {
                return default(Permission);
            }
        }

        public static Permission GetPermissionByUsername(string username)
        {
            for (int i = 0; i < PermissionList.GetCount(); i++)
            {
                Permission permission = PermissionList[i];
                if (permission.Username == username)
                {
                    return permission;
                }
            }

            return default(Permission);
        }
    }
}
