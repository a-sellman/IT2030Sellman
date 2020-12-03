using Microsoft.EntityFrameworkCore;
using System;

namespace Lab_11.Models
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Santa",
                    LastName = "Clause",
                    DateOfBirth = new DateTime(1700, 12, 25),
                    DateOfHire = new DateTime(1750, 12, 25),
                    ManagerId = 0
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(1996, 1, 12),
                    DateOfHire = new DateTime(2020, 2, 9),
                    ManagerId = 1
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(1987, 6, 4),
                    DateOfHire = new DateTime(2001, 10, 17),
                    ManagerId = 1
                }
            );
        }
    }
}