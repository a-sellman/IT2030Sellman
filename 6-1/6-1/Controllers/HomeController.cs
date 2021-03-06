﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _6_1.Models;

namespace _6_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult BootStrap(int id, string role)

        {
            return View();
        }

        [HttpGet]
        public ActionResult Csharp(int id, string role)

        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult General(int id, string role)

        {
            return View();
        }

        [HttpGet]
        public ActionResult History(int id, string role)

        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(int id, string role)

        {
            return View();
        }

        [HttpGet]
        public ActionResult JavaScript(int id, string role)

        {
            return View();
        }
    }
}