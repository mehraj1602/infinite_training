
using Partial_View_Prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partial_Views_Prj.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId=1,ProductName="Shoes",Category="Accessories",
                ProductDescription="Smooth Soles for comfort",Price=3500},
                new Product{ProductId=2,ProductName="Watches",Category="Accessories",
                ProductDescription="Smart and user friendly",Price=6500},
                new Product{ProductId=3,ProductName="Curtains",Category="Furnishings",
                ProductDescription="Valence for windows",Price=13500},
                new Product{ProductId=4,ProductName="pillows",Category="Beddings",
                ProductDescription="Memory Foam for Comfort",Price=5000},
            };
            return View(products);
        }
    }
}