using multipleinheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleinheritance
{
    

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Customer customer = new Customer();
        customer.GetProductInfo();
        customer.GetReviews();
        customer.DisplayProductInfo();
        customer.DisplayReviews();

        Console.ReadLine();
    }
    }

