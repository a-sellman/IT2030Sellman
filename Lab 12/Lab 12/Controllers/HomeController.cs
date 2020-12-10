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
        public HomeController(TripLogContext context) => data = new Repository<Trip>(context);

        private Repository<Trip> data { get; set; }

        public ViewResult Index()
        {
            var options = new QueryOptions<Trip>
            {
                Includes = "Destination, Accomodation, TripActivities.Activity",
                OrderBy = t => t.StartDate
            };
            var trips = data.List(options);
            return View(trips);
        }
    }
}