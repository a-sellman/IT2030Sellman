using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _6_1.Models
{
    public class JContext : DbContext
    {
        public JContext(DbContextOptions<JContext> options)
            : base(options)
        { }

        public DbSet<Javascript> Javascript { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Javascript>().HasData(

                new Javascript
                {
                    JavascriptID = 1,
                    JName = "What Is Javascript",
                    JContent = "A general purpose scripting language that executes in the web" +
                    "browser.",
                },
                new Javascript
                {
                    JavascriptID = 2,
                    JName = "When Was Javascript Released",
                    JContent = "Javascript was released in 1995."
                }
            );
        }
    }
}