using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER PURCHASE AMOUNT: Rs");
            double amount = Convert.ToDouble(Console.ReadLine());
            double discountRate;

            if (amount < 1000)
                discountRate = 0.0;
            else if (amount <= 5000)
                discountRate = 0.10;
            else
                discountRate = 0.20;
            double discount = amount * discountRate;
            double finalAmount = amount - discount;
            Console.WriteLine($"\nDISCOUNT APPLIED: {discountRate * 100}%");
            Console.WriteLine($"FINAL AMOUNT AFTER DISCOUNT: Rs{finalAmount}");


        }
    }
}
