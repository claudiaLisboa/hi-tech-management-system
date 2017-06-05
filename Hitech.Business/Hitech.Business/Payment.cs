using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitech.Business
{
    public class Payment
    {
        private int paymentId;
        private DateTime paymentDate;
        private int orderId;

        public int PaymentId
        {
            get { return this.paymentId; }

            set { this.paymentId = value; }
        }

        public DateTime PaymentDate
        {
            get { return this.paymentDate; }

            set { this.paymentDate = value; }
        }

        public int OrderId
        {
            get { return this.orderId; }

            set { this.orderId = value; }
        }

        //Constructor by default
        public Payment()
        {
            this.paymentId = 0;
            this.paymentDate = DateTime.Now;
            this.orderId = 0;

        }

        public override string ToString()
        {
            return 
                this.paymentId + "|" +
                this.paymentDate.ToString("yyyymmdd") + "|" +
                this.orderId;
         }
    }
}
