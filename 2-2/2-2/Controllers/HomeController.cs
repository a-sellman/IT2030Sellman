using _2_2.Models;
using _2_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace _2_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITipCalculator _calculator;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ITipCalculator calculator,
            ILogger<HomeController> logger)
        {
            _calculator = calculator;
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new TipCalculation());
        }

        [HttpPost]
        public IActionResult Index(TipCalculation request)
        {
            _logger.LogTrace($"Received tip calculation request for cost of meal {request.CostOfMeal}.");
            if (ModelState.IsValid)
            {
                return View(_calculator.Calculate(request.CostOfMeal.Value));
            }

            return Index();
        }
    }
}