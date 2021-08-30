﻿// <auto-generated />
using System;
using CarShop_REST_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarShop_REST_API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210830160754_SeedUserTable")]
    partial class SeedUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        });
                });

            modelBuilder.Entity("CarShop_REST_API.Model.WorkOrder", b =>
                {
                    b.Property<int>("IDWorkOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuyerIDBuyer")
                        .HasColumnType("int");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

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

            modelBuilder.Entity("ItemWorkOrder", b =>
                {
                    b.Property<int>("ItemsIDItem")
                        .HasColumnType("int");

                    b.Property<int>("WorkOrdersIDWorkOrder")
                        .HasColumnType("int");

                    b.HasKey("ItemsIDItem", "WorkOrdersIDWorkOrder");

                    b.HasIndex("WorkOrdersIDWorkOrder");

                    b.ToTable("ItemWorkOrder");
                });

            modelBuilder.Entity("CarShop_REST_API.Model.WorkOrder", b =>
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

            modelBuilder.Entity("ItemWorkOrder", b =>
                {
                    b.HasOne("CarShop_REST_API.Model.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsIDItem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarShop_REST_API.Model.WorkOrder", null)
                        .WithMany()
                        .HasForeignKey("WorkOrdersIDWorkOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
