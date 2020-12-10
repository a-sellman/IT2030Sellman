using System;
using Lab_12.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Lab_12.Models
{
    public class TripLogContext : DbContext
    {
        public TripLogContext(DbContextOptions<TripLogContext> options) : base(options)
        {
        }

        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TripConfig());
            modelBuilder.ApplyConfiguration(new TripActivityConfig());
        }
    }
}