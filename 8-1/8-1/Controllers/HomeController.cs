using _8_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace _8_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DestinationContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DestinationContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult Accomodations(int id, string role)

        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Accomodations(Destination request)
        {
            _logger.LogTrace($"Received request{request}.");
            if (ModelState.IsValid)
            {
                return View(request);
            }
            _context.Update(request);
            await _context.SaveChangesAsync();
            return new ViewResult()
            {
                ViewName = "ThingsToDo",
            };
        }

        [HttpGet]
        public ActionResult Destination(int id, string role)

        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Destination(Destination request)
        {
            _logger.LogTrace($"Received request{request}.");
            if (ModelState.IsValid)
            {
                return View(request);
            }

            if (_context.Destination.FindAsync(request.TripID) == null)
            {
                _context.Add(request);
            }
            else
            {
                _context.Update(request);
            }
            await _context.SaveChangesAsync();

            return View("Accomodations", request);
            //return new ViewResult()
            //{
            //    ViewName = "Accomodations",

            //};
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

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ThingsToDo(Destination request)
        {
            _logger.LogTrace($"Received request{request}.");
            if (ModelState.IsValid)
            {
                return View(request);
            }
            _context.Update(request);
            await _context.SaveChangesAsync();
            return new ViewResult()
            {
                ViewName = "Index",
            };
        }

        [HttpGet]
        public ActionResult ThingsToDo(int id, string role)

        {
            return View();
        }
    }
}