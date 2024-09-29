using EF_create_product.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_create_product.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Task_Product; Trusted_Connection = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnType("varchar(30)");
            modelBuilder.Entity<Product>().Property(p => p.Description).HasColumnType("varchar(60)");
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(12,2)");
        }

        public DbSet<Product> Products { get; set; }
    }
}
