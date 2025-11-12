using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_4thnov_
{
    internal class Pricing
    {
        // 1.GST @ 18%
        public static decimal CalculateGST(decimal amount)
        {
            return amount * 0.18m;
        }

        // 2. Weekend surcharge
        public static void TryGetWeekendSurcharge(DateTime rideDate, out decimal percent)
        {
            if (rideDate.DayOfWeek == DayOfWeek.Saturday || rideDate.DayOfWeek == DayOfWeek.Sunday)
                percent = 0.10m;
            else
                percent = 0.0m;
        }
        // 3. Add-ons cost(using params)
        public static decimal AddOnsCost(params string[] addOns)
        {
            decimal total = 0;
            foreach (string add in addOns)
            {
                switch (add.ToLower())
                {
                    case "child-seat": total += 100;
                        break;
                    case "fast-tag": total += 150; 
                        break;
                    case "priority-pickup": total += 200;
                        break;
                    case "extra-luggage": total += 120;
                        break;

                }
            }
            return total;
        }
              // 4. Coupon by value
              public static void TryApplyCoupon_ByValue(decimal total, decimal couponAmount, out decimal newTotal)
        {
            newTotal = total - couponAmount;
            if (newTotal < 0) newTotal = 0;
        }

        // 5. Coupon by reference

        public static void ApplyCoupon_ByRef(ref decimal total, decimal couponAmount)
        {
            total -= couponAmount;
            if(total < 0) total = 0;
        }

        //6. Reedeem Loyalty Points

        public static void ReedeemLoyalty(ref int points, ref decimal total)
        {
            if (points >= 100)
            {
                //decimal reedeemValue = points;
                //total -= reedeemValue;
                //if (total < 0) total = 0;
                //points = 0;
                total -= 50;
                points -= 100;
            }
        }
    }
}
