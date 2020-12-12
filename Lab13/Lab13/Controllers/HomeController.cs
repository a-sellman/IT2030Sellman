using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab13.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab13.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(SalesContext ctx) => this.data = new UnitOfWork(ctx);

        private SalesContext context { get; set; }
        private UnitOfWork data { get; set }

        [HttpGet]
        public RedirectToActionResult Clear()
        {
            return RedirectToAction("Index", new { });
        }

        [HttpPost]
        public RedirectToActionResult Filter(string[] filter, bool clear = false)
        {
            var builder = new SalesGridBuilder(HttpContext.Session);

            if (clear)
            {
                builder.ClearFilterSegments();
            }
            else
            {
                var employee = data.Employees.Get(filter[0].ToInt());
                builder.LoadFilterSegments(filter, employee);
            }

            return RedirectToAction("Index", builder.CurrentRoute);
        }

        [HttpGet]
        public ViewResult Index(SalesGridDTO vals)

        {
            string defaultSort = nameof(Sales.Year);
            var builder = new SalesGridBuilder(HttpContext.Session, vals, defaultSort);

            var options = new SalesQueryOptions
            {
                Includes = "Employee",
                OrderBy = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };

            options.SortFilter(builder);

            SalesListViewModel vs = new SalesListViewModel
            {
                Sales = data.Sales.List(options),
                Employee = data.Employees.List(new QueryOptions<Employee> { OrderBy = e => e.FirstName }),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Sales.Count)
            };

            return View();
        }
    }
}