using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accountNumber, double initiaBalance)
            : base(accountNumber, initiaBalance)
        {
        }
        public override void CalculateInterest()
        {
            //current accounts do not earn interest
            Console.WriteLine("current account do not earn interest.");
        }
    }
}
