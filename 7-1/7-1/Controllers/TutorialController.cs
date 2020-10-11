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
    public class TutorialController : Controller
    {
        private readonly ILogger<TutorialController> _logger;

        public TutorialController(ILogger<TutorialController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Page1"); //Views/Tutorial/Page1.cshtml
        }

        public IActionResult Page1(string id = "All")
        {
            ViewBag.Category = id;
            return View(); //Views/Tutorial/Page1
        }

        public IActionResult Page2(string id)
        {
            ViewBag.ProductSlug = id;
            return View(); //Views/Tutorial/Page2
        }

        public IActionResult Page3(string id)
        {
            ViewBag.ProductSlug = id;
            return View(); //Views/Tutorial/Page3
        }
    }
}