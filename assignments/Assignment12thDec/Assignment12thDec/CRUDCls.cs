using Assignment12thDec;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace EFAssignment

{

    internal class CRUDCls

    {

        infinitedbEntities2 dc = new infinitedbEntities2();

        //1. display matching  records of employee and department from database

        public void DisplayEmployeeDept()

        {

            var res = from e in dc.Employees

                      join d in dc.Departments

                      on e.DeptID equals d.DeptID

                      select new

                      {

                          e.EmpID,

                          e.EmpName,

                          e.DateOfJoin,

                          e.Salary,

                          e.DeptID,

                          d.DeptName

                      };

            foreach (var e in res)

            {

                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}  {e.DeptName}");

                Console.WriteLine("========================");

            }

        }

        //2. display empid, empname, deptid, from the both the table

        public void DisplayIdName()

        {

            var res = from e in dc.Employees

                      join d in dc.Departments

                      on e.DeptID equals d.DeptID

                      select new

                      {

                          e.EmpID,

                          e.EmpName,

                          d.DeptID

                      };

            foreach (var e in res)

            {

                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DeptID}");

                Console.WriteLine("========================");

            }

        }

        //3. accept 2 dates from the user dynamically.it should display all employee details who have joined between 2 dates.

        public void DisplayEmpBetweenDates()

        {

            Console.WriteLine("Enter from date:");

            DateTime d1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter to date:");

            DateTime d2 = DateTime.Parse(Console.ReadLine());

            var res = from e in dc.Employees

                      where e.DateOfJoin >= d1 && e.DateOfJoin <= d2

                      select e;

            foreach (var e in res)

            {

                Console.WriteLine($"{e.EmpID}   {e.EmpName}   {e.Salary}  {e.DateOfJoin}   {e.DeptID}");

                Console.WriteLine("========================");

            }

        }

        //4. display empid, empname, salary and sal with bonus of 30%

        public void DisplayEmpIdNameSalary()

        {

            var res = from e in dc.Employees

                      select new

                      {

                          e.EmpID,

                          e.EmpName,

                          e.Salary,

                          BonusSalary = e.Salary + (e.Salary * 0.30m)

                      };

            foreach (var e in res)

            {

                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.Salary}  {e.BonusSalary}");

                Console.WriteLine("========================");

            }

        }

        //5.perform insert and delete by accepting data from the user dynamically.

        public void InsertEmployee()

        {

            // initialize all the properties(step-1)

            Employee e = new Employee();

            Console.WriteLine("Enter name:");

            e.EmpName = Console.ReadLine();

            Console.WriteLine("Enter Salary:");

            e.Salary = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of join:");

            e.DateOfJoin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter dept id:");

            e.DeptID = int.Parse(Console.ReadLine());

            // attach the object to property(step-2)

            dc.Employees.Add(e);

            // update the changes to database(step-3)

            int i = dc.SaveChanges();// updates all change to database

            Console.WriteLine("total rows  inserted is " + i);

        }

        public void DeleteEmployee()

        {

            // step-1 search a record u want to delete

            //search a record and delete the record

            Console.WriteLine("enter the employeeid");

            int id = int.Parse(Console.ReadLine());

            var res = (from t in dc.Employees

                       where t.EmpID == id

                       select t).First();

            // call remove method (step-2)

            dc.Employees.Remove(res);

            // update the changes to database(step-3)

            int i = dc.SaveChanges();// updates all change to database

            Console.WriteLine("total rows deleted is " + i);

        }

    }

}

