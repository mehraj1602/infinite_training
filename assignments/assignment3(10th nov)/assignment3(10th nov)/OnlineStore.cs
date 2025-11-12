using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_10th_nov_
{
    public class OnlineStore
    {
        public void Checkout(int price)
        {
            Console.WriteLine($"Total amount: ${price}");
        }

        public void Checkout(int price, int quantity)
        {
            int total = price * quantity;
            Console.WriteLine($"Total amount for {quantity} items: ${total}");
        }

        public void Checkout(string couponCode)
        {
            Console.WriteLine($"Applying coupon code: {couponCode}");
        }

        public void Checkout(int price, int quantity, string couponCode)
        {
            int total = price * quantity;
            Console.WriteLine($"Total before discount: ${total}");
            Console.WriteLine($"Applying coupon code: {couponCode}");
        }
    }
}
