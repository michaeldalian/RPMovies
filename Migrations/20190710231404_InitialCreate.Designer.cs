﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Migrations
{
    [DbContext(typeof(RazorPagesMovieContext))]
    [Migration("20190710231404_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesMovie.Models.MyClient", b =>
                {
                    b.Property<int>("MyClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("TotalRent");

                    b.HasKey("MyClientID");

                    b.ToTable("MyClient");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.MyMovie", b =>
                {
                    b.Property<int>("MyMovieID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("MyMovieID");

                    b.ToTable("MyMovie");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.MyMovieRent", b =>
                {
                    b.Property<int>("MyMovieRentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MyClientID");

                    b.Property<int>("MyMovieID");

                    b.Property<DateTime>("RentDate");

                    b.HasKey("MyMovieRentID");

                    b.HasIndex("MyClientID");

                    b.ToTable("MyMovieRent");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.MyMovieRent", b =>
                {
                    b.HasOne("RazorPagesMovie.Models.MyClient")
                        .WithMany("MyMovieRent")
                        .HasForeignKey("MyClientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}