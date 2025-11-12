using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class StudentMarks
    {
        private int[] marks = new int[5];
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine(" invalid index! Returning -1");
                    return -1;
                }
                
                return marks[index];
            }
            set 
            {
                if (index < 0 || index >= marks.Length)
                {
                    Console.WriteLine("invalid index! cannot set value");
                }
                else
                {
                    marks[index] = value;
                }

        }
    }
        public void DisplayMarks()
        {
            Console.WriteLine("marks of students");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"student {i + 1}: {marks[i]}");
            }
        }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
           StudentMarks studentMarks = new StudentMarks();

            // Setting marks using indexer

            studentMarks[0] = 85;
            studentMarks[1] = 90;
            studentMarks[2] = 78;
            studentMarks[3] = 92;
            studentMarks[4] = 88;

            studentMarks[5] = 100;
             
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"marks of student {i + 1}: {studentMarks[i]}");

            }
            Console.WriteLine($"marks od student 6: {studentMarks[5]}");
            
            
            studentMarks.DisplayMarks();
            
            
            EmployeeListwithindex employee = new EmployeeListwithindex();

            Console.WriteLine($" employee[2]: {employee[2]}");
            employee[3] = "guru";
            Console.WriteLine($"employee[3]: {employee[3]}");

            Console.ReadLine();

        }
    }
}
