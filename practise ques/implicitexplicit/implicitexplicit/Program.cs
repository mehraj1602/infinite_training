using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicitexplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double value = num;  // implicit conversion
            Console.WriteLine($"num = {num}\n value= {value}");


            double pi = 3.14;
            int intpi = (int)pi; // explicit conversions
            Console.WriteLine($"intpi = {intpi}");
            Console.ReadLine();


            string[] names = { "geetha", "samynathan" };
            string[] copyNames = names;
            Console.WriteLine($"names[0] {names[0]}\t names[1] value is = {names[1]}");
            copyNames[0] = "vijay";
            Console.WriteLine($" names[0] {names[0]}\t names[1] value is ={names[1]}");


        }
    }
}
