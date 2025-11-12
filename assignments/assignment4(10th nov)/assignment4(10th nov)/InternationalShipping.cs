using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_10th_nov_
{
    public class InternationalShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseRate = 20.0m;
            if (zone == "Asia") baseRate = 18.0m;
            else if (zone == "Europe") baseRate= 22.0m;

            return weight * baseRate + 50;
        }

        public override string Label()
        {
            return "International Shipping (5-10 Business Days)";
        }
    }
}
