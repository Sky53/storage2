using Microsoft.EntityFrameworkCore;
using storage2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Services.DAL
{
    public class StorageContext : DbContext
    {
        public DbSet<User> users {get; set;}
        public DbSet<Product> products {get; set;}
        public DbSet<Order> orders {get; set;}

        public StorageContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=testdb;Username=postgres;Password=root");
        }
    }
}
