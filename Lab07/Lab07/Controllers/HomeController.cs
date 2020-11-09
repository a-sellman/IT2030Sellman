using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab07.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>
            {
                { "Phone", "440-384-1808" },
                { "Email", "april.sellman@gmail.com" },
                { "GitHub", "https://github.com/a-sellman" }
            };

            return View(contacts);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}