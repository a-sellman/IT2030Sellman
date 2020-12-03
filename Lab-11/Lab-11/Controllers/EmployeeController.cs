using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_11.Models;

namespace Lab_11.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController(SalesContext ctx) => context = ctx;

        private SalesContext context { get; set; }
        public IActionResult
    }
}