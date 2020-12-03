using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_11.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab_11.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(SalesContext ctx) => context = ctx;

        private SalesContext context { get; set; }

        [HttpGet]
        public ViewResult Index(int id)
        {
            IQueryable<Sales> query = context.Sales
                .Include(s => s.Employee)
                .OrderBy(s => s.Employee.LastName)
                .ThenBy(s => s.Employee.FirstName)
                .ThenBy(s => s.Year)
                .ThenBy(s => s.Quarter);

            if (id > 0)
            {
                query = query.Where(s => s.EmployeeId == id);
            }

            SalesListViewModel vs = new SalesListViewModel
            {
                Sales = query.ToList(),
                Employees = context.Employee.OrderBy(e => e.LastName).ToList(),
                EmployeeId = id
            };

            return View();
        }

        [HttpPost]
        public RedirectToActionResult Index(Employee employee)
        {
            if (employee.EmployeeId > 0)
            {
                return RedirectToAction("Index", new { id = employee.EmployeeId });
            }
            else
            {
                return RedirectToAction("Index", new { id = string.Empty });
            }
        }
    }
}