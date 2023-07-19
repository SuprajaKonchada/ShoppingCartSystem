using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Operations
{
    public class CartPrinter : ICartPrinter
    {
        private readonly ILogger _logger;
        public CartPrinter(ILogger logger)
        {
            _logger = logger;
        }
        public void PrintCart(ShoppingCart cart)
        {
            _logger.Log("\nShopping Cart Details:");
            _logger.Log("----------------------");

            foreach (var product in cart.Products)
            {
                if (product is SpecialOfferProduct specialOfferProduct)
                {
                    decimal OfferPrice = specialOfferProduct.Discount.ApplyDiscount(product.Price);
                    _logger.Log("Special Product: "+product.Name+",Offer Price: "+OfferPrice);
                }
                else
                {
                    _logger.Log("Product: "+product.Name+", Price: "+product.Price);
                }
            }
        }
    }
}
