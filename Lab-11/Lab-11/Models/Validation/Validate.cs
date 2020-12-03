using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_11.Models.Validation
{
    public class Validate
    {
        public static string CheckEmployee(SalesContext context, Employee employee)
        {
            Employee searchEmployee = context.Employee.FirstOrDefault(
                e => e.FirstName.ToLower() == employee.FirstName.ToLower()
                && e.LastName.ToLower() == employee.LastName.ToLower()
                && e.DateOfBirth == employee.DateOfBirth
            );

            return searchEmployee == null ?
                string.Empty
                : $"{searchEmployee.FullName} (DOB: {searchEmployee.DateOfBirth?.ToShortDateString()}) already exists.";
        }

        public static string CheckManagerEmployeeMatch(SalesContext context, Employee employee)
        {
            Employee manager = context.Employee.Find(employee.ManagerId);
            if (manager != null
                && manager.FirstName == employee.FirstName
                && manager.LastName == employee.LastName
               && manager.DateOfBirth == employee.DateOfBirth)
            {
                return $"Manager and employee cannot be the same";
            }
            return string.Empty;
        }

        public static string CheckSales(SalesContext context, Sales sale)
        {
            throw new NotFiniteNumberException();
        }
    }
}