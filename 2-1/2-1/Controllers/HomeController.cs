using _2_1.Models;
using _2_1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace _2_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPriceQuotationCalculator _calculator;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            IPriceQuotationCalculator calculator,
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
            return View(new PriceQuotation());
        }

        [HttpPost]
        public IActionResult Index(PriceQuotation request)
        {
            _logger.LogTrace($"Received price quotation request for subtotal {request.Subtotal} and discount percent {request.DiscountPercent}.");
            return View(_calculator.Calculate(request.Subtotal, request.DiscountPercent));
        }
    }
}