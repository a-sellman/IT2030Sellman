﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab13.Models;
using Microsoft.AspNetCore.Mvc;
using Lab13.Models.Validation;

namespace Lab13.Controllers
{
    public class ValidationController : Controller
    {
        public ValidationController(SalesContext ctx) => context = ctx;

        private UnitOfWork data { get; set; }

        public JsonResult CheckEmployee(string firstName, string lastName, DateTime dateofBirth)
        {
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateofBirth
            };
            string message = Validate.CheckEmployee(data.Employees, employee);
            if (string.IsNullOrEmpty(message))
            {
                return Json(true);
            }
            return Json(message);
        }

        public JsonResult CheckManager(int managerId, string firstName, string lastName, DateTime dateofBirth)
        {
            Employee employee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateofBirth,
                ManagerId = managerId
            };
            string message = Validate.CheckManagerEmployeeMatch(data.Employees, employee);
            if (string.IsNullOrEmpty(message))
            {
                return Json(true);
            }
            return Json(message);
        }

        public JsonResult CheckSales(int employeeId, int year, int quarter)
        {
            Sales sales = new Sales
            {
                EmployeeId = employeeId,
                Year = year,
                Quarter = quarter
            };
            string message = Validate.CheckSales(context, sales);
            if (string.IsNullOrEmpty(message))
            {
                return Json(true);
            }
            return Json(message);
        }
    }
}