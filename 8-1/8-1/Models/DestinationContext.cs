using Microsoft.EntityFrameworkCore;

namespace _8_1.Models
{
    public class DestinationContext : DbContext

    {
        public DestinationContext(DbContextOptions<DestinationContext> options)
            : base(options)
        { }

        public DbSet<Destination> Destination { get; set; }
    }
}

// Use get and post like in previous labs (tip calc) to fetch user input and then stick it in the table.