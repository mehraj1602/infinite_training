using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Week9_CodingTest2.Models;

namespace Week9_CodingTest2.Controllers
{
    public class EmployeeCustomerController : ApiController
    {
        [HttpGet]
        [Route("api/orders/employee/{id}")]
        public IHttpActionResult GetOrdersByEmployee(int id)
        {
            using (var db = new NorthwindEntities1())
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var orders = db.Orders
                               .Where(o => o.EmployeeID == id)
                               .ToList();
                if (orders.Count == 0)
                    return NotFound();
                return Ok(orders);
            }
        }
        [HttpGet]
        [Route("api/customers/{country}")]
        public IHttpActionResult GetCustomersByCountry(string country)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                var result = db.GetCustomersByCountry(country).ToList();
                return Ok(result);
            }
        }
    }
}
