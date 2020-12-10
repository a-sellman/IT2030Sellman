using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab_12.Models;

namespace Lab_12.Controllers
{
    public class ManageController : Controller

    {
        public ManageController(TripLogContext ctx) => data = new UnitOfWork(ctx);

        private UnitOfWork data { get; set; }

        [HttpPost]
        public RedirectToActionResult Add(ManageViewModel vm)
        {
            bool needsSave = false;
            string notifyMsg = string.Empty;

            if (string.IsNullOrEmpty(vm.Destination.Name))
            {
                data.Destinations.Insert(vm.Destination);
                notifyMsg += $"{vm.Destination.Name}, ";
                needsSave = true;
            }
            if (!string.IsNullOrEmpty(vm.Accomodation.Name))
            {
                data.Accomodations.Insert(vm.Accomodation);
                notifyMsg += $"{vm.Accomodation.Name}, ";
                needsSave = true;
            }
            if (!string.IsNullOrEmpty(vm.Activity.Name))
            {
                data.Activities.Insert(vm.Activity);
                notifyMsg += $"{vm.Activity.Name}, ";
                needsSave = true;
            }
            if (needsSave)
            {
                data.Save();
                TempData["message"] = notifyMsg + "added";
            }

            return RedirectToAction("Confirm");
        }

        public ViewResult Confirm() => View();

        [HttpPost]
        public IActionResult Delete(ManageViewModel vm)
        {
            bool needsSave = false;
            string notifyMsg = string.Empty;

            if (vm.Destination.DestinationId > 0)
            {
                vm.Destination = data.Destinations.Get(vm.Destination.DestinationId);
                data.Destinations.Delete(vm.Destination);
                notifyMsg += $"{vm.Destination.Name}, ";
                needsSave = true;

                if (vm.Accomodation.AccomodationId > 0)
                {
                    vm.Accomodation = data.Accomodations.Get(vm.Accomodation.AccomodationId);
                    data.Accomodations.Delete(vm.Accomodation);
                    notifyMsg += $"{vm.Accomodation.Name}, ";
                    needsSave = true;
                }

                if (vm.Activity.ActivityId > 0)
                {
                    vm.Activity = data.Activities.Get(vm.Activity.ActivityId);
                    data.Activities.Delete(vm.Activity);
                    notifyMsg += $"{vm.Activity.Name}, ";
                    needsSave = true;
                }

                if (needsSave)
                    try
                    {
                        data.Save();
                        TempData["message"] = notifyMsg + "deleted";
                    }
                    catch
                    {
                        TempData["message"] = $"Unable to delete {vm.Destination.Name} because it is in a trip.";
                        LoadDropDownData(vm);
                        return View("Index", vm);
                    }
            }
            return RedirectToAction("Confirm");
        }

        public IActionResult Index()
        {
            var vm = new ManageViewModel();
            LoadDropDownData(vm);
            return View(vm);
        }

        private void LoadDropDownData(TripViewModel vm)
        {
            vm.Destinations = data.Destinations.List(new QueryOptions<Destination>
            {
                OrderBy = d => d.Name
            });
            vm.Accomodations = data.Accomodations.List(new QueryOptions<Accomodation>
            {
                OrderBy = d => d.Name
            });
            vm.Activities = data.Activities.List(new QueryOptions<Activity>
            {
                OrderBy = d => d.Name
            });
        }
    }
}