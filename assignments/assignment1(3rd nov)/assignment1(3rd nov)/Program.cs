using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_3rd_nov_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("ENTER THE NUMBER OF STUDENTS:");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();

                Console.WriteLine($"\nENTER THE NAME OF THE STUDENT {i + 1}");
                students[i].Name = Console.ReadLine();

                students[i].SubjectMarks = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"ENTER THE MARKS FOR THE SUBJECT {j + 1}:");
                    students[i].SubjectMarks[j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n====== STUDENT REPORTS ======");
            foreach (Student s in students)
            {
                s.DisplayResult();
            }
            Console.WriteLine("\nPROGRAM FINISHED...PLEASE PRESS ANY KEY TO EXIT..");
            Console.ReadLine();

            
        }
    }
}
