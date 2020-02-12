using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Vidly.Dto;
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

        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (newRental.MoviesIds.Count == 0)
                return BadRequest("No movie id has been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);
            if (customer == null)
                return BadRequest("Customer id is not valid.");


            var movies = _context.Movies.Where(m => newRental.MoviesIds.Contains(m.Id)).ToList();

            if (movies.Count != newRental.MoviesIds.Count)
                return BadRequest("One or more movies ids are invalid.");

            foreach (var movie in movies)
            {
                if (movie == null)
                    return NotFound();

                if (movie.NumberAvalible == 0)
                    return BadRequest(movie.Name + " is not avalible.");

                movie.NumberAvalible--;
                var rental = new Rental()
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