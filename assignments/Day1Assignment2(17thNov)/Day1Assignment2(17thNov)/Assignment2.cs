using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment2_17thNov_
{
    public class Assignment2
    {
        public static void Run()
        {
            Random random = new Random();

            Task<int> t1 = Task.Run(() => random.Next(1, 100));
            Task<int> t2 = Task.Run(() => random.Next(1, 100));
            Task<int> t3 = Task.Run(() => random.Next(1, 100));

             Task.WhenAll(t1, t2, t3).ContinueWith(t =>
            {

                int num1 = t1.Result;
                int num2 = t2.Result;
                int num3 = t3.Result;

                int sum = num1 + num2 + num3;
                WriteLine("Random numbers: " + num1 + "," + num2 + "," + num3);
                WriteLine("sum = " + sum);

            }).Wait();
                
        }
    }
    
   
}
