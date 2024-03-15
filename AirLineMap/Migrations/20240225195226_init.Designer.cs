﻿// <auto-generated />
using AirLineMap.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AirLineMap.Migrations
{
    [DbContext(typeof(Context.HospitalContext))]
    [Migration("20240225195226_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AirLineMap.AitCraft", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Assistant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capactiy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pash_Pilot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("airCrafts");
                });
#pragma warning restore 612, 618
        }
    }
}
