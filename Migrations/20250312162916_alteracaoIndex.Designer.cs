﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaPub.Repository;

#nullable disable

namespace ProvaPub.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20250312162916_alteracaoIndex")]
    partial class alteracaoIndex
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProvaPub.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Shawna Stark"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lucy Erdman"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Randolph Hessel"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Jerome Ernser"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Melissa Swift"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sonia Kuhlman"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Cassandra Quigley"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Donald Gerlach"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Doug Mayert"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Franklin Conn"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Blanca Gleichner"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Blanche Cummings"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Everett Jones"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Nicholas Mante"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Betty Christiansen"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Steve Sawayn"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Glen Kertzmann"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Rudolph Tremblay"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Sergio Johns"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Darrell Stanton"
                        });
                });

            modelBuilder.Entity("ProvaPub.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ProvaPub.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sleek Granite Bacon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Unbranded Frozen Salad"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Unbranded Wooden Tuna"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Licensed Fresh Keyboard"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ergonomic Rubber Computer"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Gorgeous Cotton Computer"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Incredible Rubber Cheese"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Handcrafted Steel Table"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Incredible Plastic Car"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Licensed Rubber Fish"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Unbranded Fresh Ball"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Sleek Concrete Sausages"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Incredible Plastic Salad"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Ergonomic Fresh Fish"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Licensed Fresh Pizza"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Intelligent Steel Table"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Gorgeous Fresh Pizza"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Handcrafted Cotton Chicken"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Practical Steel Bike"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Unbranded Granite Mouse"
                        });
                });

            modelBuilder.Entity("ProvaPub.Models.RandomNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id", "Number")
                        .IsUnique();

                    b.ToTable("Numbers");
                });

            modelBuilder.Entity("ProvaPub.Models.Order", b =>
                {
                    b.HasOne("ProvaPub.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ProvaPub.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
