using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class CRUDDemo
    {
        infinitedbEntities3 dc = new infinitedbEntities3();
        public void showallemployees()
        {
            // it should display all emp from database

            var res = from t in dc.Employees
                      select t;

            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}");
                Console.WriteLine("========================");
            }

        }

        public void SearchRecord()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();

            var res = from t in dc.Employees
                      where t.EmpName.Contains(name)
                      select t;

            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}");
                Console.WriteLine("========================");
            }
        }
        public void AddRecord()
        {
            // CREATE OBJECT OF THE TABLE WHICH U WANT TO ADD(EMPLOYEE)

            // initialize all the properties(step-1)
            Employee ob = new Employee() { EmpName = "Akarsh", Salary = 45000, DateOfJoin = DateTime.Parse("1-1-2000"), DeptID = 10 };

            // attach the object to property(step-2)

            dc.Employees.Add(ob);

            // update the changes to database(step-3)

            int i = dc.SaveChanges();// updates all change to database
            Console.WriteLine("total rows  inserted is " + i);

        }
        public void DeleteRecord()
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
            Console.WriteLine("total rows  deleted is " + i);


            //  Console.WriteLine($"{res.EmpID}  {res.EmpName}  {res.DateOfJoin}  {res.Salary}  {res.DeptID}");

        }
        public void UpdateRecord()
        {
            Console.WriteLine("enter the employeeid");
            int id = int.Parse(Console.ReadLine());


            var res = (from t in dc.Employees
                       where t.EmpID == id
                       select t).First();

            res.Salary = 55500;
            int i = dc.SaveChanges();// updates all change to database
            Console.WriteLine("total rows  updated is " + i);

        }
    }
}

