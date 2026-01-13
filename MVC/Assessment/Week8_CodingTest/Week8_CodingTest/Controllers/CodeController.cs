using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week8_CodingTest.Models;

namespace Week8_CodingTest.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // 1st Action method
        public ActionResult GermanCustomers()
        {
            var customers = db.Customers
            .Where(c => c.Country == "Germany")
            .ToList();
            return View(customers);
        }

        //2nd Action method
        public ActionResult CustomerByOrder()
        {
            var customer = (from o in db.Orders
            join c in db.Customers on o.CustomerID equals c.CustomerID
           where o.OrderID == 10248
        select c).FirstOrDefault();

            return View(customer);
        }
    }
}