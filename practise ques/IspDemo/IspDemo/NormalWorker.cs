using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IspDemo
{
    public class NormalWorker : IWork, IEat
    {
        public void Work()
        {
            WriteLine(" Normal worker working...");

        }

        public void Eat()
        {
            WriteLine("Normal worker eating...");
        }
    }
    
   
}
