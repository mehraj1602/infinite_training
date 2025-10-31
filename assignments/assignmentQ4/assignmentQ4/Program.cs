using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER STUDENTS NAME: ");
            string name = Console.ReadLine();
            Console.WriteLine("ENTER THE MARKS");
            double marks = Convert.ToDouble(Console.ReadLine());
            string grade;
            if (marks >= 90)
                grade = "A+";
            else if (marks >= 80)
                grade = "A";
            else if (marks >= 70)
                grade = "B";
            else if (marks >= 60)
                grade = "C";
            else if (marks >= 50)
                grade = "D";
            else
                grade = "FAIL";
            Console.WriteLine($"\nSTUDENT NAME: {name}");
            Console.WriteLine($"MARKS: {marks}");
            Console.WriteLine($"GRADE: {grade}");
        }
    }
}
