using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamin_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize, colSize;
            Console.WriteLine("enter the number of students");
            rowSize = Convert.ToInt32(Console.ReadLine());
            colSize = 5;
            int[,] studentMarks = new int[rowSize, colSize];
            for (int i = 0; i < rowSize; i++)
            {
                Console.WriteLine($"enter the marks of students {i + 1}");
                for (int j = 0; j < colSize; j++)
                {
                    Console.WriteLine($"enter the marks for students {i + 1}");
                    studentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("displaying the marks of the students");
            for (int i = 0; i < rowSize; i++)
            {
                Console.WriteLine("/n student 1 marks are /n");
                for (int j = 0; j < colSize; j++)

                {
                    Console.WriteLine(studentMarks[i, j] + "/t");

                }
                Console.ReadLine();
            }
        }
    }
    }
