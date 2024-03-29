﻿// <auto-generated />
using System;
using ECommerce.Data.Entiry;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerce.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommerce.Data.Entiry.Masters.CategoryMaster", b =>
                {
                    b.Property<Guid>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ADate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeleteFlag")
                        .HasColumnType("int");

                    b.Property<Guid>("DeptID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("MDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrgID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryID");

                    b.ToTable("CategoryMaster");
                });

            modelBuilder.Entity("ECommerce.Data.Entiry.Masters.DepartmentMaster", b =>
                {
                    b.Property<Guid>("DeptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ADate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeleteFlag")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrgID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DeptID");

                    b.ToTable("DepartmentMaster");
                });

            modelBuilder.Entity("ECommerce.Data.Entiry.Masters.ItemMaster", b =>
                {
                    b.Property<Guid>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ADate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DeleteFlag")
                        .HasColumnType("int");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("MRP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("OrgID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("SalesRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemID");

                    b.ToTable("ItemMaster");
                });

            modelBuilder.Entity("ECommerce.Data.Entiry.Masters.ItemsDiscountDetails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ItemID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("ItemsDiscountDetails");
                });

            modelBuilder.Entity("ECommerce.Data.Entiry.Masters.ItemsImagesDetails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImagesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ItemID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("ItemsImagesDetails");
                });

            modelBuilder.Entity("ECommerce.Data.Entiry.Masters.UnitMaster", b =>
                {
                    b.Property<Guid>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ADate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeleteFlag")
                        .HasColumnType("int");

                    b.Property<DateTime>("MDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrgID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UnitDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UnitID");

                    b.ToTable("UnitMaster");
                });
#pragma warning restore 612, 618
        }
    }
}
