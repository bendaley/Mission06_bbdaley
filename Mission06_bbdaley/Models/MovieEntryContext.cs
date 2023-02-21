using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_bbdaley.Models
{
    public class MovieEntryContext : DbContext
    {
        // Constructor
        public MovieEntryContext (DbContextOptions<MovieEntryContext> options) : base (options)
        {
            // Leave blank for now
        }

        public DbSet<MovieEntry> Responses { get; set; }
        public DbSet<Category> Category { get; set; }

        // seed data

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Romance" },
                new Category { CategoryID = 4, CategoryName = "Sports" },
                new Category { CategoryID = 5, CategoryName = "Fantasy" }
                );


            
            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                { 
                    CategoryID = 3,
                    Title = "The Proposal",
                    Year = 1980,
                    Director = "Joseph B Worthin",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "David A Bednar",
                    Notes = "Best movie created ever"

                },

                new MovieEntry
                {
                    CategoryID = 5,
                    Title = "Harry Potter",
                    Year = 2007,
                    Director = "JK Rowling",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "Pooh Bear",
                    Notes = "Everything is sweeter with honey"
                },

                new MovieEntry
                {
                    CategoryID = 4,
                    Title = "Forever Strong",
                    Year = 2013,
                    Director = "Kevin Holt",
                    Rating = "R",
                    Edited = true,
                    Lent = "Dee Dee Holt",
                    Notes = "Love the message"

                }
            );
        }
    }
}
