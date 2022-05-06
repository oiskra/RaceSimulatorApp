﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektSemestralnyOOP.DBcontext;

namespace ProjektSemestralnyOOP.Migrations
{
    [DbContext(typeof(RacingDBContext))]
    partial class RacingDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RacerOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RacerTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Winner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.Statistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Acceleration")
                        .HasColumnType("int");

                    b.Property<int>("Braking")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("Grip")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.Car", b =>
                {
                    b.HasOne("ProjektSemestralnyOOP.MVVM.Model.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.Statistic", b =>
                {
                    b.HasOne("ProjektSemestralnyOOP.MVVM.Model.Car", "Car")
                        .WithOne("Statistics")
                        .HasForeignKey("ProjektSemestralnyOOP.MVVM.Model.Statistic", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.Car", b =>
                {
                    b.Navigation("Statistics");
                });

            modelBuilder.Entity("ProjektSemestralnyOOP.MVVM.Model.User", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
