using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpDemo
{
    public class DiscountService
    {
        public decimal ApplyDiscount(IDiscount discount)
        {
            return discount.GetDiscount();
        }
    }
}
