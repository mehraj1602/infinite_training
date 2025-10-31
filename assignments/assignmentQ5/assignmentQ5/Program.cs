using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE BILL AMOUNT");
            double billAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENTER TOTAL PEOPLE: ");
            int people = Convert.ToInt32(Console.ReadLine());
            double totalAmount = billAmount;
            if (billAmount > 1000)
            {
                double gst = billAmount * 0.05;
                double serviveCharge = billAmount * 0.10;
                totalAmount = billAmount + gst + serviveCharge;
            }
                double amountPerPerson = totalAmount / people;
                Console.WriteLine($"\nEACH PERSON SHOULD PAY: Rs { amountPerPerson}");
            }
        }
    }

