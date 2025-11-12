using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_specifiers_inheritance
{
    //example for Single Inheritance
    class Person
    {
        string name;
        int age;
        string location;
        public void getPersonDetails()
        {
            Console.WriteLine(" Enter the name of the Person");
            name = Console.ReadLine();
            Console.WriteLine(" Enter the age of the Person");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the location of the Person");
            location = Console.ReadLine();
        }
        public void DisplayPersonDetails()
        {
            Console.WriteLine(" Person Information \n ---------------------");
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Location  :  " + location);
        }
    }
    class Employee : Person
    {
        int employeeId;
        //string employeeName;
        double employeeSalary;
        string designation;

        public void getEmployeeDetails()
        {
            Console.WriteLine("Employee ID: ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Salary of the Employee");
            employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Designation of the Employee");
            designation = Console.ReadLine();


        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(" Employee Details are \n ------------------------------\n");
            Console.WriteLine($"Id: {employeeId} \nDesignation :" +
                $" {designation}\nSalary : {employeeSalary}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getPersonDetails();
            emp.getEmployeeDetails();

            emp.DisplayPersonDetails();
            emp.DisplayEmployeeDetails();
            Console.ReadLine();
        }
    }
}
