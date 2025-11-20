using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciplesDemo
{
    public class InvoiceGenerator
    {
        public void GenerateInvoice(Invoice invoice)
        {
            WriteLine("Invoice generated for amount:" + invoice.Amount);

        }
    }
}
