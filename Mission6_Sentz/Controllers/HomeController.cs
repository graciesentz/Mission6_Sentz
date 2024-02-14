using Microsoft.AspNetCore.Mvc;
using Mission6_Sentz.Models;
using System.Diagnostics;

namespace Mission6_Sentz.Controllers
{
    public class HomeController : Controller
    {
        private AddMovieFormContext _Context;

        public HomeController(AddMovieFormContext temp) // Constructor
        {
            _Context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Form response)
        {
            _Context.Movies.Add(response); // Add record to the database
            _Context.SaveChanges();

            return View("Confirmation", response);
        }

        public IActionResult Joel()
        {
            return View();
        }



    }
}
