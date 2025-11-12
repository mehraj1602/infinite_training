using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classobject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2;
            //Calculator calculator = new Calculator(); // instance or object declaration 
            //Console.WriteLine("enter num1");
            //num1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter num2");
            //num2= Convert.ToInt32(Console.ReadLine());

            //calculator.Addition(num1, num2);
            //calculator.Subtraction(num1, num2);
            //Employee employee = new Employee();
            //employee.AcceptEmployeeDetails(101, "mehraj", "software enginee;
            //employee.DisplayEmployeeDetails();
            //Employee employee2 = new Employee();
            //employee2.AcceptEmployeeDetails(102, "fatima", "QA engineer");
            //employee2.DisplayEmployeeDetails();
            //Employee employee3 = new Employee();
            //employee.AcceptEmployeeDetails(103, "syeda", "Manager");
            //employee.DisplayEmployeeDetails();
            //Employee employee = new Employee();
            //int empId;
            //string empName;
            //string designation;
            //Console.WriteLine(" ENTER THE EMPLOYEE ID, NAME, DESIGNATION");
            //empId = Convert.ToInt32(Console.ReadLine());    
            //empName = Console.ReadLine();
            //designation = Console.ReadLine();
            //employee.AcceptEmployeeDetails(empId, empName, designation);
            //employee.DisplayEmployeeDetails(); // parameters with crct sequence

            //employee.AcceptEmployeeDetails(id: empId, designation: designation, name: empName);
            //employee.DisplayEmployeeDetails(); // named parameter with sequence change

            //employee.AcceptEmployeeDetails(empId, designation, empName);
            //employee.DisplayEmployeeDetails();// changed parameters so the output is jumbled


            //Calculator calculator = new Calculator();
            //calculator.Calculate(20, 10 , out int addResult, out int difference, out int productResult, out int divisionResult);
            //Console.WriteLine($"sum={addResult}\ndifference={difference}\nproduct={productResult}\ndivision={divisionResult}");

            Employee employee = new Employee(); //default parameters takes the default value when any value is not given (so in the main employees class the destination value is taken as jr assosiate in all the employees details)
            employee.AcceptEmployeeDetails(101, "john doe");
            employee.DisplayEmployeeDetails();

            employee.AcceptEmployeeDetails(102, "Lalitha");
            employee.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}
