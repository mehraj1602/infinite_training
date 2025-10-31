using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQ7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE LIGHT COLOR:");
            string color = Console.ReadLine().ToLower();
            string action;
            if (color == "red")
                action = "STOP";
            else if (color == "yellow")
                action = "GET READY";
            else if (color == "green")
                action = "GO";
            else
                action = " INVALID COLOR ENTERED!";
            Console.WriteLine($"Action: {action}");

        }
    }
}
