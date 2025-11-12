using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class student
    {
        private int age;
        private string name;
        private double salary = 45000;
        private string password = "admin123";
        public int Age
        {
            get { return age; }
            set {
                if (value < 0 || value > 120)
                    throw new Exception(" Age should be between 0 to 120");
                age = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
           
        }
        public string Password
        {
            set { password = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.Age = 30;
            student.Name = "peter";

            Console.WriteLine(" Student Informations");
            Console.WriteLine("Name: "+student.Name);
            Console.WriteLine("Age: "+student.Age); 
            Console.WriteLine("stipend: "+student.Salary);

            Console.ReadLine();


        }
    }
}
