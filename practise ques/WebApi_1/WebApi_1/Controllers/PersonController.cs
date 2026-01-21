using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using WebApi_1.Models;

namespace WebApi_1.Controllers
{
    [RoutePrefix("User")]
    public class PersonController : ApiController
    {
        static List<Person> personlist = new List<Person>()
        {
            new Person{Id=1,PersonName="mehraj",PersonJob="Ass.Software",Gender="Female" },
            new Person{Id=2,PersonName="Syeda",PersonJob="Makeup Artist",Gender="Female" },
            new Person{Id=3,PersonName="Fatma",PersonJob="Embeded Systems",Gender="Female" },
            new Person{Id=4,PersonName="Rosy",PersonJob="Tester",Gender="Male" },
            new Person{Id=5,PersonName="kitty",PersonJob="QA",Gender="Male" }
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Person> Get()
        {
            return personlist;
        }

        [HttpGet]
        [Route("Bymsg")]
        public HttpResponseMessage GetAllPersons()
        {
            //creating a response object with both the data and status
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personlist);

            //incase we want to send only response and no data
            //HttpResponseMessage r = new StringContent("Thanks");
            return response;
        }

        //get name by id
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetPersonsName_byId(int pid)
        {
            string pname = personlist.Where(p => p.Id == pid).SingleOrDefault()?.PersonName;
            if (pname == null)
            {
                return NotFound();
            }
            return Ok(pname);
        }

        //post 1
        [HttpPost]
        [Route("AllPost")]
        public List<Person> PostAll([FromBody] Person person)
        {
            personlist.Add(person);
            return personlist;
        }

        //post 2
        [HttpPost]
        [Route("Personp")]
        public IEnumerable<Person> PersonPost([FromUri] int id, string name, string job)
        {
            Person person = new Person();
            person.Id = id;
            person.PersonName = name;
            person.PersonJob = job;
            personlist.Add(person);
            return personlist;
        }

        [HttpPut]
        [Route("updperson")]
        public Person Put(int pid, [FromUri] string name, string job, string gender)
        {
            var plist = personlist[pid - 1];
            plist.Id = pid;
            plist.PersonName = name;
            plist.PersonJob = job;
            plist.Gender = gender;
            return plist;
        }

        //put with frombody Person obj

        //delete
        [HttpDelete]
        [Route("delperson")]
        public IEnumerable<Person> Delete(int pid)
        {
            personlist.RemoveAt(pid - 1);
            return personlist;
        }
    }
}
