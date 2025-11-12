using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingDemo
{
    public class PaymentMethod
    {
        public virtual string provider => "Generic payment provider";
        public virtual bool processpayment(decimal amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"processing payment of {amount:C} through {provider}.");
                return true;
            }
            else
                return false;
        }
        public void samplePayment()
        {
            Console.WriteLine("this is a sample payment method");
        }
    }
}