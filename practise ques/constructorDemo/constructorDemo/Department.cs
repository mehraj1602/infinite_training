using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace constructorDemo
{
    internal class Department
    {
        int departmentId;
        string departmentName, deptLocation;
        static Department()
        {
            Console.WriteLine("static constructor \n ");
        }
        // default constructor or parameterless constructor
        public Department()
        {
            departmentId = 101;
            departmentName = "Unknown";
            deptLocation = "Unknown";
            Console.WriteLine("default or parameterless constructor called");

        }
        public Department(int id, string name, string location)
        {
            Console.WriteLine(" parameterised constructor called");
            this.departmentId = id;
            this.departmentName = name;
            this.deptLocation = location;
        }
        public void getDepartmentInfo()
        {
            Console.WriteLine("enter the dept ID:");
            departmentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name of the department:");
            departmentName= Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the department loaction:");
            deptLocation = Console.ReadLine();
        }
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("Department Details:");
            Console.WriteLine("Id : " + departmentId);
            Console.WriteLine("Name : " + departmentName);
            Console.WriteLine("Location: " + deptLocation);
        }
    }
}
