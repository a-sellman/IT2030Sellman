using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab13.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab13.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(SalesContext ctx)
        {
            this.context = ctx;
            this.dbset = this.context.Set<T>();
        }

        protected SalesContext context { get; set; }
        private DbSet<T> dbset { get; set; }
    }
}