using System;
using System.Collections.Generic;
using Lab_12.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace Lab_12.Controllers

{
    public class TripController : Controller

    {
        public TripController(TripLogContext context) => data = new UnitOfWork(context);

        private UnitOfWork data { get; set; }

        [HttpGet]
        public ViewResult Add(string id)
        {
            TripViewModel vm = new TripViewModel();

            switch (id?.ToLower())
            {
                case "page2":

                    vm.PageNumber = 2;
                    int destinationId = (int)TempData.Peek(nameof(Trip.DestinationId));
                    vm.DestinationName = data.Destinations.Get(destinationId).Name;
                    vm.Activities = data.Activities.List(new QueryOptions<Activity>
                    {
                        OrderBy = a => a.Name
                    });
                    return View("Add2", vm);

                case "page1":
                default:
                    vm.PageNumber = 1;
                    vm.Destinations = data.Destinations.List(new QueryOptions<Destination>
                    {
                        OrderBy = d => d.Name
                    });

                    vm.Accomodations = data.Accomodations.List(new QueryOptions<Accomodation>
                    {
                        OrderBy = a => a.Name
                    });

                    return View("Add1", vm);
            }
        }

        [HttpPost]
        public IActionResult Add(TripViewModel vm)
        {
            switch (vm.PageNumber)
            {
                case 1:
                    if (!ModelState.IsValid)
                    {
                        vm.Destinations = data.Destinations.List(new QueryOptions<Destination>
                        {
                            OrderBy = d => d.Name
                        });

                        vm.Accomodations = data.Accomodations.List(new QueryOptions<Accomodation>
                        {
                            OrderBy = a => a.Name
                        });

                        return View("Add1", vm);
                    }
                    TempData[nameof(Trip.DestinationId)] = vm.Trip.DestinationId;
                    TempData[nameof(Trip.StartDate)] = vm.Trip.StartDate;
                    TempData[nameof(Trip.EndDate)] = vm.Trip.EndDate;

                    if (vm.Trip.AccomodationId > 0)
                    {
                        TempData[nameof(Trip.AccomodationId) vm.Trip.AccomodationId];
                    }
                    return RedirectToAction("Add", new { id = "Page2" });

                case 2:
                    vm.Trip = new Trip
                    {
                        DestinationId = (int)TempData[nameof(Trip.DestinationId)],
                        StartDate = (DateTime)TempData[nameof(Trip.StartDate)],
                        EndDate = (DateTime)TempData[nameof(Trip.EndDate)]
                    };
                    if (TempData.Keys.Contains(nameof(Trip.AccomodationId)))
                    {
                        vm.Trip.AccomodationId = (int)TempData[nameof(Trip.AccomodationId)];
                    }
                    foreach (int activityId in vm.SelectedActivities)
                    {
                        if (vm.Trip.TripActivities == null)
                        {
                            vm.Trip.TripActivities = new List<TripActivity>();
                        }
                        vm.Trip.TripActivities.Add(new TripActivity { ActivityId = activityId });
                    }

                    data.Trips.Insert(vm.Trip);
                    data.Save();
                    Destination destination = data.Destinations.Get(vm.Trip.DestinationId);
                    TempData["message"] = $"Trip to {destination.Name} added.";
                    return RedirectToAction("Index, Home");

                default:
                    return RedirectToAction("Index, Home");
            }
        }

        public IActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public RedirectToActionResult Delete(int id)
        {
            Trip trip = data.Trips.Get(id);
            Destination destination = data.Destinations.Get(trip.DestinationId);
            data.Trips.Delete(trip);
            data.Save();
            TempData["message"] = $"Trip to {destination.Name} removed";
            return RedirectToAction("Index", "Home");
        }

        public RedirectToActionResult Index() => RedirectToAction("Index", "Home");
    }
}