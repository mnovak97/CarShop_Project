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
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptWorkOrders> ReceiptWorkOrders { get; set; }
        public DbSet<Model.Task> Tasks { get; set; }
        public DbSet<UserMobile> UsersMobile { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<PickUp> PickUps { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(myConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<ReceiptWorkOrders>()
                .HasKey(rw => new { rw.ReceiptID, rw.WorkOrderID });
            modelBuilder.Entity<ReceiptWorkOrders>()
                .HasOne(r => r.Receipt)
                .WithMany(rw => rw.ReceiptWorkOrders)
                .HasForeignKey(r => r.ReceiptID);
            modelBuilder.Entity<ReceiptWorkOrders>()
                .HasOne(w => w.WorkOrder)
                .WithMany(rw => rw.ReceiptWorkOrders)
                .HasForeignKey(w => w.WorkOrderID);
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
            modelBuilder.Entity<Buyer>()
                .HasMany(wo => wo.WorkOrders)
                .WithOne(b => b.Buyer);
            modelBuilder.Entity<User>()
                .HasMany(wo => wo.WorkOrders)
                .WithOne(u => u.User);
            modelBuilder.Entity<WorkOrder>()
                .HasOne(u => u.User)
                .WithMany(wo => wo.WorkOrders);
            modelBuilder.Entity<WorkOrder>()
               .HasOne(b => b.Buyer)
               .WithMany(wo => wo.WorkOrders);
        }

    }
}
