using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab13.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab13.Models.Validation
{
    public class Validate
    {
        private Sales sales = data.Get(options);

        public static string CheckEmployee(Repository<Employee> data, Employee employee)
        {
            var options = new QueryOptions<Employee>
            {
                Where = e => e.FirstName == employee.FirstName
                && e.LastName.ToLower() == employee.LastName.ToLower()
                && e.DateOfBirth == employee.DateOfBirth
            };
            Employee searchEmployee = data.Get(options);

            return searchEmployee == null ?
                string.Empty
                : $"{searchEmployee.FullName} (DOB: {searchEmployee.DateOfBirth?.ToShortDateString()}) already exists.";
        }

        public static string CheckManagerEmployeeMatch(Repository<Employee>, Employee employee)
        {
            Employee manager = data.Get(employee.ManagerId);
            if (manager != null
                && manager.FirstName == employee.FirstName
                && manager.LastName == employee.LastName
               && manager.DateOfBirth == employee.DateOfBirth)
            {
                return $"Manager and employee cannot be the same";
            }
            return string.Empty;
        }

        public static string CheckSales(IUnitOfWork data, Sales sale)
        {
            var options = new QueryOptions<Sales>
            {
                Where = s => s.EmployeeId == sale.EmployeeId
              && s.Year == sale.Year
              && s.Quarter == sale.Quarter);
        }

            if(sales == null)
            {
                return string.Empty;
            }

    Employee employee = data.Employees.Get(sale.EmployeeId);
            return $"Sales for {employee.FullName} for {sale.Year}and{sale.Quarter} already exist.";
        }
    }
}