using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_6thnov_
{
    interface IPaymentGateway
    {
        void ProcessPayment(double amount);
    }
      static class PaymentHelper
    {
        public static void LogPayment(double amount)
        {
            Console.WriteLine("[Log]: Payment of Rs. " +  amount + "processed at " + DateTime.Now); 
        }
        public static void ShowSupportedMethods()
        {
            Console.WriteLine("Supported payment methods: CreditCard, UPI, Wallet");
        }
    }
    class CreditCardPayment : IPaymentGateway
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing credit card payment of Rs." + amount);
            PaymentHelper.LogPayment(amount);
        }
    }
        class UPIPayment : IPaymentGateway
        {
            public void ProcessPayment(double amount)
            {
                Console.WriteLine("processing UPI payment of Rs. " + amount);
                PaymentHelper.LogPayment(amount);
            }
        }

       class WalletPayment : IPaymentGateway
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("processing wallet payment of Rs." + amount);
            PaymentHelper.LogPayment(amount);

        }
    }
}
