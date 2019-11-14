using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationHW9.Models;

namespace WebApplicationHW9.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { FullName = "Alex Petrovich", Age = 15 },
                new User { FullName = "Alya Smirnova", Age = 19 },
                new User { FullName = "Ivan Ivanov", Age = 31 },
                new User { FullName = "Olya Prosto", Age = 13 }
                );
        }
    }
}
