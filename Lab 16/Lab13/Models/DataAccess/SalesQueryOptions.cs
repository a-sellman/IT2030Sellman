﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13.Models
{
    public class SalesQueryOptions : QueryOptions<Sales>
    {
        public void SortFilter(SalesGridBuilder builder)
        {
            if (builder.IsFilterByEmployee)
            {
                Where = s => s.EmployeeId == builder.CurrentRoute.EmployeeFilter.ToInt();
            }
            if (builder.IsFilterByYear)
            {
                Where = s => s.Year == builder.CurrentRoute.YearFilter.ToInt();
            }
            if (builder.IsFilterByQuarter)
            {
                Where = s => s.Quarter == builder.CurrentRoute.QuarterFilter.ToInt();
            }
            if (builder.IsSortByQuarter)
            {
                OrderBy = s => s.Quarter;
            }
            if (builder.IsSortByEmployee)
            {
                OrderBy = s => s.Employee;
            }
            if (builder.IsSortByAmount)
            {
                OrderBy = s => s.Amount;
            }
            else
            {
                OrderBy = s => s.Year;
            }
        }
    }
}