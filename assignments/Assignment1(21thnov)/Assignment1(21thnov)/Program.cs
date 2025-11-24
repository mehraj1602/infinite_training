using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_21thnov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter notification type (email / sms / push): ");
            string type = Console.ReadLine();
            INotification notification = NotificationFactory.GetNotification(type);
            if (notification == null)
            {
                Console.WriteLine("Invalid notification type!");
                return;
            }
            Console.Write("Enter message: ");
            string message = Console.ReadLine();
            notification.Send(message);
        }
    }
}
