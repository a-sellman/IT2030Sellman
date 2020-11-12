using System;
using Microsoft.AspNetCore.Mvc;
using Lab08.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lab08.Controllers
{
    public class TripController : Controller

    {
        public TripController(TripLogContext context) => this.context = context;

        private TripLogContext context { get; set; }

        [HttpGet]
        public ViewResult Add(string id)
        {
            TripViewModel vm = new TripViewModel();

            switch (id?.ToLower())
            {
                case "page2":
                    string accomodation = TempData[nameof(Trip.Accomodation)]?.ToString();

                    if (string.IsNullOrEmpty(accomodation))
                    {
                        vm.PageNumber = 3;
                        string destination = TempData.Peek(nameof(Trip.Destination)).ToString();
                        vm.Trip = new Trip { Destination = destination };
                        return View("Add3", vm);
                    }

                    vm.PageNumber = 2;
                    vm.Trip = new Trip { Accomodation = accomodation };
                    TempData.Keep(nameof(Trip.Accomodation));
                    return View("Add2", vm);

                case "page3":
                    vm.PageNumber = 3;
                    vm.Trip = new Trip { Destination = TempData.Peek(nameof(Trip.Destination)).ToString() };
                    return View("Add3", vm);

                case "page1":
                default:
                    vm.PageNumber = 1;
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
                        return View("Add1");
                    }
                    TempData[nameof(Trip.Destination)] = vm.Trip.Destination;
                    TempData[nameof(Trip.Accomodation)] = vm.Trip.Accomodation;
                    TempData[nameof(Trip.EndDate)] = vm.Trip.EndDate;
                    TempData[nameof(Trip.StartDate)] = vm.Trip.StartDate;

                    return RedirectToAction("Add", new { id = "Page2" });

                case 2:
                    TempData[nameof(Trip.AccomodationPhone)] = vm.Trip.AccomodationPhone;
                    TempData[nameof(Trip.AccomodationEmail)] = vm.Trip.AccomodationEmail;
                    return RedirectToAction("Add", new { id = "Page3" });

                case 3:
                    vm.Trip.Destination = TempData[nameof(Trip.Destination)].ToString();
                    vm.Trip.Accomodation = TempData[nameof(Trip.Accomodation)]?.ToString();
                    vm.Trip.StartDate = (DateTime)TempData[nameof(Trip.StartDate)];
                    vm.Trip.EndDate = (DateTime)TempData[nameof(Trip.EndDate)];
                    vm.Trip.AccomodationEmail = TempData[nameof(Trip.AccomodationEmail)]?.ToString();
                    vm.Trip.AccomodationPhone = TempData[nameof(Trip.AccomodationPhone)]?.ToString();
                    context.Trips.Add(vm.Trip);
                    context.SaveChanges();
                    TempData["message"] = $"Trip To {vm.Trip.Destination} added ";
                    return RedirectToAction("Home");

                default:
                    return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }

        public RedirectToActionResult Index() => RedirectToAction("Index", "Home");
    }
}