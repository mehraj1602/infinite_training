using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_21thnov_
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private Logger() { }

        public static Logger Instance { get { return _instance; } }

        public void WriteLog(string message)
        {
            Console.WriteLine("[LOG]" + message);
        }
    }
}
