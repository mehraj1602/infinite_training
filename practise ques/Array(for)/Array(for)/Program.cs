using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5] { 10, 20, 30, 40, 50 };
            int[] myArray2 = new int[5];
            myArray2[0] = 100;
            myArray2[1] = 120;
            myArray2[2] = 130;
            myArray2[3] = 140;
            myArray2[4] = 150;
            Console.WriteLine($"enter {myArray2.Length}number:");
            for(int i = 0; i < numArray.Length; i++)
            {
                myArray2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("/n Array elements are/n....");
            foreach(var item in myArray2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
