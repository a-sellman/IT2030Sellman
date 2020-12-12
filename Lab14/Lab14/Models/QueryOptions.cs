﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;

namespace Lab14.Models
{
    public class QueryOptions<T>
    {
        private string[] includes;
        public bool HasOrderBy => OrderBy != null;
        public bool HasWhere => Where != null;

        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(',');
        }

        public Expression<Func<T, Object>> OrderBy { get; set; }
        public Expression<Func<T, bool>> Where { get; set; }

        public string[] GetIncludes() => includes ?? new string[0];
    }
}