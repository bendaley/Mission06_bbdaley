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
        private readonly ILogger<HomeController> _logger;
        private MovieEntryContext movieTimeContext { get; set; }

        // Constructor
        public HomeController(ILogger<HomeController> logger, MovieEntryContext nameTime)
        {
            _logger = logger;
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
