using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    Category = "Action",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                },
                new Movie
                {
                    Category = "SciFi",
                    Title = "The Martian",
                    Year = 2015,
                    Director = "Ridley Scott",
                    Rating = "PG-13",
                    Edited = false
                },
                new Movie
                {
                    Category = "Action",
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                }
                );
        }
    }
}
