﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnionArcProject.Infrastruct.Data.DBContext;

#nullable disable

namespace OnionArcProject.Infrastruct.Data.Migrations
{
    [DbContext(typeof(SimpleTestDbContext))]
    [Migration("20240208124720_AutoGenerateGuid")]
    partial class AutoGenerateGuid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OnionArcProject.Domain.Models.Gpu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("Frequency")
                        .HasColumnType("real");

                    b.Property<Guid>("VenderId")
                        .HasColumnType("uuid");

                    b.HasKey("Id")
                        .HasName("gpus_pkey");

                    b.HasIndex("VenderId");

                    b.ToTable("gpus", (string)null);
                });

            modelBuilder.Entity("OnionArcProject.Domain.Models.Vender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("MarketShare")
                        .HasColumnType("real")
                        .HasColumnName("MarketShare");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id")
                        .HasName("venders_pkey");

                    b.ToTable("venders", (string)null);
                });

            modelBuilder.Entity("OnionArcProject.Domain.Models.Gpu", b =>
                {
                    b.HasOne("OnionArcProject.Domain.Models.Vender", "Vender")
                        .WithMany("Gpus")
                        .HasForeignKey("VenderId")
                        .IsRequired()
                        .HasConstraintName("gpus_VenderId_fkey");

                    b.Navigation("Vender");
                });

            modelBuilder.Entity("OnionArcProject.Domain.Models.Vender", b =>
                {
                    b.Navigation("Gpus");
                });
#pragma warning restore 612, 618
        }
    }
}