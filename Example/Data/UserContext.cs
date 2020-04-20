using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Example.Models;

    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<Example.Models.User> User { get; set; }
    }
