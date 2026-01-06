using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst.Models;
using MVC_CodeFirst.Repository;

namespace MVC_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository<Products> _productsRepo = null;

        //controller constructor

        public ProductController()
        {
            _productsRepo = new ProductRepository<Products>();
        }
        // GET: Product
        //all products
        public ActionResult Index()
        {
            var products = _productsRepo.GetAll();
            return View(products);
        }

        //2. creating a new product
        public ActionResult Create()
        {
            return View();
        }

        //2.1 create post
        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                _productsRepo.Insert(products);
                _productsRepo.Save();
                return RedirectToAction("Index");
            }
            return View(products);
        }
        // 3. Get product by Id
        [ActionName("Details")]
        public ActionResult ProductDetails(int Id)
        {
            var product = _productsRepo.GetById(Id);
            return View(product);
        }

        // Update Data in Products

        public ActionResult Edit(int id)
        {
            var product = _productsRepo.GetById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            if (ModelState.IsValid)
            {
                _productsRepo.Update(product);
                _productsRepo.Save();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // Deleting the Product

        public ActionResult Delete(int id)
        {
            var product = _productsRepo.GetById(id);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _productsRepo.Delete(id);
            _productsRepo.Save();
            return RedirectToAction("Index");
        }



    }
}