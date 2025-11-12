using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_10th_nov_
{
    class Program
    {
        static void Main()
        {
            Log logger = new Log();
            logger.Write("system started");
            logger.Write("low disk space", 2);
            logger.Write("user login detached", DateTime.Now);
            logger.Write("critical error, 5", DateTime.Now);
            Console.ReadLine();
          
        }
    }
}
