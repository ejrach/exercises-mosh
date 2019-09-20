using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
//using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Migrations;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            return View();
        }
        
        public ViewResult New()
        {
            //Create a list of the genres with context to the database
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        
        
        ////GET: Movies/Random
        ////This returns a View at ".../Movies/Random" 
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };

        //    var customers = new List<Customer>
        //    {
        //        new Customer { Name = "Customer 1" },
        //        new Customer { Name = "Customer 2" }
        //    };

        //    //Create a ViewModel object
        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    //Pass model to the view by passing it as an argument.
        //    return View(viewModel);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            //Use modelstate property to get access to validatation data.
            //Since we are requiring specific properties in the Movie model,
            //we want to return the MovieForm if fields are empty. So need 
            //to define the viewModel and return the form.
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
        //ByReleaseDate corresponds to the route set here:
        //Here we are using regular expressions to set the month format of 2 digits and to be in the range 
        //of 01 to 12.
        //Example: .../movies/released/2016/04
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    //This returns a url
        //    return Content(year + "/" + month);
        //}


        //This returns Content at ".../Movies/Edit/1
        //public ActionResult Edit (int id)
        //{
        //    return Content("id=" + id);
        //}

        //movies
        //We make pageIndex nullable by using "?" behind int. This allows us to not have to pass any parameters.
        //string type is nullable, so it doesn't need the modifier.
        //In the URL to see in action, paste:
        //  1) https://localhost:44398/movies
        //  2) https://localhost:44398/movies?pageIndex=2
        //  3) https://localhost:44398/movies?pageIndex=3&sortBy=ReleaseDate 
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    //if the page index does not have a value, initialize it to 1
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}