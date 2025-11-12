using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiontypes
{
    internal class Functionwithreturnwithoutargs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function with Return withoutbArgs\n");
            //Console.WriteLine("Addition Result:" + Addition());
            int result = Addition();
            Console.WriteLine("Addition Result: " + result);
            Console.ReadLine();
        }
        static int Addition()
        {
            int num1, num2, sum;
            Console.WriteLine("ENTER THE FIRST NUMBER");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE SECOND NUMBER");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            return sum;
            
        }

        }

}
