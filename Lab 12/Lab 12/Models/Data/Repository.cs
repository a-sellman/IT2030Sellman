using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab_12.Models;

namespace Lab_12.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository(TripLogContext ctx)
        {
            context = ctx;
            dbset = context.Set<T>();
        }

        protected TripLogContext context { get; set; }
        private DbSet<T> dbset { get; set; }

        public virtual void Delete(T entity) => dbset.Remove(entity);

        public virtual T Get(QueryOptions<T> options)
        {
            IQueryable<T> query = BuildQuery(options);
            return query.FirstOrDefault();
        }

        public virtual T Get(int id) => dbset.Find(id);

        public virtual void Insert(T entity) => dbset.Add(entity);

        public virtual IEnumerable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = BuildQuery(options);
            return query.ToList();
        }

        public virtual void Save() => context.SaveChanges();

        public virtual void Update(T entity) => dbset.Update(entity);

        private IQueryable<T> BuildQuery(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
            {
                query = query.Where(options.Where);
            }
            if (options.HasOrderBy)
            {
                query = query.OrderBy(options.OrderBy);
            }
            return query;
        }
    }
}