using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _7_1.Models;

namespace _7_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(int id, string role)

        {
            return View();
        }

        [HttpGet]
        public ActionResult Page1(int id, string role)

        {
            return View();
        }

        [HttpGet]
        public ActionResult Page2(int id, string role)

        {
            return View();
        }

        [HttpGet]
        public ActionResult Page3(int id, string role)

        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}