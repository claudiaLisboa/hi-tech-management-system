namespace Hitech.Business
{
    public class OrdersCollection
    {
        private static GenericList<int, Order> OrderList = new GenericList<int, Order>();

        public static void LoadCollection(GenericList<int, Order> list)
        {
            OrderList = list;
        }

        public static GenericList<int, Order> GetCollection()
        {
            return OrderList;
        }

        public static bool AddOrder(Order order)
        {
            return OrderList.Add(order.OrderId, order);
        }

        public static void RemoveOrder(Order order)
        {
            OrderList.Remove(order.OrderId);
        }

        public static Order GetOrder(int orderId)
        {
            if (OrderList.Contains(orderId))
            {
                return OrderList.GetByKey(orderId);
            }
            else
            {
                return default(Order);
            }
        }

        public static int NextOrderId()
        {
            int nextOrderId = default(int);

            for (int i = 0; i < OrderList.GetCount(); i++)
            {
                Order order = OrderList[i];

                if (order.OrderId > nextOrderId)
                {
                    nextOrderId = order.OrderId;
                }
            }

            return (nextOrderId + 1);
        }

        public static Order GetOrderByClient(int clientId)
        {
            for (int i = 0; i < OrderList.GetCount(); i++)
            {
                Order order = OrderList[i];
                if (order.ClientId == clientId)
                {
                    return order;
                }
            }

            return default(Order);
        }
    }
}
