﻿// <auto-generated />
using System;
using BestRestaurants.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BestRestaurants.Migrations
{
    [DbContext(typeof(BestRestaurantsContext))]
    partial class BestRestaurantsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BestRestaurants.Models.Cuisine", b =>
                {
                    b.Property<int>("CuisineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CuisineId");

                    b.ToTable("Cuisines");
                });

            modelBuilder.Entity("BestRestaurants.Models.CuisineRestaurant", b =>
                {
                    b.Property<int>("CuisineRestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CuisineId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("CuisineRestaurantId");

                    b.HasIndex("CuisineId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("CuisineRestaurants");
                });

            modelBuilder.Entity("BestRestaurants.Models.Diner", b =>
                {
                    b.Property<int>("DinerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("DinerAllergies")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("DinerName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DinerId");

                    b.ToTable("Diners");
                });

            modelBuilder.Entity("BestRestaurants.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("BestRestaurants.Models.CuisineRestaurant", b =>
                {
                    b.HasOne("BestRestaurants.Models.Cuisine", "Cuisine")
                        .WithMany("JoinEntities")
                        .HasForeignKey("CuisineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BestRestaurants.Models.Restaurant", "Restaurant")
                        .WithMany("JoinEntities")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuisine");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("BestRestaurants.Models.Cuisine", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("BestRestaurants.Models.Restaurant", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
