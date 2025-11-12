using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_10th_nov_
{
    internal class StandardShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal rate = 5.0m;
            if (zone == "A") rate = 4.0m;
            else if (zone == "B") rate = 6.0m;
             return weight * rate;
        }
        public override string Label()
        {
            return "Standard Shipping (3-5 Business Days)";
        }
    }
}
