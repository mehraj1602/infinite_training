using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week8_CodingTest_Part2.Models;
using Week8_CodingTest_Part2.Repository;

namespace Week8_CodingTest_Part2.Controllers
{
    public class MoviesController : Controller
    {
       
        IMovieRepository repo = new MovieRepository();

    
        public ActionResult Index()
        {
            var movies = repo.GetAll();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                repo.Add(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

     
        public ActionResult Edit(int id)
        {
            var movie = repo.GetById(id);
            return View(movie);
        }

      
        [HttpPost]
        public ActionResult Edit(Movies movie)
        {
            repo.Update(movie);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var movie = repo.GetById(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            repo.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult ByYear(int year)
        {
            var movies = repo.GetByYear(year);
            return View(movies);
        }

        public ActionResult ByDirector(string name)
        {
            var movies = repo.GetByDirector(name);
            return View(movies);
        }
    }
}