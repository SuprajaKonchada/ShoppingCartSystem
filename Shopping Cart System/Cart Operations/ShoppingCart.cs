using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Operations
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();
        public IReadOnlyList<Product> Products => products;

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                if (product is SpecialOfferProduct specialOfferProduct)
                {
                    total += specialOfferProduct.Discount.ApplyDiscount(product.Price);
                }
                else
                {
                    total += product.Price;
                }
            }
            return total;
        }
    }
}
