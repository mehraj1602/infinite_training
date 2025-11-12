using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_5th_nov_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("========== WELCOME TO ONLINE UTILITY BILLING SYSTEM=============\n");
            Console.WriteLine("Enter number of customers: ");
            int numCustomers = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numCustomers; i++)
            {
                Console.WriteLine($"\nEnter details for Customer #{i}");
                UtilityBilling customer = new UtilityBilling();

                Console.Write("Customer ID: ");
                customer.CustomerID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Customer Name: ");
                customer.CustomerName = Console.ReadLine();

                Console.WriteLine("Enter monthly usage readings: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] readings = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Enter reading #{j + 1}: ");
                    readings[j] = Convert.ToInt32(Console.ReadLine());

                }
                int totalUsage = customer.TotalUsage(readings);

                customer.CalculateBill( totalUsage, out double tax, out double netPayable, out double total);
                customer.DisplayBill(total, tax, netPayable);
            }
            Console.WriteLine(" ALL THE CUSTOMER BILLS PROCESSED SUCCESSFULLY");
            Console.ReadLine();

        }
    }
}
