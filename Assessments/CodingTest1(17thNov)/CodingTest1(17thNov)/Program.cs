using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest1_17thNov_
{
    public delegate bool EmployeeFilter(Employee emp);
     class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(1, "seeta", "IT", 60000, 6),
                new Employee(2, "reem", "HR", 45000, 3),
                new Employee(3, "Arvind", "Finance", 70000, 8),
                new Employee(4, "Divya", "Sales", 30000, 1),
                new Employee(5, "Aman", "IT", 55000,5),
                new Employee(6, "Rounak","Finance", 40000,2),
                new Employee(7, "Priya","Sales",65000,7),
                new Employee(8, "Anjali", "HR", 52000, 4),
                new Employee(9, "Tarun", "IT", 48000, 2),
                new Employee(10, "Syeda","Finance", 75000,10)

            };
            Console.WriteLine("********** ALL EMPLOYEES ************");
            Display(employeeList);

            Console.WriteLine("\n********* Salary > 50000 ************");
            var highSalary = employeeList.Where(e => e.Salary > 50000);
            Display(highSalary);
 
            Console.WriteLine("\n********** Employees in IT Dept *********");
            var itEmployees = employeeList.Where(e => e.Department == "IT");
            Display(itEmployees);

            Console.WriteLine("\n*********** Employees > 5 Years ***********");
            var experienced = employeeList.Where(e => e.Experience > 5);
            Display(experienced);

            Console.WriteLine("\n************ Name Start With 'A' ************");
            var nameStartsA = employeeList.Where(e => e.Name.StartsWith("A"));
            Display(nameStartsA);

            Console.WriteLine("\n*********** Sort By Name (A-Z) *************");
            var sortByName = employeeList.OrderBy(e => e.Name);
            Display(sortByName);

            Console.WriteLine("\n*********** Sort By Salary (High to Low) ***********");
            var sortBySalary = employeeList.OrderByDescending(e => e.Salary);
            Display(sortBySalary);

            Console.WriteLine("\n*********** Sort By Experience (Low to High) *******");
            var sortByExp = employeeList.OrderBy( e => e.Experience);
            Display(sortByExp);

            Console.WriteLine("\n********* Promotion List (Experience > 7) ***********");
            var promotionList = employeeList.Where(e => e.Experience > 7);
            Display(promotionList);

        }

        public static IEnumerable<Employee> FilterEmployee(List<Employee> list, EmployeeFilter filter)
        {
            foreach (var emp in list)
            {
                if (filter(emp))
                    yield return emp;
            }
        }
        static void Display(IEnumerable<Employee> list)
        {
            foreach (var e in list)
            {
                Console.WriteLine($"ID: {e.EmpId}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}, Exp:{e.Experience}");
            }
        }
    }
}
