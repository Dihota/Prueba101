﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prpperty_Backend;

#nullable disable

namespace Prpperty_Backend.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20220724170209_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Prpperty_Backend.Models.Owner", b =>
                {
                    b.Property<int>("IdOwner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOwner"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Photo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("IdOwner");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.Property", b =>
                {
                    b.Property<int>("IdProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProperty"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("CodeInternal")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<int?>("ownerIdOwner")
                        .HasColumnType("int");

                    b.HasKey("IdProperty");

                    b.HasIndex("ownerIdOwner");

                    b.ToTable("Propertyes");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.PropertyImage", b =>
                {
                    b.Property<int>("IdPropertyImage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPropertyImage"), 1L, 1);

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Ruta")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("propertyIdProperty")
                        .HasColumnType("int");

                    b.HasKey("IdPropertyImage");

                    b.HasIndex("propertyIdProperty");

                    b.ToTable("PropertyImages");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.PropertyTrace", b =>
                {
                    b.Property<int>("IdPropertyTrace")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPropertyTrace"), 1L, 1);

                    b.Property<DateTime>("DateSale")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Tax")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("Value")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.Property<int?>("propertyIdProperty")
                        .HasColumnType("int");

                    b.HasKey("IdPropertyTrace");

                    b.HasIndex("propertyIdProperty");

                    b.ToTable("PropertyTraces");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.Property", b =>
                {
                    b.HasOne("Prpperty_Backend.Models.Owner", "owner")
                        .WithMany("Properties")
                        .HasForeignKey("ownerIdOwner");

                    b.Navigation("owner");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.PropertyImage", b =>
                {
                    b.HasOne("Prpperty_Backend.Models.Property", "property")
                        .WithMany("propertyImage")
                        .HasForeignKey("propertyIdProperty");

                    b.Navigation("property");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.PropertyTrace", b =>
                {
                    b.HasOne("Prpperty_Backend.Models.Property", "property")
                        .WithMany("propertyTrace")
                        .HasForeignKey("propertyIdProperty");

                    b.Navigation("property");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.Owner", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Prpperty_Backend.Models.Property", b =>
                {
                    b.Navigation("propertyImage");

                    b.Navigation("propertyTrace");
                });
#pragma warning restore 612, 618
        }
    }
}
