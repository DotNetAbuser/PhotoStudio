﻿// <auto-generated />
using System;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.GalleryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Galleries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1854),
                            Name = "Работа 1",
                            PicturePath = "Files//Images//GalleryPictures//1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1860),
                            Name = "Работа 2",
                            PicturePath = "Files//Images//GalleryPictures//2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1861),
                            Name = "Работа 3",
                            PicturePath = "Files//Images//GalleryPictures//3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1862),
                            Name = "Работа 4",
                            PicturePath = "Files//Images//GalleryPictures//4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1863),
                            Name = "Работа 5",
                            PicturePath = "Files//Images//GalleryPictures//5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1867),
                            Name = "Работа 6",
                            PicturePath = "Files//Images//GalleryPictures//6.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1868),
                            Name = "Работа 7",
                            PicturePath = "Files//Images//GalleryPictures//7.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1869),
                            Name = "Работа 8",
                            PicturePath = "Files//Images//GalleryPictures//8.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(1870),
                            Name = "Работа 9",
                            PicturePath = "Files//Images//GalleryPictures//9.jpg"
                        });
                });

            modelBuilder.Entity("Domain.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Arrived")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(9736),
                            Name = "Guest"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(9758),
                            Name = "Operator"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 517, DateTimeKind.Utc).AddTicks(9762),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Domain.Entities.SessionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e8ed760-6bce-464e-b8da-bba6780afdcb"),
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 518, DateTimeKind.Utc).AddTicks(6368),
                            Email = "samatguest@gmail.com",
                            FirstName = "Самат",
                            LastName = "Хасипов",
                            MiddleName = "Гость",
                            PasswordHash = "$2a$11$64MMqSwa3TBL/5kvn9toMe52Ik8jbnRoV1Y0A5ewuP0e8F6.dRxS6",
                            PhoneNumber = "+791234567890",
                            RoleId = 1
                        },
                        new
                        {
                            Id = new Guid("3c96c3d4-7ef0-43d7-ab2e-df0e302aa0c3"),
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 666, DateTimeKind.Utc).AddTicks(2013),
                            Email = "samatoperator@gmail.com",
                            FirstName = "Даниил",
                            LastName = "Устюшкин",
                            MiddleName = "Оператор",
                            PasswordHash = "$2a$11$3uZjkeDa5l8Ws8isGXTjSe6Qrsyg0dIlOfr37PlHZH4hAG6UAWC9G",
                            PhoneNumber = "+791234567891",
                            RoleId = 2
                        },
                        new
                        {
                            Id = new Guid("5da9f4ab-52bd-4a6d-8a08-ef5423bc1815"),
                            Created = new DateTime(2024, 5, 29, 22, 1, 48, 815, DateTimeKind.Utc).AddTicks(5300),
                            Email = "samatadmin@gmail.com",
                            FirstName = "Даниил",
                            LastName = "Устюшкин",
                            MiddleName = "Админ",
                            PasswordHash = "$2a$11$O4349GFBbmTmzY.2MnS5Tuio1fOf8gMaqFSmWEhwHbhRcWOOaW3.2",
                            PhoneNumber = "+791234567892",
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.OrderEntity", b =>
                {
                    b.HasOne("Domain.Entities.UserEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.SessionEntity", b =>
                {
                    b.HasOne("Domain.Entities.UserEntity", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.HasOne("Domain.Entities.RoleEntity", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Entities.RoleEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserEntity", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
