using eCademy.NUh16.Movies.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace eCademy.NUh16.Movies.Web.Controllers
{

    public class MovieController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Movie
        public ActionResult Index()
        {
            var viewModel = new MovieListViewModel
            {
                Search = string.Empty,
                Movies = db.Movies.ToArray()
            };
            return View(viewModel);
        }

        public PartialViewResult Search(string search)
        {
            IQueryable<Movie> movies = db.Movies;

            if (!string.IsNullOrWhiteSpace(search))
            {
                movies = movies
                    .Where(m => m.Title.ToLower().Contains(search.Trim().ToLower()));
            }
            Thread.Sleep(2000);
            return PartialView("_ListPartial", movies.ToArray());
        }

        public ActionResult Edit(int id)
        {
            var movie = db.Movies.Find(id);
            if(movie == null)
            {
                return HttpNotFound();
            }

            ViewBag.Genres = new SelectList(
                db.Genres,
                nameof(Genre.Id),
                nameof(Genre.Name),
                movie.Genre.Id);

            return View(movie);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieListViewModel vm)
        {
            db.Movies.Add(vm.NewMovie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}