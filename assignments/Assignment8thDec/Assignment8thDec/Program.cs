using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectedArchitecture connectedArchitecture = new ConnectedArchitecture();
            //Console.WriteLine("enter start date (yyyy-mm-dd):");
            //string s1 = Console.ReadLine();

            //Console.WriteLine("enter end date (yyyy-mm-dd):");
            //string s2 = Console.ReadLine();

            //DateTime d1, d2;

            //bool a = DateTime.TryParse(s1, out d1);
            //bool b = DateTime.TryParse(s2, out d2);

            //if (a && b)
            //{
            //    connectedArchitecture.GetTransactions(d1, d2);
            //}
            //else
            //{
            //    Console.WriteLine("invalid date format");
            //}

            //2ND TASK/////////
            //connectedArchitecture.GetCommonRecords();

            //Task 3     
            //connectedArchitecture.InsertRecordsusingtrans();

            //Task 4
            //connectedArchitecture.InsertEmployeeFetchIdentity();

            //Task 5
            //connectedArchitecture.DisplayEmployeesDepartments();

            //Task 6
           // connectedArchitecture.GetEmployeeDetailsUsing();

            Console.ReadLine();
        }
    }
}
