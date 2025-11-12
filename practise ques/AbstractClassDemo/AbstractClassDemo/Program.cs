using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SavingsAccount mySavings = new SavingsAccount("SA123", 1000);
            //mySavings.Deposit(500);
            //mySavings.CalculateInterest();

            ////BankAccount account = new BankAccount();
            
            PersonalDetails personalDetails = new PersonalDetails();
            personalDetails.GetPersonalDetails();

            Console.ReadLine();
        }
    }
}
