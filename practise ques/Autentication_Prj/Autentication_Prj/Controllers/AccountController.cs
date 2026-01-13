using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autentication_Prj.Models;


namespace Autentication_Prj.Controllers
{
    public class AccountController : Controller
    {

        // GET: Account
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //here we will check the values entered by the users
                if (model.UserName.ToLower() == "admin" && model.Password == "admin")
                {
                    //store the username in a session
                    Session["UserName"] = model.UserName;
                    return RedirectToAction("index", "home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid user name or password");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        } 
    }
}