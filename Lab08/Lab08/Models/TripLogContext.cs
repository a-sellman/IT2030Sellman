using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Lab08.Models
{
    public class TripLogContext : DbContext
    {
        public TripLogContext(DbContextOptions<TripLogContext> options) : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }
    }
}