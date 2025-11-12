using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functiontypes
{
    internal class Parameters
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfIntegers(10,56));
            Console.WriteLine(SumOfIntegers(56,45,78,79));
            Console.WriteLine(SumOfIntegers(50,70,90,20,570,78,56,66));
            Console.ReadLine();
        }

        static int SumOfIntegers(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
