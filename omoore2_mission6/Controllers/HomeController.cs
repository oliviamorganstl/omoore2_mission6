using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = movieContext.Categories.ToList();

            return View();
        }
        [HttpPost]

        public IActionResult Movies(AddResponse ar)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(ar);
                movieContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else //if invalid
            {
                ViewBag.Categories = movieContext.Categories.ToList();
                return View(ar);
            }


        }
        public IActionResult Collection ()
        {
            var movies = movieContext.Responses
            .Include(x => x.Category)
            .ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = movieContext.Categories.ToList(); //This pulls in the dropdown list from the categories table

            var movies = movieContext.Responses.Single(x => x.MovieID == movieid);
            return View("Movies", movies);
        }
        [HttpPost]
        public IActionResult Edit(AddResponse ar)
        {
            movieContext.Update(ar);
            movieContext.SaveChanges();

            return RedirectToAction("Collection"); //Once they finish updating
        }

        [HttpGet]
        public IActionResult Delete(int movieid) //Hit the cancel button
        {
            var movies = movieContext.Responses.Single(x => x.MovieID == movieid);
            return View(movies);
        }

        [HttpPost]
        public IActionResult Delete(AddResponse ar) //Submit the delete button
        {
            movieContext.Responses.Remove(ar);
            movieContext.SaveChanges();
            return RedirectToAction("Collection");
        }
    }
}
