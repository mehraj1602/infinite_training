using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR AGE");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE SHOW TIMINGS (24-hr FORMAT):");
            int time= Convert.ToInt32(Console.ReadLine());
            int price;
            if (age < 12)
                price = 150;
            else if (time < 18)
                price = 250;
            else
                price = 300;
            Console.WriteLine($"TICKET PRICE: Rs{price}");
        }
    }
}
