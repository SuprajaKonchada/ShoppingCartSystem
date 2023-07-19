using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Operations
{
    public interface ICartStorage
    {
        void SaveCart(ShoppingCart cart);
        ShoppingCart RetrieveCart();
    }
}
