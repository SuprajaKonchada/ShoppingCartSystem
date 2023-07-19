using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Operations
{
    public class FixedAmountDiscount : Discount
    {
        private decimal FixedAmount;

        public FixedAmountDiscount(decimal fixedAmount)
        {
            FixedAmount = fixedAmount;
        }

        public override decimal ApplyDiscount(decimal amount)
        {
            return amount - FixedAmount;
        }
    }
}
