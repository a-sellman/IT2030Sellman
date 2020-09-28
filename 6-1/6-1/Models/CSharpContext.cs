using Microsoft.EntityFrameworkCore;

namespace _6_1.Models
{
    public class CSharpContext : DbContext
    {
        public CSharpContext(DbContextOptions<CSharpContext> options)
            : base(options)
        { }

        public DbSet<CSharpContext> CSharp { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CSharp>().HasData(
                new CSharp
                {
                    CSharpID = 1,
                    Name = "What Is C#",
                    Content = "A general purpose object oriented language that uses a concise" +
                    ", Java like syntax."
                },

                new CSharp
                {
                    CSharpID = 2,
                    Name = "When Was C# Released",
                    Content = "C3 was released in 2002"
                }
            );
        }
    }
}