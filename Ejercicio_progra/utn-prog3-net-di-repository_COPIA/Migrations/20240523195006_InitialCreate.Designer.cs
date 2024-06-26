﻿// <auto-generated />
using DependencyInjection.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DependencyInjection.Migrations
{
    [DbContext(typeof(CountryDbContext))]
    [Migration("20240523195006_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DependencyInjection.Domain.Country", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Argentina"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Francia"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Brasil"
                        },
                        new
                        {
                            Id = "4",
                            Name = "Chile"
                        },
                        new
                        {
                            Id = "5",
                            Name = "Paraguay"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
