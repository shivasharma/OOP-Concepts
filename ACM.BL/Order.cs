using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Order:ILoggable

    {

        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int customderId { get; set; }
        public int ShippingAddress1 { get; set; }
        public DateTimeOffset? OrderDate { get; set; }



        public int OrderId { get; private set; }

        public List<OrderItem> orderItems { get; set; }
      
        public Order Retrive(int productId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate==null) isValid = false;
           return isValid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date + "(" + OrderId + ")";
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
