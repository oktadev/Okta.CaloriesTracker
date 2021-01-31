﻿// <auto-generated />
using System;
using CaloriesTracker.WebForms.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaloriesTracker.WebForms.Migrations
{
    [DbContext(typeof(CaloriesContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("CaloriesTracker.WebForms.Data.CalorieDiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ExerciseId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FoodId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("FoodId");

                    b.ToTable("CalorieDiaries");
                });

            modelBuilder.Entity("CaloriesTracker.WebForms.Data.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("CaloriesTracker.WebForms.Data.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("CaloriesTracker.WebForms.Data.CalorieDiary", b =>
                {
                    b.HasOne("CaloriesTracker.WebForms.Data.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId");

                    b.HasOne("CaloriesTracker.WebForms.Data.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");
                });
#pragma warning restore 612, 618
        }
    }
}
