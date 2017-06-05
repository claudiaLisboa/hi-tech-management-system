namespace Hitech.Business
{
    public class ClientsCollection
    {
        private static GenericList<int, Client> ClientList = new GenericList<int, Client>();

        public static void LoadCollection(GenericList<int, Client> list)
        {
            ClientList = list;
        }

        public static GenericList<int, Client> GetCollection()
        {
            return ClientList;
        }

        public static bool AddClient(Client client)
        {
            return ClientList.Add(client.ClientId, client);
        }

        public static void RemoveClient(Client client)
        {
            ClientList.Remove(client.ClientId);
        }

        public static Client GetClient(int clientId)
        {
            if (ClientList.Contains(clientId))
            {
                return ClientList.GetByKey(clientId);
            }
            else
            {
                return default(Client);
            }
        }

        public static int NextClientId()
        {
            int nextClientId = default(int);

            for (int i = 0; i < ClientList.GetCount(); i++)
            {
                Client client = ClientList[i];

                if (client.ClientId > nextClientId)
                {
                    nextClientId = client.ClientId;
                }
            }

            return (nextClientId + 1);
        }
    }
}
