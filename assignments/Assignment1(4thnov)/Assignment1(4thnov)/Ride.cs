using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4thnov_
{
    internal class Ride
    {
        public Customer customer;
        public Vehicle vehicle;
        public DateTime rideDate;
        public decimal distanceKm;

    public Ride(Customer c, Vehicle v, DateTime date, decimal dist)
        {
            customer = c;
            vehicle = v;
            rideDate = date;
            distanceKm = dist;
        }
         
        // Non-static method
         
       public void ComputeBill(out decimal subtotal, out decimal gst, out decimal total, params string[] addOns)
        {
            subtotal = vehicle.baseFare + (vehicle.perKmRate * distanceKm);

            decimal addOnCost = Pricing.AddOnsCost(addOns);
            subtotal += addOnCost;

            Pricing.TryGetWeekendSurcharge(rideDate, out decimal weekendPercent);
            subtotal += subtotal * weekendPercent;

            gst = Pricing.CalculateGST(subtotal);
            total = subtotal + gst;

        }

        public void DisplayBill(decimal couponAmount )
        {
            ComputeBill(out decimal subtotal, out decimal gst, out decimal total, "fast-tag", "priority-pickup");

            Pricing.ApplyCoupon_ByRef(ref total, couponAmount);
            Pricing.ReedeemLoyalty(ref customer.loyaltyPoints, ref total);


            string temp = "Example";
            Console.WriteLine("\n(out discard simulated): Ignoring variable '{0}'\n", temp);


            Console.WriteLine("======================RIDE INVOICE======================");
            Console.WriteLine("Customer Name: " + customer.Name);
            Console.WriteLine("Vehicle Type: " + vehicle.type);
            Console.WriteLine("Ride Date: " + distanceKm);
            Console.WriteLine("Distance (km): " + distanceKm);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("subtotal: Rs" + subtotal);
            Console.WriteLine("GST (18%): Rs" + gst);
            Console.WriteLine("total (with GST): Rs" + (subtotal+gst));
            Console.WriteLine("Coupon Applied: Rs" + couponAmount);
            Console.WriteLine("Final Amount Payable: Rs" + total);
            Console.WriteLine("Remaining Loyalty Points: " + customer.loyaltyPoints);
            Console.WriteLine("========================================================\n");

        }

    }
}
