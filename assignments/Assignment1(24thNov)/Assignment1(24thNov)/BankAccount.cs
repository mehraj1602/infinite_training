using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_24thNov_
{
    internal class BankAccount
    {
        public decimal Balance { get; private set; }
        public List<string> History { get; } = new List<string>();


        //1st EX
        public BankAccount(decimal openingBalance)
        {
            Balance = openingBalance;
        }

        

        //2ND EX
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive");

            Balance += amount;
            History.Add("Deposit " + amount);
        }

        //3RD EX
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");

            Balance -= amount;
        }

        public void ApplyInterest(decimal rate)
        {
            Balance += Balance * rate;
        }
    }

}

