using adonetdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9thDec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            DisconnectedCls disconnectedCls = new DisconnectedCls();
            //disconnectedCls.ShowEmployeeAndDepartment();

            //TASK 2
            // disconnectedCls.EmployeeDataView();

            //TASK 3
            //disconnectedCls.TotalTables();

            //TASK 4
           // disconnectedCls.ReaderToDataTable();

            //TASK 5
            //disconnectedCls.MergeCustomerOrders();

            //TASK 6
            disconnectedCls.ReadXmlData();




            Console.ReadLine();
        }
    }
}
