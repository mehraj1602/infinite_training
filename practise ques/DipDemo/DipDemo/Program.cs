using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase db = new SqlDatabase();  // we can swap types anytime
            OrderProcessor processor = new OrderProcessor(db);
            processor.Process();
        }
    }
}
