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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieEntry>().HasData(

                new MovieEntry
                { 
                    Category = "Romance",
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
                    Category = "Fantasy",
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
                    Category = "Sports",
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
