using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Lab14.Models;

namespace Lab14.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ContactController ctx)
        {
            context = ctx;
        }

        private ContactController context { get; set; }

        public IActionResult Index()
        {
            //        var contacts = context.Contacts.OrderBy(m => m.CategoryID).ToList();
            var contacts = context.Contacts.ToList();
            return View(contacts);
        }
    } 