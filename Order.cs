using System;
using System.Collections.Generic;

namespace ACM
{
    public class Order
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrdemItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrdemItems { get; set; }
        public int ShippingAddressId { get; set; }


        ///<summary>
        /// Validates ther order data.
        /// </summary>
        /// <returns></returns>
        /// 
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
