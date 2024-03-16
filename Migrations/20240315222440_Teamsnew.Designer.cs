﻿// <auto-generated />
using APIbowlers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIbowlers.Migrations
{
    [DbContext(typeof(BowlerContext))]
    [Migration("20240315222440_Teamsnew")]
    partial class Teamsnew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("APIbowlers.Data.Bowlers", b =>
                {
                    b.Property<int>("BowlerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerZip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BowlerId");

                    b.ToTable("Bowlers");
                });

            modelBuilder.Entity("APIbowlers.Data.Teams", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CaptainID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}