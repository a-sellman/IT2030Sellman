using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Lab13.Models
{
    public class QueryOptions<T>
    {
        private string[] includes;
        public bool HasOrderBy => OrderBy != null;
        public bool HasPaging => PageNumber > 0 && PageSize > 0;
        public bool HasWhere => WhereClauses != null;

        public string Includes
        {
            set => includes = value.Replace(" ", "").Split('.');
        }

        public Expression<Func<T, Object>> OrderBy { get; set; }
        public string OrderByDirection { get; set; } = "asc";
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public Expression<Func<T, bool>> Where
        {
            set
            {
                if (WhereClauses == null) WhereClauses = new WhereClauses<T>();
                WhereClauses.Add(value);
            }
        }

        public WhereClauses<T> WhereClauses { get; set; }

        public string[] GetIncludes() => includes ?? new string[0];

        public class WhereClauses<T> : List<Expression<Func<T, bool>>> { }
    }
}