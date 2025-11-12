using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[2] { 7, 9 };
            jaggedArray[1] = new int[4] { 12, 42, 26, 38 };
            jaggedArray[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
            jaggedArray[3] = new int[3] { 4, 6, 8 };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                System.Console.Write("element({0}):", i + 1);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write(jaggedArray[i][j] + "\t");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
