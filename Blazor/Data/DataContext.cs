using Microsoft.EntityFrameworkCore;
using System;
using Data.Models;
using System.IO;

namespace Data
{
    public class DataContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=../Data/Database.db");   
        }

    }
}