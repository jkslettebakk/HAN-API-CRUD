﻿// <auto-generated />
using System;
using HAN_API_CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HAN_API_CRUD.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HAN_API_CRUD.Data.ActivePowerQ1Q4Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ActivePowerQ1Q4")
                        .HasColumnType("float");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ActivePowerQ1Q4");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.ActivePowerQ2Q3Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ActivePowerQ2Q3")
                        .HasColumnType("float");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ActivePowerQ2Q3");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.AmpereIL1Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AmpereIL1")
                        .HasColumnType("float");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AmpereIL1");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.AmpereIL3Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AmpereIL3")
                        .HasColumnType("float");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AmpereIL3");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.HANData", b =>
                {
                    b.Property<Guid>("HANDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActivePowerQ1Q4Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActivePowerQ2Q3Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AmpereIL1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AmpereIL3Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DateTimePoll")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReactivePowerQ1Q2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReactivePowerQ3Q4Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VersionIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VoltUL1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VoltUL2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VoltUL3Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HANDataId");

                    b.HasIndex("ActivePowerQ1Q4Id");

                    b.HasIndex("ActivePowerQ2Q3Id");

                    b.HasIndex("AmpereIL1Id");

                    b.HasIndex("AmpereIL3Id");

                    b.HasIndex("ReactivePowerQ1Q2Id");

                    b.HasIndex("ReactivePowerQ3Q4Id");

                    b.HasIndex("VoltUL1Id");

                    b.HasIndex("VoltUL2Id");

                    b.HasIndex("VoltUL3Id");

                    b.ToTable("HANData");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.ReactivePowerQ1Q2Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ReactivePowerQ1Q2")
                        .HasColumnType("float");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReactivePowerQ2Q3");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.ReactivePowerQ3Q4Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ReactivePowerQ3Q4")
                        .HasColumnType("float");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReactivePowerQ3Q4");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.VoltUL1Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoltUL1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VoltUL1");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.VoltUL2Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoltUL2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VoltUL2");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.VoltUL3Object", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UoM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VoltUL3")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VoltUL3");
                });

            modelBuilder.Entity("HAN_API_CRUD.Data.HANData", b =>
                {
                    b.HasOne("HAN_API_CRUD.Data.ActivePowerQ1Q4Object", "ActivePowerQ1Q4")
                        .WithMany()
                        .HasForeignKey("ActivePowerQ1Q4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.ActivePowerQ2Q3Object", "ActivePowerQ2Q3")
                        .WithMany()
                        .HasForeignKey("ActivePowerQ2Q3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.AmpereIL1Object", "AmpereIL1")
                        .WithMany()
                        .HasForeignKey("AmpereIL1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.AmpereIL3Object", "AmpereIL3")
                        .WithMany()
                        .HasForeignKey("AmpereIL3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.ReactivePowerQ1Q2Object", "ReactivePowerQ1Q2")
                        .WithMany()
                        .HasForeignKey("ReactivePowerQ1Q2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.ReactivePowerQ3Q4Object", "ReactivePowerQ3Q4")
                        .WithMany()
                        .HasForeignKey("ReactivePowerQ3Q4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.VoltUL1Object", "VoltUL1")
                        .WithMany()
                        .HasForeignKey("VoltUL1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.VoltUL2Object", "VoltUL2")
                        .WithMany()
                        .HasForeignKey("VoltUL2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HAN_API_CRUD.Data.VoltUL3Object", "VoltUL3")
                        .WithMany()
                        .HasForeignKey("VoltUL3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivePowerQ1Q4");

                    b.Navigation("ActivePowerQ2Q3");

                    b.Navigation("AmpereIL1");

                    b.Navigation("AmpereIL3");

                    b.Navigation("ReactivePowerQ1Q2");

                    b.Navigation("ReactivePowerQ3Q4");

                    b.Navigation("VoltUL1");

                    b.Navigation("VoltUL2");

                    b.Navigation("VoltUL3");
                });
#pragma warning restore 612, 618
        }
    }
}
