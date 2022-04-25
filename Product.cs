using Acme.Common;
using System.Collections.Generic;

namespace ACM
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;

        }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        public int ProductId { get; set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public string Log()
        {
            var logString = ProductId + ": " + ProductName + " " + "Detail: " + ProductDescription + " " + "Status: " + EntityState.ToString();
            return logString;
        }

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;

        }        
    }
}
