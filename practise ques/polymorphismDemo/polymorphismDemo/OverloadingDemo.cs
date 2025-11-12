using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismDemo
{
    public class OverloadingDemo
    public void GetEmployeeInfo(int id)
    {
        Console.WriteLine("Employee Id = " + id);
    }

    public void GetEmployeedetailsInfo(string name)
    {
        Console.WriteLine("Employee Name: " + name);

    }
    public void GetEmployeeInfo(int id, string name)
    {
        Console.WriteLine("Employee Id = " + id + ", Employee Name = " + name);

    }
    public void GetEmployeeInfo(string name, int id)
        { Console.WriteLine(


}
