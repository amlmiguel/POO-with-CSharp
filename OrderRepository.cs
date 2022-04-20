using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class OrderRepository
    {
        

            ///<summary>
            /// Retrieve one product
            /// </summary>
            /// 

            public Order Retrieve(int orderId)
            {
                // Create the instance of the Order class
                // Pass in the requested id

                Order order = new Order(orderId);

                if (orderId == 1)
                {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                }
                return order;
            }

            ///<summary>
            /// Saves the current order
            /// </summary>
            /// <returns></returns>
            /// 

            public bool Save(Order order)
            {
                // Code that saves the passed in order

                return true;

            }
        }
    
}
