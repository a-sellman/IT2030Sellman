using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab13.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab13.Models
{
    protected SalesContext context { get; set; }
    private DbSet<T> dbset { get; set; }

    public class Repository<T> : IRepository<T> where T : class
    {
        private int? count;

        public Repository(SalesContext ctx)
        {
            this.context = ctx;
            this.dbset = this.context.Set<T>();
        }

        public int Count => Count ?? dbset.Count();

        public virtual void Delete(T entity) => dbset.Delete(entity);

        public virtual T Get(int id) => DbSet.Find(id);

        public virtual void Insert(T entity) => dbset.Add(entity);

        public virtual IEnumerable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = buildQyery(options);
            return query.FirstOrDefault();
        }

        public virtual void Save() => context.SaveChanges();

        public virtual void Update(T entity) => dbset.Update(entity);

        private IQueryable<T> BuildQuery(QueryOptions<T> options)
        {
            IQueryable<T> query = this.dbset;

            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }

            if (options.HasWhere)
            {
                foreach (var clause in options.WhereClauses())
                {
                    query = query.Where(clause);
                }

                this.count = query.Count();
            }

            if (options.HasOrderBy)
            {
                if (options.OrderByDirection == "asc")
                {
                    query = query.OrderBy(options.OrderBy);
                }
                else
                {
                    query = query.OrderByDescending(options.OrderBy);
                }
            }
            if (options.HasPaging)
            {
                query = query.PageBy(options.PageNumber, options.PageSize);
            }
            return query;
        }
    }