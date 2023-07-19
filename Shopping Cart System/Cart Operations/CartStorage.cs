using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Operations
{
    public class CartStorage : ICartStorage
    {
        private readonly ILogger _logger;
        public CartStorage(ILogger logger)
        {
            _logger = logger;
        }
        public void SaveCart(ShoppingCart cart)
        {
            _logger.Log("Cart saved successfully.");
        }

        public ShoppingCart RetrieveCart()
        {
            _logger.Log("Cart retrieved successfully.");
            return new ShoppingCart();
        }
    }
}
