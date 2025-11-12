using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_3rd_nov_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("ENTER THE NUMBER OF ITEMS:");
            int itemCount = Convert.ToInt32(Console.ReadLine());

            SmartGroceryBillingSystem bill = new SmartGroceryBillingSystem(itemCount);
            for (int i = 0; i < itemCount; i++)
            {
                GroceryItem item = new GroceryItem();
                Console.WriteLine("Item Name:");
                item.Name = Console.ReadLine();

                Console.WriteLine("Quantity:");
                item.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Price per Unit:");
                item.PricePerUnit = Convert.ToDouble(Console.ReadLine());

                bill.AddItem(i, item);
            }
            bill.DisplayBill();
            Console.WriteLine("\n THANKYOU FOR SHOPPING WITH US!\t VISIT AGAIN");
            Console.ReadLine();


        }
    }
}
