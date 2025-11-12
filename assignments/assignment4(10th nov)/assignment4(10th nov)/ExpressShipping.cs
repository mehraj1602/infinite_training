using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_10th_nov_
{
    public class ExpressShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal rate = 10.0m;
            if (zone == "A") rate = 8.0m;
            else if (zone == "B") rate = 12.0m;
            return weight * rate;
        }
        public override string Label()
        {
            return "Express Shipping (1-2 Business Days)";
        }
    }
}
