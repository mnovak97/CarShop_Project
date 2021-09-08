using CarShop_REST_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop_REST_API.Context
{
    public class DatabaseContext : DbContext
    {
        private string myConnectionString = "Data Source=DESKTOP-7T2L7JN;Initial Catalog = CarShop_Database;Integrated Security = True";

        public DbSet<User> Users { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkOrdersItems> WorkOrdersItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(myConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<WorkOrdersItems>()
                .HasKey(wi => new { wi.WorkOrderID, wi.ItemID });
            modelBuilder.Entity<WorkOrdersItems>()
                 .HasOne(wi => wi.WorkOrder)
                 .WithMany(w => w.WorkOrdersItems)
                 .HasForeignKey(wi => wi.WorkOrderID);
            modelBuilder.Entity<WorkOrdersItems>()
                .HasOne(wi => wi.Item)
                .WithMany(i => i.WorkOrdersItems)
                .HasForeignKey(wi => wi.ItemID);

            modelBuilder.Entity<WorkOrder>()
                .HasOne(u => u.User)
                .WithMany(wo => wo.WorkOrders);

            modelBuilder.Entity<WorkOrder>()
               .HasOne(b => b.Buyer)
               .WithMany(wo => wo.WorkOrders);
        }

    }
}
