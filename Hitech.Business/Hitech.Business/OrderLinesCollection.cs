namespace Hitech.Business
{
    public class OrderLinesCollection
    {
        private static GenericList<string, OrderLine> OrderLineList = new GenericList<string, OrderLine>();

        public static void LoadCollection(GenericList<string, OrderLine> list)
        {
            OrderLineList = list;
        }

        public static GenericList<string, OrderLine> GetCollection()
        {
            return OrderLineList;
        }

        private static string BuildCollectionKey(int orderId, int orderLineId)
        {
            return $"{orderId}|{orderLineId}";
        }

        public static bool AddOrderLine(OrderLine orderLine)
        {
            return OrderLineList.Add(BuildCollectionKey(orderLine.OrderId, orderLine.OrderLineId), orderLine);
        }

        public static void RemoveOrderLine(OrderLine orderLine)
        {
            OrderLineList.Remove(BuildCollectionKey(orderLine.OrderId, orderLine.OrderLineId));
        }

        public static OrderLine GetOrderLine(int orderId, int orderLineId)
        {
            string collectionKey = BuildCollectionKey(orderId, orderLineId);

            if (OrderLineList.Contains(collectionKey))
            {
                return OrderLineList.GetByKey(collectionKey);
            }
            else
            {
                return default(OrderLine);
            }
        }

        public static int NextOrderLineId()
        {
            int nextOrderLineId = default(int);

            for (int i = 0; i < OrderLineList.GetCount(); i++)
            {
                OrderLine orderLine = OrderLineList[i];

                if (orderLine.ProductId > nextOrderLineId)
                {
                    nextOrderLineId = orderLine.ProductId;
                }
            }

            return (nextOrderLineId + 1);
        }
    }
}
