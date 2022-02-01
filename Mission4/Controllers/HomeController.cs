using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _mc { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext mc)
        {
            _logger = logger;
            _mc = mc;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movie()
        {
            ViewBag.Categories = _mc.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movie(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                _mc.Add(newMovie);
                _mc.SaveChanges();
                ViewBag.Categories = _mc.categories.ToList();
                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _mc.categories.ToList();
                return View(newMovie);
            }
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var allMovies = _mc.movies.Include(x => x.Category).ToList();
            return View(allMovies);
        }

        [HttpGet]
        public IActionResult EditMovie(string id)
        {
            Movie movieToEdit = _mc.movies.Single(x => x.Title == id);
            ViewBag.Categories = _mc.categories.ToList();
            return View("Movie", movieToEdit);
        }

        [HttpPost]
        public IActionResult EditMovie(Movie movie)
        {
            _mc.Update(movie);
            _mc.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult DeleteMovie(string id)
        {
            Movie toDelete = _mc.movies.Single(x => x.Title == id);
            _mc.movies.Remove(toDelete);
            _mc.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}
