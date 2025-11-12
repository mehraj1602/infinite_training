using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiontypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition();
            Console.ReadLine();
        }
        static void Addition() 
        {
            int num1, num2, sum;
            Console.WriteLine("ENTER THE FIRST NUMBER");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE SECOND NUMBER");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum= num1+ num2;
            Console.WriteLine("SUM OF THE GIVEN NUMBERS: " + sum);
        }
    }
}
