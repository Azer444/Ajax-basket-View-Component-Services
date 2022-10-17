﻿// <auto-generated />
using System;
using Fiorello.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiorello.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221017125155_CreateTable")]
    partial class CreateTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiorello.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 10, 17, 16, 51, 55, 296, DateTimeKind.Local).AddTicks(1332),
                            Desc = "Desc1",
                            Image = "blog-feature-img-1.jpg",
                            IsDeleted = false,
                            Title = "Blog1"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 10, 17, 16, 51, 55, 297, DateTimeKind.Local).AddTicks(5596),
                            Desc = "Desc2",
                            Image = "blog-feature-img-3.jpg",
                            IsDeleted = false,
                            Title = "Blog2"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 10, 17, 16, 51, 55, 297, DateTimeKind.Local).AddTicks(5645),
                            Desc = "Desc3",
                            Image = "blog-feature-img-4.jpg",
                            IsDeleted = false,
                            Title = "Blog3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}