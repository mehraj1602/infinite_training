using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspDemo
{
   public class EmployeeBase
    {
        public int Empid {  get; set; }
        public string Empname { get; set; }
        public string Empdept { get; set; }
        public virtual decimal GetBonus (decimal salary)
        {
            return salary * 0.10m;
        }
    }
}
