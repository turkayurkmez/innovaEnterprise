using Microsoft.EntityFrameworkCore;
using OA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.Context
{
    public class InnovaDbContext : DbContext
    {
        public InnovaDbContext()
        {

        }
        public InnovaDbContext(DbContextOptions<InnovaDbContext> options) : base(options)
        {
            //1. ConnectionString
            //2. EF Provider
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Clothes" },
                new Category() { Id = 3, Name = "Books" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1200, Stock = 10, CategoryId = 1 },
                new Product { Id = 2, Name = "Mouse", Price = 50, Stock = 20, CategoryId = 1 },
                new Product { Id = 3, Name = "Keyboard", Price = 100, Stock = 30, CategoryId = 1 },
                new Product { Id = 4, Name = "Monitor", Price = 500, Stock = 40, CategoryId = 1 },
                new Product { Id = 5, Name = "CPU", Price = 1000, Stock = 50, CategoryId = 1 },
                new Product { Id = 6, Name = "RAM", Price = 100, Stock = 60, CategoryId = 1 },
                new Product { Id = 7, Name = "HDD", Price = 500, Stock = 70, CategoryId = 1 },
                new Product { Id = 8, Name = "SSD", Price = 1000, Stock = 80, CategoryId = 1 },
                new Product { Id = 9, Name = "Laptop", Price = 1200, Stock = 90, CategoryId = 2 },
                new Product { Id = 10, Name = "Mouse", Price = 50, Stock = 100, CategoryId = 2 },
                new Product { Id = 11, Name = "Keyboard", Price = 100, Stock = 110, CategoryId = 2 },
                new Product { Id = 12, Name = "Monitor", Price = 500, Stock = 120, CategoryId = 2 },
                new Product { Id = 13, Name = "CPU", Price = 1000, Stock = 130, CategoryId = 2 },
                new Product { Id = 14, Name = "RAM", Price = 100, Stock = 140, CategoryId = 2 },
                new Product { Id = 15, Name = "HDD", Price = 500, Stock = 150, CategoryId = 2 },
                new Product { Id = 16, Name = "SSD", Price = 1000, Stock = 160, CategoryId = 2 },
                new Product { Id = 17, Name = "Laptop", Price = 1200, Stock = 170, CategoryId = 3 });
        }

    }
}