using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_stmts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose the option given below \n1.ADDITION\n2.SUBTRACTION\n3.MULTIPLICATION\n4.DIVISION");
                int choice = Convert.ToInt32 (Console.ReadLine());
                double num1, num2;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToDouble (Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("addition is: " + (num1 + num2));
                    break;
                    case 2:
                    Console.WriteLine("subtraction is:" + (num1 - num2));
                    break;
                    case 3:
                    Console.WriteLine("multiplication is: " + (num1 * num2));
                    break;
                    case 4:
                    if (num2 != 0)
                        Console.WriteLine("divition is: " + (num1 / num2));
                    else
                        Console.WriteLine("error: division by zero is not allowed");
                    break;

 
            }


          }
    }
}
