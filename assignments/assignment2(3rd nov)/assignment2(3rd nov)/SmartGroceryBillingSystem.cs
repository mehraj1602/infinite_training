using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_3rd_nov_
{
    internal class SmartGroceryBillingSystem
    {
        private GroceryItem[] items;
        public SmartGroceryBillingSystem(int itemCount)
        {
            items = new GroceryItem[itemCount];

        }
        public void AddItem(int index, GroceryItem item)
        {
            items[index] = item;
        }
        public void CalculateBill(out double grandTotal, out double discountAmount, out double finalAmount)
        {
            grandTotal = 0;
            for (int i = 0; i < items.Length; i++)
            {
                items[i].CalculateTotal(out double itemTotal);
                grandTotal += itemTotal;
            }
            double discountRate = 0;
            if (grandTotal > 5000)
                discountRate = 0.20;
            else if (grandTotal >= 2000)
                discountRate = 0.10;
            else if (grandTotal >= 1000)
                discountRate = 0.05;
            else 
                discountRate = 0;

            discountAmount = grandTotal * discountRate;
                finalAmount = grandTotal - discountAmount;



        }
        public void DisplayBill()
        {
            Console.WriteLine("\n=======SMART GROCERY BILL=========");
            Console.WriteLine("Item\tQuantity\tPrice/Unit\tTotal");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < items.Length; i++)
            {
                items[i].CalculateTotal(out double itemTotal);
                Console.WriteLine(items[i].Name + "\t" + items[i].Quantity + "\t" + items[i].PricePerUnit.ToString("0.00") + "\t\t" + itemTotal.ToString("0.00"));
            }
            CalculateBill(out double grandTotal, out double discountAmount, out double finalAmount);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Grand Total: " + grandTotal.ToString("0.00"));
            Console.WriteLine("Discount: " + discountAmount.ToString("0.00"));
            Console.WriteLine("FinalAmount: " + finalAmount.ToString("0.00"));
            Console.WriteLine("===================================");
        }
    }
}
