using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LspDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBase perm = new PermanentEmployee();
            EmployeeBase contract = new ContractEmployee();

            WriteLine("Parmanent Bonus:" + perm.GetBonus(10000));
            WriteLine("contract Bonus:" + contract.GetBonus(10000));
         }
    }
}
