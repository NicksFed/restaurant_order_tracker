﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tracker.Models;

#nullable disable

namespace Tracker.Migrations
{
    [DbContext(typeof(TrackerContext))]
    partial class TrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Tracker.Models.Alcohol", b =>
                {
                    b.Property<int>("AlcoholId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AlcoholAmount")
                        .HasColumnType("longtext");

                    b.Property<string>("AlcoholType")
                        .HasColumnType("longtext");

                    b.HasKey("AlcoholId");

                    b.ToTable("Alcohols");
                });

            modelBuilder.Entity("Tracker.Models.AlcoholOrder", b =>
                {
                    b.Property<int>("AlcoholOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AlcAndRestaurant")
                        .HasColumnType("longtext");

                    b.Property<int>("AlcoholId")
                        .HasColumnType("int");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("AlcoholOrderId");

                    b.HasIndex("AlcoholId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("AlcoholOrders");
                });

            modelBuilder.Entity("Tracker.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AlcoholOrderId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryName")
                        .HasColumnType("longtext");

                    b.Property<int>("MeatOrderId")
                        .HasColumnType("int");

                    b.Property<int>("VegetableOrderId")
                        .HasColumnType("int");

                    b.HasKey("DeliveryId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Tracker.Models.Meat", b =>
                {
                    b.Property<int>("MeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MeatAmount")
                        .HasColumnType("longtext");

                    b.Property<string>("MeatType")
                        .HasColumnType("longtext");

                    b.HasKey("MeatId");

                    b.ToTable("Meats");
                });

            modelBuilder.Entity("Tracker.Models.MeatOrder", b =>
                {
                    b.Property<int>("MeatOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<string>("MeatAndRestaurant")
                        .HasColumnType("longtext");

                    b.Property<int>("MeatId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("MeatOrderId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("MeatId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MeatOrders");
                });

            modelBuilder.Entity("Tracker.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Tracker.Models.Vegetable", b =>
                {
                    b.Property<int>("VegetableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("VegetableAmount")
                        .HasColumnType("longtext");

                    b.Property<string>("VegetableType")
                        .HasColumnType("longtext");

                    b.HasKey("VegetableId");

                    b.ToTable("Vegetables");
                });

            modelBuilder.Entity("Tracker.Models.VegetableOrder", b =>
                {
                    b.Property<int>("VegetableOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("VegAndRestaurant")
                        .HasColumnType("longtext");

                    b.Property<int>("VegetableId")
                        .HasColumnType("int");

                    b.HasKey("VegetableOrderId");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("VegetableId");

                    b.ToTable("VegetableOrders");
                });

            modelBuilder.Entity("Tracker.Models.AlcoholOrder", b =>
                {
                    b.HasOne("Tracker.Models.Alcohol", "Alcohol")
                        .WithMany("JoinAlcoholEntities")
                        .HasForeignKey("AlcoholId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tracker.Models.Delivery", null)
                        .WithMany("JoinAlcoholEntities")
                        .HasForeignKey("DeliveryId");

                    b.HasOne("Tracker.Models.Restaurant", "Restaurant")
                        .WithMany("JoinAlcoholEntities")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alcohol");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Tracker.Models.MeatOrder", b =>
                {
                    b.HasOne("Tracker.Models.Delivery", null)
                        .WithMany("JoinMeatOrderEntities")
                        .HasForeignKey("DeliveryId");

                    b.HasOne("Tracker.Models.Meat", "Meat")
                        .WithMany("JoinMeatOrderEntities")
                        .HasForeignKey("MeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tracker.Models.Restaurant", "Restaurant")
                        .WithMany("JoinMeatOrderEntities")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meat");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Tracker.Models.VegetableOrder", b =>
                {
                    b.HasOne("Tracker.Models.Delivery", null)
                        .WithMany("JoinVegetableOrderEntities")
                        .HasForeignKey("DeliveryId");

                    b.HasOne("Tracker.Models.Restaurant", "Restaurant")
                        .WithMany("JoinVegetableOrderEntities")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tracker.Models.Vegetable", "Vegetable")
                        .WithMany("JoinVegetableOrderEntities")
                        .HasForeignKey("VegetableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("Vegetable");
                });

            modelBuilder.Entity("Tracker.Models.Alcohol", b =>
                {
                    b.Navigation("JoinAlcoholEntities");
                });

            modelBuilder.Entity("Tracker.Models.Delivery", b =>
                {
                    b.Navigation("JoinAlcoholEntities");

                    b.Navigation("JoinMeatOrderEntities");

                    b.Navigation("JoinVegetableOrderEntities");
                });

            modelBuilder.Entity("Tracker.Models.Meat", b =>
                {
                    b.Navigation("JoinMeatOrderEntities");
                });

            modelBuilder.Entity("Tracker.Models.Restaurant", b =>
                {
                    b.Navigation("JoinAlcoholEntities");

                    b.Navigation("JoinMeatOrderEntities");

                    b.Navigation("JoinVegetableOrderEntities");
                });

            modelBuilder.Entity("Tracker.Models.Vegetable", b =>
                {
                    b.Navigation("JoinVegetableOrderEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
