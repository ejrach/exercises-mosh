using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST /api/newrentals
        //This action takes a NewRentalDto as an input to our application
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //edge case - there are no movies in the Dto.
            //Moving this to the top prevents a query to the database (saves some time)
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given.");

            //- This api action is entered when a single customer wants to rent a new movie.
            //- First get the customer from the context.
            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId);

            //edge case - customer Id is not given or correct.
            if (customer == null)
                return BadRequest("CustomerId is not valid.");

            //- Then we get multiple movies from the context. We are loading multiple movies. This translates
            //  to a sql statement like this:
            //      SELECT * 
            //      FROM Movies
            //      Where Id IN(1, 2, 3, ...)
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            //edge case - the movie count received from the database is not the sames as our Dto.
            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or MovieIds are invalid.");

            //Iterate over each object, creating an object for a Rental, setting the Customer, Movie, DateRented
            foreach(var movie in movies)
            {
                //edge case - there are no movies available
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
