using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab07.Areas.Help.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index(string id)
        {
            switch (id)
            {
                case "Page2":
                    return View("Page2");

                case "Page3":
                    return View("Page3");

                default:
                    return View("Page1");
            }
        }
    }
}