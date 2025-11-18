using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment2_17thNov_
{
    public class Assignment3
    {
        public static int Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }

        public static void Run()
        {
            int number = 5;
            Task<int> factorialTask = Task.Run(() => Factorial(number));
            WriteLine("Factorial of " + number + " = " + factorialTask.Result);
            
        }

            

    }
}
