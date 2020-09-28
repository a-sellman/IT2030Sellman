using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _6_1.Models
{
    public class BootContext : DbContext
    {
        public BootContext(DbContextOptions<BootContext> options)
            : base(options)
        { }

        public DbSet<Boot> Boot { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boot>().HasData(
                new Boot
                {
                    BootstrapID = 1,
                    BName = "What Is Bootstrap",
                    BContent = "Bootstrap is a CSS framework for creating responsive web apps for multiple " +
                    "screen sizes."
                },
                new Boot
                {
                    BootstrapID = 2,
                    BName = "When Was Bootstrap Released",
                    BContent = "Bootstrap was released in 2011."
                }
            );
        }
    }
}