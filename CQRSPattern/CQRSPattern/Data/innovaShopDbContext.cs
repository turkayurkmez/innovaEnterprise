using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CQRSPattern.Models;

namespace CQRSPattern.Data
{
    public partial class innovaShopDbContext : DbContext
    {
        public innovaShopDbContext()
        {
        }

        public innovaShopDbContext(DbContextOptions<innovaShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=innovaShopDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
