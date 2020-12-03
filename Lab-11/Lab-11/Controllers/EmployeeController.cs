using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_11.Models;
using Lab_11.Models.Validation;

namespace Lab_11.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController(SalesContext ctx) => context = ctx;

        private SalesContext context { get; set; }

        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.Employee = context.Employee.OrderBy(e => e.LastName).ToList();
            return View();
        }

        public IActionResult Add(Employee employee)
        {
            string message = Validate.CheckEmployee(context, employee);
            if (!string.IsNullOrEmpty(message))
            {
                ModelState.AddModelError(nameof(Employee.DateOfBirth), message);
            }
            message = Validate.CheckManagerEmployeeMatch(context, employee);
            if (!string.IsNullOrEmpty(message))
            {
                ModelState.AddModelError(nameof(Employee.ManagerId), message);
            }
            if (ModelState.IsValid)
            {
                context.Employee.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Employee = context.Employee.OrderBy(e => e.LastName).ToList();
                return View();
            }
        }

        public IActionResult Index() => RedirectToAction("Index", "Home");
    }
}