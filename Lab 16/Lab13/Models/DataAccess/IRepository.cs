using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13.Models
{
    public interface IRepository<T>
    {
        void Delete(T entity);

        T Get(int id);

        void Insert(T entity);

        IEnumerable<T> List(QueryOptions<T> options);

        void Save();

        void Update(T entity);
    }
}