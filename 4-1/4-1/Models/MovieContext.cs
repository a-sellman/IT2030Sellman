﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _4_1.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = "A", Name = "Action" },
                new Genre { GenreID = "C", Name = "Comedy" },
                new Genre { GenreID = "D", Name = "Drama" },
                new Genre { GenreID = "H", Name = "Horror" },
                new Genre { GenreID = "M", Name = "Musical" },
                new Genre { GenreID = "R", Name = "RomCom" },
                new Genre { GenreID = "S", Name = "SciFi" }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieID = 1, Name = "Casablanca", Year = 1942, Rating = 4, GenreID = "D" },
                new Movie { MovieID = 2, Name = "Wonder Woman", Year = 2017, Rating = 5, GenreID = "A" },
               new Movie { MovieID = 1, Name = "Moonstruck", Year = 1988, Rating = 5, GenreID = "R" }
            );
        }
    }
}

