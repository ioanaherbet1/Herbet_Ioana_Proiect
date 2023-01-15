﻿// <auto-generated />
using System;
using Herbet_Ioana_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HerbetIoanaProiect.Migrations
{
    [DbContext(typeof(DressesContext))]
    [Migration("20230114182111_Shop")]
    partial class Shop
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.AvailableDress", b =>
                {
                    b.Property<int>("DressID")
                        .HasColumnType("int");

                    b.Property<int>("ShopID")
                        .HasColumnType("int");

                    b.HasKey("DressID", "ShopID");

                    b.HasIndex("ShopID");

                    b.ToTable("AvailableDress", (string)null);
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Designer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Designer", (string)null);
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Dress", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DesignerID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DesignerID");

                    b.ToTable("Dress", (string)null);
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("DressID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("DressID");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Shop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Shop", (string)null);
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.AvailableDress", b =>
                {
                    b.HasOne("Herbet_Ioana_Proiect.Models.Dress", "Dress")
                        .WithMany("AvailableDresses")
                        .HasForeignKey("DressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Herbet_Ioana_Proiect.Models.Shop", "Shop")
                        .WithMany("AvailableDresses")
                        .HasForeignKey("ShopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dress");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Dress", b =>
                {
                    b.HasOne("Herbet_Ioana_Proiect.Models.Designer", "Designer")
                        .WithMany("Dresses")
                        .HasForeignKey("DesignerID");

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Order", b =>
                {
                    b.HasOne("Herbet_Ioana_Proiect.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Herbet_Ioana_Proiect.Models.Dress", "Dress")
                        .WithMany("Orders")
                        .HasForeignKey("DressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Dress");
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Designer", b =>
                {
                    b.Navigation("Dresses");
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Dress", b =>
                {
                    b.Navigation("AvailableDresses");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Herbet_Ioana_Proiect.Models.Shop", b =>
                {
                    b.Navigation("AvailableDresses");
                });
#pragma warning restore 612, 618
        }
    }
}