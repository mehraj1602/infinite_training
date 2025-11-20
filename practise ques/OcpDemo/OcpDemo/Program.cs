using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OcpDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            DiscountService service = new DiscountService();

            decimal vip = service.ApplyDiscount(new VipDiscount());
            decimal employee = service.ApplyDiscount(new EmployeeDiscount());

            WriteLine("Vip Discount: " + vip);
            WriteLine("Employee Discount: " + employee);
        }
    }
}
