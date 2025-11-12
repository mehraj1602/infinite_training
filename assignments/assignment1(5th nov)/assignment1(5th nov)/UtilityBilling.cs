using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_5th_nov_
{
    internal class UtilityBilling
    {
        // class fields for customer info

        public int CustomerID;
        public string CustomerName;

        // static method for global service charge

        public static double GetServiceCharge()

        {
            return 50.0; //fixed charge common to all the customers
        }

        // params method to calculate total usage from variable readings

        public int TotalUsage(params int[] readings)
        {
            int total = 0;
            foreach (int unit in readings)
            {
                total += unit;
            }
            return total;
        }
        // non- static method using out parameters
        public void CalculateBill(int totalUsage, out double tax, out double netPayable,out  double total)
        {
            double rate = 6.5; // cost per unit
            double taxRate = 0.10; //10% tax

            total = totalUsage * rate;
            tax = total * taxRate;
            netPayable = total + tax + GetServiceCharge();
        }

        // method to display customer bill

        public void DisplayBill(double total, double tax, double netPayable)
        {
            Console.WriteLine("\n============ UTILITY BILL ================");
            Console.WriteLine("Customer ID: " + CustomerID);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Service Charge: " + GetServiceCharge());
            Console.WriteLine("Total Usage: " + total.ToString("0.00"));
            Console.WriteLine("Tax Applied: " + tax.ToString("0.00"));
            Console.WriteLine("Net Payable: " + netPayable.ToString("0.00"));
            Console.WriteLine("=============================================");
        }
    }


}
    

