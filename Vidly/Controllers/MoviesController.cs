using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{

    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sultan!" };
            var customers = new List<Customer>
                 {
                 new Customer {Name = "customer 1"},
                 new Customer {Name = "customer 2"}
                  }; 
            var viewModel = new RandomMovieViewModel
            {
            Movie = movie,
            Customers = customers
            };

            return View(viewModel); 
        }

        //    [Route("movies/released/{year}/{month:regex(\\d{4}:range(1,12))})"]
        //public ActionResult byreleseyear(int year,int month)
        //{
        //  //  var movie = new Movie() { Name = "Shrek!" };

        //    //return View(movie );
        //    return Content(year +"/"+month);
        //}


       
    }
}