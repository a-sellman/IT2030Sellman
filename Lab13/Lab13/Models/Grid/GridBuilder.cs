using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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
        protected RouteDictionary routes { get; set; }
        private ISession session { get; set; }

        public int GetTotalPages(int count)
        {
            int size = routes.PageSize;
            return (count + size - 1) / size;
        }

        public void SaveRouteSegments() => session.SetObject<RouteDictionary>(RouteKey, routes);
    }
}