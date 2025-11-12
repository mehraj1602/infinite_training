using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_10th_nov_
{
    class Program
    {
        static void Main()
        {
            InterestCalculator calc = new InterestCalculator();

            double si1 = calc.CalculateInterest(10000, 5);
            Console.WriteLine("Simple Interest (1 year default): " + si1);


            double si2 = calc.CalculateInterest(10000, 5, 3);
            Console.WriteLine("Simple Interest (3 years): " + si2);


            double ci = calc.CalculateInterest(10000, 5, 3, 4);
            Console.WriteLine("Compound Interest (3 years, Quarterly): " + ci);
        }
    }
}
