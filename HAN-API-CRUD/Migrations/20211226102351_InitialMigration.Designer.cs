﻿// <auto-generated />
using System;
using HAN_API_CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HAN_API_CRUD.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211226102351_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HAN_API_CRUD.Data.activePowerQ1Q4Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("activePowerQ1Q4")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("activePowerQ1Q4Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.activePowerQ2Q3Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("activePowerQ2Q3")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("activePowerQ2Q3Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.ampereIL1Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ampereIL1")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ampereIL1Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.ampereIL3Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ampereIL3")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ampereIL3Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.HANDataClasses", b =>
                {
                    b.Property<Guid>("HANId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("activePowerQ1Q4Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("activePowerQ2Q3Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ampereIL1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ampereIL3Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("dateTimePoll")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("reactivePowerQ1Q2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("reactivePowerQ3Q4Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("versionIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("voltUL1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("voltUL2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("voltUL3Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HANId");

                    b.HasIndex("activePowerQ1Q4Id");

                    b.HasIndex("activePowerQ2Q3Id");

                    b.HasIndex("ampereIL1Id");

                    b.HasIndex("ampereIL3Id");

                    b.HasIndex("reactivePowerQ1Q2Id");

                    b.HasIndex("reactivePowerQ3Q4Id");

                    b.HasIndex("voltUL1Id");

                    b.HasIndex("voltUL2Id");

                    b.HasIndex("voltUL3Id");

                    b.ToTable("HANData");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.reactivePowerQ1Q2Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("reactivePowerQ1Q2")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("reactivePowerQ1Q2Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.reactivePowerQ3Q4Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("reactivePowerQ3Q4")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("reactivePowerQ3Q4Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.voltUL1Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("voltUL1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("voltUL1Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.voltUL2Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("voltUL2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("voltUL2Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.voltUL3Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("voltUL3")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("voltUL3Object");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.HANDataClasses", b =>
                {
                    b.HasOne("HAN_API_CRUD.Data.activePowerQ1Q4Object", "activePowerQ1Q4")
                        .WithMany()
                        .HasForeignKey("activePowerQ1Q4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.activePowerQ2Q3Object", "activePowerQ2Q3")
                        .WithMany()
                        .HasForeignKey("activePowerQ2Q3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.ampereIL1Object", "ampereIL1")
                        .WithMany()
                        .HasForeignKey("ampereIL1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.ampereIL3Object", "ampereIL3")
                        .WithMany()
                        .HasForeignKey("ampereIL3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.reactivePowerQ1Q2Object", "reactivePowerQ1Q2")
                        .WithMany()
                        .HasForeignKey("reactivePowerQ1Q2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.reactivePowerQ3Q4Object", "reactivePowerQ3Q4")
                        .WithMany()
                        .HasForeignKey("reactivePowerQ3Q4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.voltUL1Object", "voltUL1")
                        .WithMany()
                        .HasForeignKey("voltUL1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.voltUL2Object", "voltUL2")
                        .WithMany()
                        .HasForeignKey("voltUL2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.voltUL3Object", "voltUL3")
                        .WithMany()
                        .HasForeignKey("voltUL3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("activePowerQ1Q4");

                    b.Navigation("activePowerQ2Q3");

                    b.Navigation("ampereIL1");

                    b.Navigation("ampereIL3");

                    b.Navigation("reactivePowerQ1Q2");

                    b.Navigation("reactivePowerQ3Q4");

                    b.Navigation("voltUL1");

                    b.Navigation("voltUL2");

                    b.Navigation("voltUL3");
                });
#pragma warning restore 612, 618
        }
    }
}
