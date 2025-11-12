using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiontypes
{
    internal class Functionwithoutreturnwithargs
    {
        //user defined function declaration and defination
        static void addition(int x, int y)
        {
            int res;
            res = x + y;
            Console.WriteLine(" x+y = " + res);
        }
        static void Main()
        {
            addition(34, 89);
            //Another method to call the function addition
            int a, b;
            Console.WriteLine("ENTER THE VALUE FOR a AND b");
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            addition(a, b);
            Console.ReadLine();

        }
    }
}
