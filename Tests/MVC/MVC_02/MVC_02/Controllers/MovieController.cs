using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_02.Models;

namespace MVC_02.Controllers
{
    public class MovieController : Controller
    {
        private MoviesDBEntities db = new MoviesDBEntities();
        // GET: Movie
        public ActionResult Index()
        {
            var movies = db.Movies.ToList();
            return View(movies);            
        }
        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movie/Edit/1
        public ActionResult Edit(int id)
        {
            var movie = db.Movies.Find(id);
            return View(movie);
        }

        // POST: Movie/Edit/1
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movie/Delete/1
        public ActionResult Delete(int id)
        {
            var movie = db.Movies.Find(id);
            return View(movie);
        }

        // POST: Movie/Delete/1
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Movie/MoviesByYear
        public ActionResult MoviesByYear(int year)
        {
            var movies = db.Movies.Where(m => m.DateofRelease != null && m.DateofRelease.Value.Year == year).ToList();
            return View(movies);
        }
    }
}
