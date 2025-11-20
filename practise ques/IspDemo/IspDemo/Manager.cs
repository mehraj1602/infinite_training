using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspDemo
{
    public class Manager : IWork, IEat, ImanageTeam
    {
        public void Work()
        {
            Console.WriteLine("Manager working...");
        }
        public void Eat()
        {
            Console.WriteLine("Manager eating...");
        }
        public void ManageTeam()
        {
            Console.WriteLine("Manager managing team...");
        }
    }
}
