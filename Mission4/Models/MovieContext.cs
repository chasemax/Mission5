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

        public DbSet<Movie> movies { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    CategoryId = 1,
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                },
                new Movie
                {
                    CategoryId = 2,
                    Title = "The Martian",
                    Year = 2015,
                    Director = "Ridley Scott",
                    Rating = "PG-13",
                    Edited = false
                },
                new Movie
                {
                    CategoryId = 1,
                    Title = "Batman Begins",
                    Year = 2005,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                }
                );

            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "SciFi"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Romance"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Comedy"
                }
                );
        }
    }
}
