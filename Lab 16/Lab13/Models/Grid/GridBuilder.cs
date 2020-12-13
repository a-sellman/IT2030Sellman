using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Lab13.Models;
using System.Text;

namespace Lab13.Models
{
    public class GridBuilder
    {
        private const string RouteKey = "currentroute";

        public GridBuilder(ISession sess)
        {
            session = sess;
            routes = session.GetObject<RouteDictionary>(RouteKey) ?? new RouteDictionary();
        }

        public GridBuilder(ISession, SessionExtension, GridDTO values, string defaultSortField)
        {
            session = sess;
            routes = new RouteDictionary();
            routes.PageNumber = values.PageNumber;
            routes.PageSize = values.PageSize;
            routes.SortDirection = values.SortDirection;
            routes.SortField = values.SortField ?? defaultSortField;

            SaveRouteSegments();
        }

        public RouteDictionary CurrentRoute => routes;
        public bool IsFilterByEmployee => routes.EmployeeFilter != SalesGridDTO.DefaultFilter;
        public bool IsFilterByQuarter => routes.QuarterFilter != SalesGridDTO.DefaultFilter;
        public bool IsFilterByYear => routes.YearFilter != SalesGridDTO.DefaultFilter;

        public bool IsSortByAmount => routes.SortField.Equals(nameof(Sales.Amount), System.StringComparison.InvariantCultureIgnoreCase);
        public bool IsSortByEmployee => routes.SortField.Equals(nameof(Sales.Employee), System.StringComparison.InvariantCultureIgnoreCase);
        public bool IsSortByQuarter => routes.SortField.Equals(nameof(Sales.Quarter), System.StringComparison.InvariantCultureIgnoreCase);
        public bool IsSortByYear => routes.SortField.Equals(nameof(Sales.Year), System.StringComparison.InvariantCultureIgnoreCase);
        protected RouteDictionary routes { get; set; }

        private ISession session { get; set; }

        public void ClearFilterSegments() => routes.ClearFilters();

        public int GetTotalPages(int count)
        {
            int size = routes.PageSize;
            return (count + size - 1) / size;
        }

        public void SaveRouteSegments() => session.SetObject<RouteDictionary>(RouteKey, routes);
    }
}