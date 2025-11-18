using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1Assignment2_17thNov_
{
    public class Assignment1
    {
        public static void Run()
        {
            Task task1 = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                    WriteLine(i);
            });
            Task task2 = Task.Run(() =>
            {
                for (int i = 6; i <= 10; i++)
                    WriteLine(i);
            });
            Task task3 = Task.Run(() =>
            {
                WriteLine("All numbers printed!");
            });
            Task.WaitAll(task1, task2, task3);
            WriteLine("Done");

                    
            
        }
    }
}
