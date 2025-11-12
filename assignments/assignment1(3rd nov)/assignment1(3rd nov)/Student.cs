using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_3rd_nov_
{
    internal class Student
    {
        public string Name;
        public int[] SubjectMarks = new int[3];

        public void CalculateResult(out int total, out double average, out char grade)
        {
        total = 0;
            foreach (int mark in SubjectMarks)
            {
            total += mark; 
            }
    average = total / 3.0;
        if (average >= 90)
            grade = 'A';
        else if (average >= 75)
            grade = 'B';
        else if (average >= 60)
             grade = 'c';
        else if (average >= 40)
             grade = 'D';
        else
             grade = 'f';
        }

        public void DisplayResult()
    {
            CalculateResult(out int total, out double average, out char grade);
            Console.WriteLine("\n------ Student Report -------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks: {string.Join(", ", SubjectMarks)}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Grade: {grade}");


    }


    }
}
