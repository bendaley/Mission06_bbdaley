using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_bbdaley.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_bbdaley.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryContext movieTimeContext { get; set; }

        // Constructor
        public HomeController(MovieEntryContext nameTime)
        {
            movieTimeContext = nameTime;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MyPodcasts()
        {
            return View("Podcasts");
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(MovieEntry me)
        {
            movieTimeContext.Add(me);
            movieTimeContext.SaveChanges();

            return View();
            
        }

        public IActionResult MovieList()
        {
            var movieApps = movieTimeContext.Responses
                .OrderBy(x => x.Category)
                .ToList();

            return View(movieApps);
        }
    }
}
