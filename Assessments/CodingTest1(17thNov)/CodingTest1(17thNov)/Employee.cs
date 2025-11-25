using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest1_17thNov_
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public int Experience { get; set; }
        public Employee(int id, string name, String dept, double salary, int exp)
        {
            EmpId = id;
            Name = name;
            Department = dept;
            Salary = salary;
            Experience = exp;
        }
    }
}
