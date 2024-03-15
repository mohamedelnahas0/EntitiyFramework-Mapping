﻿// <auto-generated />
using System;
using ITI_Map.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ITI_Map.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    [Migration("20240224183534_AddICourseTable")]
    partial class AddICourseTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ITI_Map.Entites.Course_", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Description")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("ITI_Map.Entites.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("instructorID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("instructorID")
                        .IsUnique();

                    b.ToTable("departments");
                });

            modelBuilder.Entity("ITI_Map.Entites.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<int>("Hour_rate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("departmentsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("ITI_Map.Entites.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departmentsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("departmentsId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("ITI_Map.Entites.Departments", b =>
                {
                    b.HasOne("ITI_Map.Entites.Instructor", "instructor")
                        .WithOne("departments")
                        .HasForeignKey("ITI_Map.Entites.Departments", "instructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("ITI_Map.Entites.Student", b =>
                {
                    b.HasOne("ITI_Map.Entites.Departments", "departments")
                        .WithMany()
                        .HasForeignKey("departmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("departments");
                });

            modelBuilder.Entity("ITI_Map.Entites.Instructor", b =>
                {
                    b.Navigation("departments")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
