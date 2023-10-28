﻿// <auto-generated />
using Implement_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Implement_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231028060715_dataSeeding_category")]
    partial class dataSeeding_category
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Implement_Project.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            DisplayOrder = 1,
                            Name = "Mobile"
                        },
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 2,
                            Name = "Fruites"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 2,
                            Name = "Laptops"
                        },
                        new
                        {
                            CategoryId = 4,
                            DisplayOrder = 2,
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 5,
                            DisplayOrder = 2,
                            Name = "Dry Fruites"
                        },
                        new
                        {
                            CategoryId = 6,
                            DisplayOrder = 2,
                            Name = "Pots"
                        },
                        new
                        {
                            CategoryId = 7,
                            DisplayOrder = 2,
                            Name = "Vegitabes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}