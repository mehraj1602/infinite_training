using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_21thnov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.WriteLog("Application started.");
            logger.WriteLog("User logged in.");
        }
    }
}
