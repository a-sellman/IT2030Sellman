﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_11.Models;
using Lab_11.Models.Validation;

namespace Lab_11.Controllers
{
    public class SalesController : Controller
    {
        public SalesController(SalesContext ctx) => context = ctx;

        public SalesContext context { get; set; }

        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.Employee = context.Employee.OrderBy(e => e.LastName);
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
                context.Sales.Add(sales);
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