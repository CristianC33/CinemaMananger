﻿// <auto-generated />
using System;
using CinemaManager.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaManager.DataAccess.Migrations
{
    [DbContext(typeof(FilmManagerDbContext))]
    partial class FilmManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.Film", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FilmDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmGenre")
                       .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.FilmReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<Guid?>("FilmRevId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FilmId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.HasIndex("FilmRevId");

                    b.ToTable("FilmReviews");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.FilmCommentary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Commentary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FilmComId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FilmId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("FilmCommentaries");

                    b.ToTable("FilmCommentary");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.Film", b =>
                {
                    b.HasOne("FilmManager.ApplicationLogic.DataModel.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.FilmReview", b =>
                {
                    b.HasOne("FilmManager.ApplicationLogic.DataModel.Film", null)
                        .WithMany("FilmReviews")
                        .HasForeignKey("FilmId");

                    b.HasOne("FilmManager.ApplicationLogic.DataModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.FilmCommentary", b =>
                {
                    b.HasOne("FilmManager.ApplicationLogic.DataModel.Film", null)
                        .WithMany("FilmCommentaries")
                        .HasForeignKey("FilmId");

                    b.HasOne("FilmManager.ApplicationLogic.DataModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FilmManager.ApplicationLogic.DataModel.User", b =>
                {
                    b.HasOne("FilmManager.ApplicationLogic.DataModel.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmId");
                });
#pragma warning restore 612, 618
        }
    }
}