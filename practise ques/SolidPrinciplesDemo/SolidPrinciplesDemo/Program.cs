using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice
            {
                InvoiceId = 1,
                Amount = 5000
            };
            InvoiceGenerator generator = new InvoiceGenerator();
            InvoiceRepository repository = new InvoiceRepository();
            EmailService emailService = new EmailService();


            generator.GenerateInvoice(invoice);
            repository.SaveToDatabase(invoice);
            emailService.SendEmail(invoice);

        }
    }
}
