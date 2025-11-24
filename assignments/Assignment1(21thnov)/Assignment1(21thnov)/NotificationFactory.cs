using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment1_21thnov_
{
    public static class NotificationFactory
    {
        public static INotification GetNotification(string type)
        {
            switch(type.ToLower())
            {
                case "email": return new EmailNotification();
                case "sms": return new SmsNotification();
                case "push": return new PushNotification();
                    default: return null;
            }
        }
    }
}
