using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpDemo
{
    public class VipDiscount : IDiscount
    {
        public decimal GetDiscount()

        {
            return 0.8m;
        }
    }
}
