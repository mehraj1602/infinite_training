using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Attribute_Routing_Prj.Models;

namespace Attribute_Routing_Prj.Controllers
{
    [RoutePrefix("Trainees")]
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student{Id = 1 , Name = "Preethi"},
            new Student{Id = 2 , Name = "Vaibhavi"},
            new Student{Id = 3 , Name = "Naresh"},
            new Student{Id = 4 , Name = "Ram"},
            new Student{Id = 5 , Name = "Sneha"},
        };
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }

        //2. get by id
        [Route("students/{studentId}")]
        public ActionResult GetStudentDetails(int studentId)
        {
            Student student = students.FirstOrDefault(s => s.Id == studentId);
            return View(student);
        }

        //3. by name
        //public ActionResult GetStudentDetails(string studentname)
        //{
        //    Student stddetails = students.FirstOrDefault(s => s.Name == studentname);
        //    return View(stddetails);
        //}

        // get studentcourses
        [HttpGet]
        [Route("students/{studentId}/courses")]
        public ActionResult GetStudentCourses(int studentId)
        {
            List<string> CourseList;
            if (studentId == 1)
                CourseList = new List<string>() { "ASP.Net", "C#", "SQL" };
            else if (studentId == 2)
                CourseList = new List<string>() { "MVC", "ADO.Net", "WEB" };
            else if (studentId == 3)
                CourseList = new List<string>() { "WebAPI", "C#", "Java" };
            else
                CourseList = new List<string>() { "Bootstrap", "JQuery", "React" };

            ViewBag.courses = CourseList;
            return View();
        }

    }
}