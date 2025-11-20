using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciplesDemo
{
    public class EmailService
    {
        public void SendEmail(Invoice invoice)
        {
            WriteLine("Invoice email sent successfully.");
        }
    }
}
