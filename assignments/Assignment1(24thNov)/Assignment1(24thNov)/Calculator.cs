using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_24thNov_
{
    internal class Calculator
    {
        public int Square(int a) => a * a; //1ST EX

        public int Multiply(int a, int b) => a * b; //3RD excercise 

    }




    //2ND Excercise
    public class StringHelper 
    {
        public string ToUpper(string input) => input.ToUpper();
    }


    //4th Ex
    public class StudentService
    {
        public void ValidateAge(int age)
        {
            if (age < 0) throw new ArgumentException("Invalid age");
        }



        //5th Ex
        //Direct in test file


        //6TH EX
        public List<int> GetEvenNumbers() => new List<int> { 2, 4, 6, 8 };


        //7TH EX 
        //direct in test file


       

    }
    //8TH EX
    public class AsyncClass()
    {
        public async Task<int> GetMarksAsync()
        {
            await Task.Delay(100);
            return 90;
        }
    }



        //9TH EX
        //direct in test file
}
