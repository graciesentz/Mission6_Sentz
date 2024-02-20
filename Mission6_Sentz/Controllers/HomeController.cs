using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_Sentz.Models;
using System.Diagnostics;

namespace Mission6_Sentz.Controllers
{
    public class HomeController : Controller
    {
        private AddMovieFormContext _context;

        public HomeController(AddMovieFormContext temp) // Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            _context.Movies.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        public IActionResult Joel()
        {
            return View();
        }

        public IActionResult AllMovies()
        {
            // Linq
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }


    }
}
