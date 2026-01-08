
using Custom_ModelBinding_Prj.CustomBindings;
using Custon_ModelBinding_Prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custon_ModelBinding_Prj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(EmpCustomBinder))] EmployeeModel em)
        {
            ViewBag.ctitle = em.Title;
            ViewBag.efn = em.EmpFullName;
            return View(em);
        }

    }
}