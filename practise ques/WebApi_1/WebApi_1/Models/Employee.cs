using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDesignation { get; set; }
        public string Gender { get; set; }
    }
}