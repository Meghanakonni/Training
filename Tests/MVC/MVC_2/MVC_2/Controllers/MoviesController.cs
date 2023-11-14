using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_2.Models;
using MVC_2.Models.Repository;

namespace MVC_2.Controllers
{
    public class MoviesController : Controller
    {
        IRepository<Models.Movie> _repository = null;

        public MoviesController()
        {
            _repository = new Repository<Models.Movie>();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movie = _repository.GetAll();
            return View(movie);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(movie);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }
        }

        public ActionResult Edit(int Mid)
        {
            var movie = _repository.GetById(Mid);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Models.Movie m)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(m);
                _repository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(m);
            }
        }

        public ActionResult Details(int Mid)
        {
            var movie = _repository.GetById(Mid);
            return View(movie);
        }

        public ActionResult Delete(int Mid)
        {
            var movie = _repository.GetById(Mid);
            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int Mid)
        {
            var movie = _repository.GetById(Mid);
            _repository.Delete(Mid);
            _repository.Save();
            return RedirectToAction("Index");
        }
        public ActionResult MoviesByYear(int Year)
        {
            ViewBag.Year = Year;
            var moviesByYear = _repository.GetAll().Where(m => m.DateOfRelease.Year == Year);
            return View(moviesByYear);
        }
    }
}