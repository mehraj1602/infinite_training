using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER YOUR PASSWORD");
            string password = Console.ReadLine();
            int length = password.Length;
            string strength;
            if (length < 6)
                strength = "WEAK";
            else if (length <= 10)
                strength = "Medium";
            else
                strength = "STRONG";
            Console.WriteLine($"PASSWORD STRENGTH: {strength}");
        }
    }
}
