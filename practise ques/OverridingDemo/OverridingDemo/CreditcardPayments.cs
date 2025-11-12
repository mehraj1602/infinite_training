using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingDemo
{
    public class CreditCardPayment:PaymentMethod
    {
        public override bool processpayment(decimal amount)
        {
            base.processpayment(788);
            if (amount > 0 && amount <= 5000)
            {
                Console.WriteLine($"Processing credit card payment of {amount:C} through {provider}.");
                return true;
            }
            else
            {
                Console.WriteLine("credit card payment failed: amount exceeds limit or it is invalid.");
                return false;
            }
        }
    }
   
}
