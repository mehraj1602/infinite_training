using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_1.Models;

namespace WebApi_1.Controllers
{
    public class EmployeeController : ApiController
    {
        static List<Employee> Employeelist = new List<Employee>()
        {
            new Employee{Id=1,EmployeeName="mehraj",EmployeeDesignation="Ass.Software Engineer",Gender="Female" },
            new Employee{Id=2,EmployeeName="Syeda",EmployeeDesignation="QA Engineer",Gender="Female" },
            new Employee{Id=3,EmployeeName="Fatima",EmployeeDesignation="Embeded Systems Engineer",Gender="Female" },
            new Employee{Id=4,EmployeeName="Rohan",EmployeeDesignation="Tester",Gender="Male" },
            new Employee{Id=5,EmployeeName="kitty",EmployeeDesignation="Senior Software Engineer",Gender="Male" }
        };
    
     [HttpGet]
        [Route("All")]
        public IEnumerable<Employee> Get()
        {
            return Employeelist;
        }

        [HttpGet]
        [Route("Bymsg")]
        public HttpResponseMessage GetAllEmployee()
        {
            //creating a response object with both the data and status
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Employeelist);

            //incase we want to send only response and no data
            //HttpResponseMessage r = new StringContent("Thanks");
            return response;
        }

        //get name by id
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetEmployeeName_byId(int pid)
        {
            string pname = Employeelist.Where(p => p.Id == pid).SingleOrDefault()?.EmployeeName;
            if (pname == null)
            {
                return NotFound();
            }
            return Ok(pname);
        }

        //post 1
        [HttpPost]
        [Route("AllPost")]
        public List<Employee> PostAll([FromBody] Employee employee)
        {
            Employeelist.Add(employee);
            return Employeelist;
        }

        //post 2
        [HttpPost]
        [Route("Employeep")]
        public IEnumerable<Employee> employeePost([FromUri] int id, string name, string job)
        {
            Employee employee = new Employee();
            employee.Id = id;
            employee.EmployeeName = name;
            employee.EmployeeDesignation = job;
            Employeelist.Add(employee);
            return Employeelist;
        }

        [HttpPut]
        [Route("updemployee")]
        public Employee Put(int eid, [FromUri] string name, string Designation, string gender)
        {
            var plist = Employeelist[eid - 1];
            plist.Id = eid;
            plist.EmployeeName = name;
            plist.EmployeeDesignation = Designation;
            plist.Gender = gender;
            return plist;
        }

        //put with frombody Person obj

        //delete
        [HttpDelete]
        [Route("delemployee")]
        public IEnumerable<Employee> Delete(int eid)
        {
            Employeelist.RemoveAt(eid - 1);
            return Employeelist;
        }
    }
}
