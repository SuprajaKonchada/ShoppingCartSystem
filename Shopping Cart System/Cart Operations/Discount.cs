using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Operations
{
    public abstract class Discount
    {
        public abstract decimal ApplyDiscount(decimal amount);
    }
}
