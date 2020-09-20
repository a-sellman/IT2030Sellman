using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _4_1.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Friend" },
                new Category { CategoryID = 2, Name = "Work" },
                new Category { CategoryID = 3, Name = "Family" }


                );
            modelBuilder.Entity<Contact>().HasData(
                new Contact { CategoryID = 1, FName = "Jane", LName = "Doe", PhoneNumber = 999-999-9999, Email = "janedoe@gmail.com" },
                new Contact { CategoryID = 2, FName = "John", LName = "Doe", PhoneNumber = 111 - 111 - 1111, Email = "johndoe@gmail.com" },
                new Contact { CategoryID = 3, FName = "Mary", LName ="Johnson", PhoneNumber = 222 - 222 - 2222, Email = "maryjohnson@gmail.com" }
            );
        }
    }
}

