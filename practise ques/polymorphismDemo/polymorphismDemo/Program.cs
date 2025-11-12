using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverloadingDemo overloading = new OverloadingDemo();
            overloading.GetEmployeeInfo(101);
            overloading.GetEmployeeInfo("john Deo");
            overloading.GetEmployeeInfo(102, "jane smith");
            overloading.GetEmployeeInfo("alice johnson", 103);
            Console.ReadLine();
        }
    }
}
