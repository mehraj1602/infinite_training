using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4thnov_
{
    internal class Vehicle
    {
        public string type;
        public decimal baseFare;
        public decimal perKmRate;
        public Vehicle(string t, decimal baseFare, decimal perKmRate)
        {
            type = t;
            baseFare = baseFare;
            perKmRate = perKmRate;

        }
    }
}
