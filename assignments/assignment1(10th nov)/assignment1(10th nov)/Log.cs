using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_10th_nov_
{
    public class Log
    {
        public void Write(string message)
        {
            Console.WriteLine($"Message: {message}");

        }
        public void Write(string message, int level)
        {
            Console.WriteLine($"Message: {message} {level}");

        }
        public void Write(string Message, DateTime time)
        {
            Console.WriteLine($"message: {Message}, Time: {time}");
        }
        public void Write(string message, int level, DateTime time)
        {
            Console.WriteLine($"Message: {message}, Level: {level}, Time: {time}");
        }
    }
}
