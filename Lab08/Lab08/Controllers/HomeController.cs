using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab08.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab08.Controllers
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