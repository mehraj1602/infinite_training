using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters_Prj.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //[Authorize]

        public ActionResult Index()
        {
            throw new Exception("something went wrong!!");
           // return View();
        }
        //
         public ActionResult TestMethod()
        {
            throw new NullReferenceException();
        }
        //

        public ActionResult TestMethod2()
        {
            throw new NullReferenceException();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}