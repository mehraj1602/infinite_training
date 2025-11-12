using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiontypes
{
    internal class OutwithDiscard
    {
        static void Main(string[] args)
        {
            Calculate(40, 6, out int sum, out _, out int product);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("product:" + product);
        }
        static void Calculate(int a, int b, out int sum, out int diff, out int product)
        {
            sum = a + b;
            diff = a - b;
            product = a * b;
        }

    }
}
