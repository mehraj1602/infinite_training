using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.processpayment(1000);
            creditCardPayment.samplePayment();
            Console.WriteLine($"{creditCardPayment.provider}");
            CashOnDelivary cashOnDelivary = new CashOnDelivary();
            cashOnDelivary.processpayment(7000);
            Console.ReadLine();
        }
    }
}
