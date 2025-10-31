using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hi welcome to .net session");
            Console.WriteLine("hi welcome");
            int num1 = 10;
            int num2 = 20;
            float avg_score = 58.33f;
            double precise_value = 6767.53663;
            decimal money_amount = 456.786887m;
            char grade = 'A';
            Console.WriteLine("num1 value is" + num1);
            Console.WriteLine("num2 value is " + num2);
            Console.WriteLine($"Num1 value is {num1}\nNum2 value is {num2} ");
            Console.WriteLine($"average_score = {avg_score}\nprecise_value = {precise_value}\nmoney = {money_amount}\ngrade={grade}");
                Console.ReadLine();
        }
    }
}
