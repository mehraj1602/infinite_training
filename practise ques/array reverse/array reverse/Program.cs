using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 101,345,752,233,789 };
            foreach (int item in myArray)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine("After the reverse my array is");
            Array.Reverse(myArray);
            foreach (int item in myArray)
            {
                Console.WriteLine(item + "\t");
            }
            Console.ReadLine();
        }
    }
}
