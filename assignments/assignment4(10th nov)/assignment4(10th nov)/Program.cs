using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_10th_nov_
{
     class Program
    {
        static void Main(string[] args)
        {
            ShippingCalculator standard = new StandardShipping();
            ShippingCalculator express = new ExpressShipping();
            ShippingCalculator international = new InternationalShipping();

            Console.WriteLine(standard.Label());
            Console.WriteLine($"Cost: ${standard.Calculate(2.5m, "A")}\n");


            Console.WriteLine(express.Label());
            Console.WriteLine($"Cost: ${express.Calculate(2.5m, "B")}\n");


            Console.WriteLine(international.Label());
            Console.WriteLine($"cost: ${international.Calculate(3.0m, "Europe")}\n");

            Console.ReadLine();


        }
    }
}
