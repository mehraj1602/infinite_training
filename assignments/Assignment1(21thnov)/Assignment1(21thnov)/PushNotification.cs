using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment1_21thnov_
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            WriteLine("Push Notification: " +  message);
        }
    }
}
