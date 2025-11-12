using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_11th_nov_
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Operator Overloading for +
        public static BankAccount operator +(BankAccount a1, BankAccount a2)
        {
            return new BankAccount(
                a1.AccountNumber,
                a1.AccountHolder,
                a1.Balance + a2.Balance
            );
        }

        // Operator Overloading for -
        public static BankAccount operator -(BankAccount a1, decimal amount)
        {
            if (a1.Balance - amount < 0)
            {
                Console.WriteLine("⚠️ Transaction failed! Insufficient balance.");
                return a1;
            }

            return new BankAccount(a1.AccountNumber, a1.AccountHolder, a1.Balance - amount);
        }

        // Operator Overloading for ==
        public static bool operator ==(BankAccount a1, BankAccount a2)
        {
            return a1.Balance == a2.Balance;
        }

        // Operator Overloading for !=
        public static bool operator !=(BankAccount a1, BankAccount a2)
        {
            return !(a1 == a2);
        }

        // Operator Overloading for >
        public static bool operator >(BankAccount a1, BankAccount a2)
        {
            return a1.Balance > a2.Balance;
        }

        // Operator Overloading for <
        public static bool operator <(BankAccount a1, BankAccount a2)
        {
            return a1.Balance < a2.Balance;
        }

        // Override ToString()
        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}, Account Number: {AccountNumber}, Balance: ₹{Balance}";
        }

        // Required override for == and !=
        public override bool Equals(object obj)
        {
            if (obj is BankAccount account)
                return Balance == account.Balance;
            return false;
        }

        public override int GetHashCode()
        {
            return Balance.GetHashCode();
        }
    }
}

    