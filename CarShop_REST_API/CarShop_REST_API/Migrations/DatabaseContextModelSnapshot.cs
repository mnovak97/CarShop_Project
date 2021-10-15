﻿// <auto-generated />
using System;
using CarShop_REST_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarShop_REST_API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarShop_REST_API.Model.Buyer", b =>
                {
                    b.Property<int>("IDBuyer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OIB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDBuyer");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Item", b =>
                {
                    b.Property<int>("IDItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDItem");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Receipt", b =>
                {
                    b.Property<int>("IDReceipt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuyerIDBuyer")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfReceipt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int?>("UserIDUser")
                        .HasColumnType("int");

                    b.HasKey("IDReceipt");

                    b.HasIndex("BuyerIDBuyer");

                    b.HasIndex("UserIDUser");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.ReceiptWorkOrders", b =>
                {
                    b.Property<int>("ReceiptID")
                        .HasColumnType("int");

                    b.Property<int>("WorkOrderID")
                        .HasColumnType("int");

                    b.HasKey("ReceiptID", "WorkOrderID");

                    b.HasIndex("WorkOrderID");

                    b.ToTable("ReceiptWorkOrders");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Task", b =>
                {
                    b.Property<int>("IDTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<int?>("UserIDUser")
                        .HasColumnType("int");

                    b.Property<int?>("WorkOrderIDWorkOrder")
                        .HasColumnType("int");

                    b.HasKey("IDTask");

                    b.HasIndex("UserIDUser");

                    b.HasIndex("WorkOrderIDWorkOrder");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.User", b =>
                {
                    b.Property<int>("IDUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDUser");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IDUser = 1,
                            Email = "ipad3monkey@gmail.com",
                            Password = "martin123",
                            Role = 0,
                            Username = "MartyParty97"
                        },
                        new
                        {
                            IDUser = 2,
                            Email = "marko@gmail.com",
                            Password = "marko123",
                            Role = 1,
                            Username = "Marko"
                        });
                });

            modelBuilder.Entity("CarShop_REST_API.Model.UserMobile", b =>
                {
                    b.Property<int>("IDUserMobile")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDUserMobile");

                    b.ToTable("UsersMobile");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.WorkOrder", b =>
                {
                    b.Property<int>("IDWorkOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Assigned")
                        .HasColumnType("bit");

                    b.Property<int?>("BuyerIDBuyer")
                        .HasColumnType("int");

                    b.Property<string>("CarType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfWorkOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<long>("Km")
                        .HasColumnType("bigint");

                    b.Property<int>("ManufacturingYear")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationPlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int?>("UserIDUser")
                        .HasColumnType("int");

                    b.Property<bool>("Warranty")
                        .HasColumnType("bit");

                    b.HasKey("IDWorkOrder");

                    b.HasIndex("BuyerIDBuyer");

                    b.HasIndex("UserIDUser");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.WorkOrdersItems", b =>
                {
                    b.Property<int>("WorkOrderID")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("WorkOrderID", "ItemID");

                    b.HasIndex("ItemID");

                    b.ToTable("WorkOrdersItems");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Receipt", b =>
                {
                    b.HasOne("CarShop_REST_API.Model.Buyer", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerIDBuyer");

                    b.HasOne("CarShop_REST_API.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIDUser");

                    b.Navigation("Buyer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.ReceiptWorkOrders", b =>
                {
                    b.HasOne("CarShop_REST_API.Model.Receipt", "Receipt")
                        .WithMany("ReceiptWorkOrders")
                        .HasForeignKey("ReceiptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShop_REST_API.Model.WorkOrder", "WorkOrder")
                        .WithMany("ReceiptWorkOrders")
                        .HasForeignKey("WorkOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receipt");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Task", b =>
                {
                    b.HasOne("CarShop_REST_API.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIDUser");

                    b.HasOne("CarShop_REST_API.Model.WorkOrder", "WorkOrder")
                        .WithMany()
                        .HasForeignKey("WorkOrderIDWorkOrder");

                    b.Navigation("User");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.WorkOrder", b =>
                {
                    b.HasOne("CarShop_REST_API.Model.Buyer", "Buyer")
                        .WithMany("WorkOrders")
                        .HasForeignKey("BuyerIDBuyer");

                    b.HasOne("CarShop_REST_API.Model.User", "User")
                        .WithMany("WorkOrders")
                        .HasForeignKey("UserIDUser");

                    b.Navigation("Buyer");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.WorkOrdersItems", b =>
                {
                    b.HasOne("CarShop_REST_API.Model.Item", "Item")
                        .WithMany("WorkOrdersItems")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShop_REST_API.Model.WorkOrder", "WorkOrder")
                        .WithMany("WorkOrdersItems")
                        .HasForeignKey("WorkOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Buyer", b =>
                {
                    b.Navigation("WorkOrders");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Item", b =>
                {
                    b.Navigation("WorkOrdersItems");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.Receipt", b =>
                {
                    b.Navigation("ReceiptWorkOrders");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.User", b =>
                {
                    b.Navigation("WorkOrders");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.WorkOrder", b =>
                {
                    b.Navigation("ReceiptWorkOrders");

                    b.Navigation("WorkOrdersItems");
                });
#pragma warning restore 612, 618
        }
    }
}
