using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }

    }
    internal class EmployeeListwithindex
    {
        List<Employee> employeelist = new List<Employee>()
        { new Employee(){ EmployeeId = 1, EmployeeName= "logesh",Gender="male"},
            new Employee() { EmployeeId= 2, EmployeeName="fatima",Gender="female"},
            new Employee() { EmployeeId= 3, EmployeeName="kanishka",Gender="female" }
        };
        public string this[int empid]
        {
            get
            {
                return employeelist.FirstOrDefault(e => e.EmployeeId == empid)?.EmployeeName;

            }

            set
            {
                employeelist.FirstOrDefault(e => e.EmployeeId == empid).EmployeeName = value;
            }
        }
    }
}
