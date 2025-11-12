using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobject
{
    internal class Calculator
    {
        public int Addition(int a,  int b)   //method with return with args
        {
           int sum = a+b;
            return sum;
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine("difference:" +(a -b));
        }
        public void Calculate(int num1, int num2, out int addResult, out int difference, out int productResult, out int divisionResult)
        {
            addResult = num1 + num2;
            difference = num1 - num2;
            productResult = num1 * num2;
            divisionResult = num1 / num2;
        }
        
    }



}
