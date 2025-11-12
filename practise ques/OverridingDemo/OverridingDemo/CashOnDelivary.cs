using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingDemo
{
    public class CashOnDelivary: PaymentMethod
    {
        public override string provider => "cash on delivery";
        public override bool processpayment(decimal amount)
        {
            if (amount > 0 && amount <= 10000)
            {
                Console.WriteLine($"processing cash on delivery payment of {amount:C} through {provider}.");
                return true;
            }
            else
            {
                Console.WriteLine("cash on delivery payment failed: Amount exceeds limit or is invalid:");
                return false;
            }
        }
    }
   
}
