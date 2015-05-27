using JanSeredynskiLabX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JanSeredynskiLabX.Content
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public LibraryDbContext context = new LibraryDbContext();

        public ActionResult Index() 
        {
           // DbInit();


            return View(new Movie() { ReleaseDate = DateTime.Now});
        }

        private void DbInit()
        {
            context.Movies.Add(new Movie() { Name = "Matrix", ReleaseDate = DateTime.Now.AddDays(-11) });
            context.Movies.Add(new Movie() { Name = "Matrix 2", ReleaseDate = DateTime.Now.AddYears(-10) });
            context.Movies.Add(new Movie() { Name = "Matrix 3", ReleaseDate = DateTime.Today });
            context.Movies.Add(new Movie() { Name = "Batman", ReleaseDate = DateTime.Today });
            context.Movies.Add(new Movie() { Name = "Piła", ReleaseDate = DateTime.Today });
            context.SaveChanges();
        }

        public ActionResult DeleteById(int id)
        {
            Movie movieToDelete = context.Movies.Find(id);
            context.Movies.Remove(movieToDelete);
            context.SaveChanges();
            return RedirectToAction("ShowAll");
        }

        public ActionResult ShowAll()
        {
            var query = from movies in context.Movies select movies;
            return View(query.ToList()); 
        }
        [HttpPost]
        public ActionResult AddNewMovie(Movie newMovie)
        {
            context.Movies.Add(newMovie);
            context.SaveChanges();
            return RedirectToAction("ShowAll");
        }


        public ActionResult UpdateById(int id)
        {
            var query = (from mov in context.Movies
                         where mov.Id == id
                         select mov).FirstOrDefault();
            return View(query);
        }

        public ActionResult Save(Movie oldMovie)
        {
            Movie movie = context.Movies.Find(oldMovie.Id);
            movie.Name = oldMovie.Name;
            context.SaveChanges();
            return RedirectToAction("ShowAll");

        }
    }
}
