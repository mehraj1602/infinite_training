using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobject
{
    internal class Employee
    {
        private int empId;
        private string empName;
        private string disignation;
            public void AcceptEmployeeDetails(int id,string name,string designation="Jr.Associate")
        {  
           this.empId = id; 
           this.empName = name;
           this.disignation = designation;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(" Employee ID:"+  empId);
            Console.WriteLine("Employee name:"+ empName);
            Console.WriteLine("Designation:"+ disignation);
        }
    }
}
