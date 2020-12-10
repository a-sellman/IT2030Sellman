using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_12.Models;

namespace Lab_12.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(TripLogContext context) => this.context = context;

        private TripLogContext context { get; set; }

        public ViewResult Index()
        {
            List<Trip> trips = context.Trips.OrderBy(t => t.StartDate).ToList();
            return View(trips);
        }
    }
}