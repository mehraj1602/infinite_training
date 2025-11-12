using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_10th_nov_
{
    public abstract class ShippingCalculator
    {
        public abstract decimal Calculate(decimal weight, string zone);

        public virtual string Label()
        {
            return "Generic Shopping Service";
        }
    }
}
