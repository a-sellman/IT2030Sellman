using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Lab_12.Models
{
    public interface IRepository<T>
    {
        void Delete(T entity);

        T Get(int id);

        T Get(QueryOptions<T> options);

        void Insert(T entity);

        IEnumerable<T> List(QueryOptions<T> options);

        void Save();

        void Update(T entity);
    }
}