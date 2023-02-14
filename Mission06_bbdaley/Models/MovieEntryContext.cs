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

        public DbSet<MovieEntry> responses { get; set; }
    }
}
