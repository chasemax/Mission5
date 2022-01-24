﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220124173337_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.Movie", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Title");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            Title = "Inception",
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Year = 2010
                        },
                        new
                        {
                            Title = "The Martian",
                            Category = "SciFi",
                            Director = "Ridley Scott",
                            Edited = false,
                            Rating = "PG-13",
                            Year = 2015
                        },
                        new
                        {
                            Title = "Batman Begins",
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Edited = false,
                            Rating = "PG-13",
                            Year = 2005
                        });
                });
#pragma warning restore 612, 618
        }
    }
}