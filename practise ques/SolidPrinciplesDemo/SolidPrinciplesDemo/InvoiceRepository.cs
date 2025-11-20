using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciplesDemo
{
    public class InvoiceRepository
    {
        public void SaveToDatabase(Invoice invoice)
        {
            WriteLine("Invoice saved to database.");
        }
    }
}
