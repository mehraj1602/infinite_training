using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionCls connectionCls = new ConnectionCls();
            // connectionCls.ShowEmployee();
            //connectionCls.AddEmployee();
            //connectionCls.DeleteEmployee();
            //connectionCls.UpdateEmployee();
            // connectionCls.Showprocedure();
            connectionCls.EmpTransaction();
            Console.ReadLine();
        }
    }
}
