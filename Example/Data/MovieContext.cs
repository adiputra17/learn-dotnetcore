using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Example.Models;

    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Example.Models.Movie> Movie { get; set; }
    }
