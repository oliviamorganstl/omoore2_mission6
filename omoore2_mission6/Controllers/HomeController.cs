using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using omoore2_mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//Tells the computer which page to serve up based on which actions they take
namespace omoore2_mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AddMovieContext movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, AddMovieContext someName)
        {
            _logger = logger;
            movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Movies(AddResponse ar)
        {
            movieContext.Add(ar);
            movieContext.SaveChanges();

            return View("Confirmation", ar);
        }
        public IActionResult Privacy()
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
