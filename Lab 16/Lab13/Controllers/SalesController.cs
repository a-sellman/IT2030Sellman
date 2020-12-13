using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab13.Models.Validation;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class SalesController : Controller
    {
        public SalesController(SalesContext ctx) => this.data = new UnitOfWork(ctx);

        public UnitOfWork data { get; set; }

        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.Employee = data.Employees.List(new QueryOptions<Employee> { OrderBy = e => e.FirstName });
            return View();
        }

        public IActionResult Add(Sales sales)
        {
            string message = Validate.CheckSales(context, sales);
            if (!string.IsNullOrEmpty(message))
            {
                ModelState.AddModelError(nameof(Sales.EmployeeId), message);
            }

            if (ModelState.IsValid)
            {
                data.Sales.Insert(sales);
                data.Save();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Employee = data.Employees.List(new QueryOptions<Employee> { OrderBy = e => e.FirstName });
                return View();
            }
        }

        public IActionResult Index() => RedirectToAction("Index", "Home");
    }
}