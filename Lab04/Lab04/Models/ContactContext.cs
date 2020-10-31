using System;
using Microsoft.EntityFrameworkCore;

namespace Lab04.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Firstname = "Jane",
                    Lastname = "Doe",
                    Phone = "111-222-333",
                    Email = "janedoe@gmail.com",
                    CategoryID = 1,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    Firstname = "John",
                    Lastname = "Doe",
                    Phone = "444-555-6666",
                    Email = "johndoe@gmail.com",
                    CategoryID = 2,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    Firstname = "Mary",
                    Lastname = "Hart",
                    Phone = "999-999-999",
                    Email = "maryhart@gmail.com",
                    CategoryID = 3,
                    DateAdded = DateTime.Now
                });
        }
    }
}