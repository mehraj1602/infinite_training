using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_10th_nov_
{
    public class InterestCalculator
    {
        public double CalculateInterest(double principal, double rate)
        {
            double time = 1;
            double si = (principal * rate * time) / 100;
            return si;
        }

        public double CalculateInterest(double principal, double rate, double time)
        {
            double si = (principal * rate * time) / 100;
            return si;
        }

        public double CalculateInterest(double principal, double rate, double time, int n)
        {
            double amount = principal * Math.Pow(1+ (rate / (n* 100)), n * time);
            double ci = amount - principal;
            return amount;
        }
    }
}
