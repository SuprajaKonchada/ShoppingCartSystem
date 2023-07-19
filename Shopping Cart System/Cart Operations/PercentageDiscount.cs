using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart_Operations
{
    public class PercentageDiscount : Discount
    {
        private decimal Percentage;

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
        }

        public override decimal ApplyDiscount(decimal amount)
        {
            return amount - (amount * Percentage);
        }
    }
}
