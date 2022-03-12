using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAssignment2.Models;

namespace MVCAssignment2.Controllers
{
    public class MovieTableController : Controller
    {

        // GET: MovieTable

        MoviesEntities me = new MoviesEntities();
        public ActionResult Index()
        {
            return View();
        }

        //we need to execute this actionresult for crud operations
        public ActionResult GetMoviesScaffolded()
        {
            List<MovieTable> mt = me.MovieTables.ToList();
            return View(mt);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MovieTable MT)
        {
            me.MovieTables.Add(MT);
            me.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        public ActionResult Details(int id)
        {
            MovieTable m = me.MovieTables.Find(id);
            return View(m);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MovieTable ms = me.MovieTables.Find(id);
            return View(ms);
        }
        [HttpPost]
        public ActionResult Edit(MovieTable mt)
        {
            MovieTable n = me.MovieTables.Find(mt.MovieID);
            n.MovieName = mt.MovieName;
            n.MovieReleaseDate = mt.MovieReleaseDate;
            me.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        public ActionResult Delete(int id)
        {
            MovieTable md = me.MovieTables.Find(id);
            me.MovieTables.Remove(md);
            me.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
    }
}
