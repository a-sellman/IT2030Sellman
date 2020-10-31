using System;
using System.Linq;
using Lab04.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab04.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ContactContext contactContext)
        {
            context = contactContext;
        }

        private ContactContext context { get; }

        public IActionResult Index()
        {
            var contacts = context.Contacts
            .Include(c => c.Category)
            .OrderBy(c => c.Firstname)
            .ToList();

            return View(contacts);
        }
    }
}