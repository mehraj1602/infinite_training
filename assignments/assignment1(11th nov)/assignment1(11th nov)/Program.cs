using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_11th_nov_
{
     class Program
    {
        static void Main(string[] args)
        {
            // Create BankAccount objects
            BankAccount acc1 = new BankAccount("AC101", "Ramesh Kumar", 25000);
            BankAccount acc2 = new BankAccount("AC102", "Suresh Nair", 40000);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            // Using + operator (Deposit/Merge)
            Console.WriteLine("\nMerging accounts (using +):");
            BankAccount merged = acc1 + acc2;
            Console.WriteLine($"Combined Balance: ₹{merged.Balance}");

            // Using comparison operators
            Console.WriteLine("\nComparing balances:");
            Console.WriteLine($"AC101 < AC102 -> {acc1 < acc2}");
            Console.WriteLine($"AC101 == AC102 -> {acc1 == acc2}");

            // Using - operator (Withdrawal)
            Console.WriteLine("\nWithdrawal operation (using -):");
            BankAccount newAcc = acc1 - 5000;
            Console.WriteLine($"New Balance of {acc1.AccountHolder}: ₹{newAcc.Balance}");
        }
    }
}
        
    

