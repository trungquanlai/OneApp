using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using PosRest.Models;

namespace PosRest.Data
{
    public class OneAppContext : DbContext
    {
        public OneAppContext(DbContextOptions<OneAppContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Invoice>().ToTable("Invoice");
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Table>().ToTable("Table");
            modelBuilder.Entity<User>().ToTable("User");
        }

    }
}
