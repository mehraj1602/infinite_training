using Assignment15thDec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAssignment
{
    internal class CRUD
    {
        Model1 dc = new Model1();
        public void AddEmployee()
        
            {
                Employee emp = new Employee();

                Console.Write("Enter EmpId (E001): ");
                emp.EmpId = Console.ReadLine();

                Console.Write("Enter Name: ");
                emp.EmpName = Console.ReadLine();

                Console.Write("Enter Department: ");
                emp.DepartmentName = Console.ReadLine();

                Console.Write("Enter Salary: ");
                emp.Salary = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Year of Joining: ");
                emp.YearOfJoining = Convert.ToInt32(Console.ReadLine());

                dc.Employees.Add(emp);
                dc.SaveChanges();

                Console.WriteLine("Employee inserted successfully");
            
        }


        public void DisplayEmployee()
        {
            var employees = dc.Employees.ToList();

            employees.ForEach(e =>
            {
                Console.WriteLine($"{e.EmpId} {e.EmpName} {e.DepartmentName} {e.Salary} {e.YearOfJoining}");
            });
        }

        public void UpdateEmployee()
        {
            Console.Write("Enter EmpId to update: ");
            string id = Console.ReadLine();

            var emp = dc.Employees
                        .Where(e => e.EmpId == id)
                        .FirstOrDefault();

            if (emp != null)
            {
                Console.Write("Enter New Salary: ");
                emp.Salary = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Department: ");
                emp.DepartmentName = Console.ReadLine();

                dc.SaveChanges();
                Console.WriteLine("Employee updated successfully");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }

        public void DeleteEmployee()
        {
            Console.Write("Enter EmpId to delete: ");
            string id = Console.ReadLine();

            var emp = dc.Employees
                        .Where(e => e.EmpId == id)
                        .FirstOrDefault();

            if (emp != null)
            {
                dc.Employees.Remove(emp);
                dc.SaveChanges();
                Console.WriteLine("Employee deleted successfully");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }
    }

}