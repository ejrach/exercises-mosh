using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies/Random
        //This returns a View at ".../Movies/Random" 
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        //ByReleaseDate corresponds to the route set here:
        //Here we are using regular expressions to set the month format of 2 digits and to be in the range 
        //of 01 to 12.
        //Example: .../movies/released/2016/04
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            //This returns a url
            return Content(year + "/" + month);
        }


        //This returns Content at ".../Movies/Edit/1
        public ActionResult Edit (int id)
        {
            return Content("id=" + id);
        }

        //movies
        //We make pageIndex nullable by using "?" behind int. This allows us to not have to pass any parameters.
        //string type is nullable, so it doesn't need the modifier.
        //In the URL to see in action, paste:
        //  1) https://localhost:44398/movies
        //  2) https://localhost:44398/movies?pageIndex=2
        //  3) https://localhost:44398/movies?pageIndex=3&sortBy=ReleaseDate 
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if the page index does not have a value, initialize it to 1
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}