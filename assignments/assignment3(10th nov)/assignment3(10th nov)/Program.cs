using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_10th_nov_
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineStore store = new OnlineStore();

            store.Checkout(100);
            store.Checkout(100, 3);
            store.Checkout("SAVE10");
            store.Checkout(100, 3, "SAVE10");
        }
    }
}
