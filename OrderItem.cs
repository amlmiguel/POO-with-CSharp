namespace ACM
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public int Quantity { get; set; }

        ///<summary>
        ///Retrieve one order item.
        /// </summary>
        /// 

        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item

            return new OrderItem();
        }

        /// <summary>
        /// Saves the current order item.
        /// </summary>
        /// <returns></returns>
        /// 
        public bool Save()
        {
            // Code that saves the defined order item

            return true;

        }

        ///<summary>
        /// Validates ther order item data.
        /// </summary>
        /// <returns></returns>
        /// 
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;

            return isValid;
        }

    }
}
