﻿// <auto-generated />
using System;
using ApiProject.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProject.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220105125437_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ApiProject.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bilgisayar"
                        });
                });

            modelBuilder.Entity("ApiProject.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("İmagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 1, 5, 15, 54, 37, 458, DateTimeKind.Local).AddTicks(3716),
                            Name = "Samsung S6",
                            Price = 5000m,
                            Stock = 45,
                            İmagePath = "aieaieaieaieaiea"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 1, 5, 15, 54, 37, 458, DateTimeKind.Local).AddTicks(4965),
                            Name = "Samsung S7",
                            Price = 6000m,
                            Stock = 55,
                            İmagePath = "eeee"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 1, 5, 15, 54, 37, 458, DateTimeKind.Local).AddTicks(4969),
                            Name = "Samsung S8",
                            Price = 7000m,
                            Stock = 55,
                            İmagePath = "iiii"
                        });
                });

            modelBuilder.Entity("ApiProject.Data.Product", b =>
                {
                    b.HasOne("ApiProject.Data.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiProject.Data.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
