using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiontypes
{
    internal class CallbyvalueRef
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10; b = 20;
            Console.WriteLine("\n CALLING BY VALUE ");
            Console.WriteLine("VALUE OF A BEFORE CALLING METHODVALUE:" + a);
            MethodValue(a);
            Console.WriteLine("AFTER CALLING METHOD VALUE A VALUE:" + a);


            Console.WriteLine("\n\n CALLING BY REFRENCE DEMO");
            Console.WriteLine("VALUE OF B BEFORE CALLING METHOD REF:" + b);
            MethodRef(ref b);
            Console.WriteLine("AFTER CALLING METHOD REF B VALUE:" + b);
        }
        static void MethodValue(int a)
        {
            a = a + 10;
            Console.WriteLine("VALUE OF A IN METHOD VALUE:" + a);
        }
        static void MethodRef(ref int b)
        {
            b = b + 10;
            Console.WriteLine("VALUE OF B IN METHOD REF:" + b);
        }
    }
     

}
