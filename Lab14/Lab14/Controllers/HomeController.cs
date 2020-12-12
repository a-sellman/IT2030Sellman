using System;
using System.Linq;
using Lab14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab14.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Contact> data { get; set; }

        public IActionResult Index()
        {
            var options = new QueryOptions<Contact>
            {
                Includes = "Category",
                OrderBy = c => c.FName
            };
            var contacts = data.List(options);
            return View(contacts);
        }
    }
}