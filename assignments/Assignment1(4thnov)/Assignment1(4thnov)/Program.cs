using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4thnov_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("==========RIDE EASY CAB FARE SYSTEM===============\n");

            Console.WriteLine("ENTER CUSTOMER NAME: ");
            string name = Console.ReadLine();

            Console.WriteLine("ENTER LOYALTY POINTS: ");
            int points = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER VEHICLE TYPE (HATCHBACK/SEDAN/SUV): ");
            string type = Console.ReadLine();

            Console.WriteLine("ENTER BASE FARE: ");
            decimal baseFare = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("ENTER PER KM RATE: ");
            decimal perKmRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("ENTER DISTANCE (IN KM): ");
            decimal distance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("ENTER COUPON AMOUNT: ");
            decimal coupon = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("ENTER RIDE DATE (YYYY-MM-DD): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("ENTER ADD-ONS (COMMA SEPARATED e.g. CHILD-SEAT, FAST-TAG): ");
            int count = Convert.ToInt32(Console.ReadLine());

            string[] addOns = new string[count];
            for (int i = 0; i < count; i++)


            {
                Console.Write("ENTER ADD-ONS " + (i + 1) + ":");
                addOns[i] = Console.ReadLine();
            }

            Customer cust = new Customer(name, points);
            Vehicle veh = new Vehicle(type, baseFare, perKmRate);
            Ride ride = new Ride(cust, veh, date, distance);

            ride.DisplayBill(coupon);
            Console.WriteLine("THANKYOU FOR RIDING WITH RIDEEASY!!");
            Console.ReadLine();


        }
    }
}
