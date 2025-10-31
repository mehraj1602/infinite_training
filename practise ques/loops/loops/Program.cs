using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"{numberArray[0]}");

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

            foreach (int number in numberArray)
            {
                Console.WriteLine(number);
            }

            string[] employeeNames = new string[5];
            for (int i = 0; i < employeeNames.Length; i++)
            {
                employeeNames[i] = Console.ReadLine();
            }

            Console.WriteLine(" Employee Names are \n");
            foreach (string name in employeeNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
