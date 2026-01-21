using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Week9_CodingTest_Client.Models;

namespace Week9_CodingTest_Client.Controllers
{
    public class EmployeeOrdersController : Controller
    {
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327/");
            var response = await client.GetAsync("api/orders/employee/5");
            var data = await response.Content.ReadAsAsync<List<Order>>();
            return View(data);
        }
    }
}