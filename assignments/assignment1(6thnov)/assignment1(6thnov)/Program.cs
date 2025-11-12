using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_6thnov_
{
    internal class Program
    {
        static void Main()
        {
            PaymentHelper.ShowSupportedMethods();

            IPaymentGateway CreditCard = new CreditCardPayment();
            CreditCard.ProcessPayment(1500);

            IPaymentGateway upi = new UPIPayment();
            upi.ProcessPayment(800);

            IPaymentGateway wallet = new WalletPayment();
            wallet.ProcessPayment(500);
        }
    }
}
