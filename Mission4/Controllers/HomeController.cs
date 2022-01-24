using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        public IActionResult Movie(Movie newMovie)
        {
            _mc.Add(newMovie);
            _mc.SaveChanges();
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
