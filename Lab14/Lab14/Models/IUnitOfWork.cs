using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;

namespace Lab14.Models
{
    public interface IUnitOfWork
    {
        IRepository<Category> Categories { get; }
        IRepository<Contact> Contacts { get; }

        void Save();
    }
}