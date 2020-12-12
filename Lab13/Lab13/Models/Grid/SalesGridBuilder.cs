using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Lab13.Models;

namespace Lab13.Models
{
    public class SalesGridBuilder : GridBuilder
    {
        public SalesGridBuilder(ISession sess) : base(sess)
        {
        }

        public SalesGridBuilder(ISession sess, SalesGridDTO values, string defaultSortField)
        : base(sess, values, defaultSortField)
        {
            routes.EmployeeFilter = values.Employee;
            routes.YearFilter = values.Year;
            routes.QuarterFilter = values.Quarter;
        }

        public void LoadFilterSegments(string[] filter, Employee employee)
        {
            routes.EmployeeFilter = filter[0];

            routes.YearFilter = filter[1];
            routes.QuarterFilter = filter[2];
        }
    }
}