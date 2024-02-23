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
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            if(ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //Invalid data
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }
            
        }

        public IActionResult Joel()
        {
            return View();
        }

        public IActionResult AllMovies()
        {
            // Linq
            var movies = _context.Movies.Include("Category")
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movieToEdit = _context.Movies
                .Single(x => x.MovieId == id
                
                );
            
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddMovie", movieToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("AllMovies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movieToDelete = _context.Movies
               .Single(x => x.MovieId == id);

            return View(movieToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("AllMovies");
        }

    }
}
