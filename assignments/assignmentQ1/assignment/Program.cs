using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR BASIC SALARY");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENTER THE YEARS OF SERVICE");
            int years = Convert.ToInt32(Console.ReadLine());
            double bonousPercentage;
            if (years < 5)
                bonousPercentage = 0.05;
            else if (years <= 10)
            bonousPercentage = 0.10;
                else
                bonousPercentage = 0.20;
            double bonous = salary * bonousPercentage;
            double finalSalary = salary + bonous;
            Console.WriteLine($"\nBonous Percentage: {bonousPercentage * 100}%");
            Console.WriteLine($"Bonous Amount: {bonous:C}");
            Console.WriteLine($"Final Salary after Adding the Bonous: {finalSalary:C}");

        }
    }
}
