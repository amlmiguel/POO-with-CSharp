using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class ProductRepository
    {

        ///<summary>
        /// Retrieve one product
        /// </summary>
        /// 

        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id

            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "Product";
                product.Description = "Description";
                product.CurrentPrice = 10;
            }
            return product;
        }

        ///<summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        /// 

        public bool Save(Product product)
        {
            // Code that saves the passed in product

            return true;

        }
    }
}
