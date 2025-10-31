using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, gender;
            int age;
            char grade;
            int score1, score2, score3;
            Console.WriteLine("Enter the firstname, lastnamel, gender, age, grade, score1, score2, score3");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            gender = Console.ReadLine();
            age = Convert.ToInt16(Console.ReadLine());
            grade = Convert.ToChar(Console.ReadLine());
            score1 = Convert.ToInt16(Console.ReadLine());
            score2 = Convert.ToInt32(Console.ReadLine());
            score3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("student info\n ***************");
            Console.WriteLine($"full name ={firstname} {lastname}");
            Console.WriteLine($"gender = {gender} \nage= {age} \ngrade = {grade}");
            Console.WriteLine($"score1 = {score1} \nscore2 ={score2} \nscore3= {score3}");
            Console.WriteLine("****************");
          
        }
    }
}
