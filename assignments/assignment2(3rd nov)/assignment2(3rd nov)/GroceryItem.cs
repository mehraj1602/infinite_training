using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_3rd_nov_
{
    internal class GroceryItem
    {
        public string Name;
        public int Quantity;
        public double PricePerUnit;

        public void CalculateTotal(out double total)
        {
            total = Quantity * PricePerUnit;

        }

    }
}
