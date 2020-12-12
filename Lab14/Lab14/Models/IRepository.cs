using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Lab14.Models
{
    public interface IRepository
    {
        void Delete(T entity);

        T Get(QueryOptions<T> options);

        T Get(int id);

        void Insert(T entity);

        IEnumerable<T> List(QueryOptions<T> options);

        void Save();

        void Update(T entity);
    }
}