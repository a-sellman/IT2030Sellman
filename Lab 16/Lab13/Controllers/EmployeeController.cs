using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab13.Models;
using Lab13.Models.Validation;

namespace Lab13.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController(SalesContext ctx) => this.data = new Repository<Employee>(ctx);

        private Repository<Employee> data { get; set; }

        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.Employees = data.List(new QueryOptions<Employee> { OrderBy = e.FirstName });
        }

        public IActionResult Add(Employee employee)
        {
            string message = Validate.CheckEmployee(data, employee);
            if (!string.IsNullOrEmpty(message))
            {
                ModelState.AddModelError(nameof(Employee.DateOfBirth), message);
            }
            message = Validate.CheckManagerEmployeeMatch(data, employee);
            if (!string.IsNullOrEmpty(message))
            {
                ModelState.AddModelError(nameof(Employee.ManagerId), message);
            }
            if (ModelState.IsValid)

            {
                data.Insert(employee);
                data.Save();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Employee = data.List(new QueryOptions<Employee> { OrderBy = e => e.FirstName).ToList();
                return View();
            }
        }

        public IActionResult Index() => RedirectToAction("Index", "Home");
    }
}