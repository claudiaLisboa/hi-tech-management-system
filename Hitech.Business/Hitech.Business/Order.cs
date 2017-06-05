using System;

namespace Hitech.Business
{
    public enum OrderTakenBy
    {
        Email = 0,
        Phone = 1,
        Fax = 2
    }

    public class Order
    {
        private int orderId;
        private DateTime orderDate;
        private int clientId;
        private OrderTakenBy orderTakenBy;
        private string comments;
        private GenericList<int, OrderLine> orderLines;

        public int OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; }
        }

        public DateTime OrderDate
        {
            get { return this.orderDate; }
            set { this.orderDate = value; }
        }

        public int ClientId
        {
            get { return this.clientId; }
            set { this.clientId = value; }
        }

        public OrderTakenBy OrderTakenBy
        {
            get { return this.orderTakenBy; }
            set { this.orderTakenBy = value; }
        }

        public string Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public GenericList<int, OrderLine> OrderLines
        {
            get { return this.orderLines; }
            set { this.orderLines = value; }
        }

        //Default Constructor
        public Order()
        {
            this.orderId = default(int);
            this.orderDate = DateTime.Now;
            this.clientId = default(int);
            this.orderTakenBy = default(OrderTakenBy);
            this.comments = string.Empty;
            this.orderLines = new GenericList<int, OrderLine>();
        }

        //Parameterized Constructor
        public Order(int orderId, DateTime orderDate, int clientId,
            OrderTakenBy orderTakenBy, string comments, GenericList<int, OrderLine> orderLines)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.clientId = clientId;
            this.orderTakenBy = orderTakenBy;
            this.comments = comments;
            this.orderLines = orderLines;
        }

        public bool AddLine(OrderLine orderLine)
        {
            return this.orderLines.Add(orderLine.OrderLineId, orderLine);
        }

        public int NextLineId()
        {
            int nextLineId = default(int);

            for (int i = 0; i < this.orderLines.GetCount(); i++)
            {
                OrderLine orderLine = this.orderLines[i];

                if (orderLine.OrderLineId > nextLineId)
                {
                    nextLineId = orderLine.OrderLineId;
                }
            }

            return (nextLineId + 1);
        }

        public void RemoveLine(OrderLine orderLine)
        {
            this.orderLines.Remove(orderLine.OrderLineId);
        }

        public override string ToString()
        {
            return 
                this.orderId + "|" + 
                this.orderDate.ToString("yyyymmdd") + "|" +
                this.clientId + "|" +
                this.orderTakenBy.ToString() + "|" +
                this.comments + "|" +
                this.orderLines.ToString();
        }
    }
}
