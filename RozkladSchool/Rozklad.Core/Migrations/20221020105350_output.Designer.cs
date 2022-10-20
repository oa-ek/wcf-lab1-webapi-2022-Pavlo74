﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rozklad.Core;

#nullable disable

namespace Rozklad.Core.Migrations
{
    [DbContext(typeof(RozkladContext))]
    [Migration("20221020105350_output")]
    partial class output
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "aecef6df-2e10-427b-8acc-788e48201185",
                            ConcurrencyStamp = "8a7c18a5-97a8-4071-ab05-5e172af1d4d5",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "7c7a4057-f895-4d6e-9443-90c59b673c48",
                            ConcurrencyStamp = "1212af61-9912-4d6d-ad1e-1c0baadef468",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "b34c3167-b24c-4ce2-b1f2-e6197c4316c9",
                            ConcurrencyStamp = "1d80495b-7d3a-4837-9afa-288e5454ef89",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1f163de8-bda2-4ba7-952e-509fb6b52e89",
                            RoleId = "aecef6df-2e10-427b-8acc-788e48201185"
                        },
                        new
                        {
                            UserId = "1f163de8-bda2-4ba7-952e-509fb6b52e89",
                            RoleId = "7c7a4057-f895-4d6e-9443-90c59b673c48"
                        },
                        new
                        {
                            UserId = "1f163de8-bda2-4ba7-952e-509fb6b52e89",
                            RoleId = "b34c3167-b24c-4ce2-b1f2-e6197c4316c9"
                        },
                        new
                        {
                            UserId = "164e97af-12fb-4721-9f60-959d9242a6d2",
                            RoleId = "7c7a4057-f895-4d6e-9443-90c59b673c48"
                        },
                        new
                        {
                            UserId = "164e97af-12fb-4721-9f60-959d9242a6d2",
                            RoleId = "b34c3167-b24c-4ce2-b1f2-e6197c4316c9"
                        },
                        new
                        {
                            UserId = "ec095578-8b11-41ce-8f8a-58c967d5d6a5",
                            RoleId = "b34c3167-b24c-4ce2-b1f2-e6197c4316c9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Rozklad.Core.Cabinet", b =>
                {
                    b.Property<int>("CabinetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CabinetId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CabinetId");

                    b.ToTable("Cabinets");

                    b.HasData(
                        new
                        {
                            CabinetId = 1,
                            Name = "Географія"
                        },
                        new
                        {
                            CabinetId = 2,
                            Name = "Біологія"
                        },
                        new
                        {
                            CabinetId = 3,
                            Name = "Математика"
                        },
                        new
                        {
                            CabinetId = 4,
                            Name = "Укр мова"
                        },
                        new
                        {
                            CabinetId = 5,
                            Name = "Історія"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            ClassName = "1-A"
                        },
                        new
                        {
                            ClassId = 2,
                            ClassName = "1-B"
                        },
                        new
                        {
                            ClassId = 3,
                            ClassName = "2-A"
                        },
                        new
                        {
                            ClassId = 4,
                            ClassName = "2-B"
                        },
                        new
                        {
                            ClassId = 5,
                            ClassName = "3-A"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"), 1L, 1);

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DayId");

                    b.ToTable("Days");

                    b.HasData(
                        new
                        {
                            DayId = 1,
                            DayName = "Понеділок"
                        },
                        new
                        {
                            DayId = 2,
                            DayName = "Вівторок"
                        },
                        new
                        {
                            DayId = 3,
                            DayName = "Середа"
                        },
                        new
                        {
                            DayId = 4,
                            DayName = "Четвер"
                        },
                        new
                        {
                            DayId = 5,
                            DayName = "Пятниця"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Discipline", b =>
                {
                    b.Property<int>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplineId"), 1L, 1);

                    b.Property<string>("DisciplineName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisciplineId");

                    b.ToTable("Disciplines");

                    b.HasData(
                        new
                        {
                            DisciplineId = 1,
                            DisciplineName = "Географія"
                        },
                        new
                        {
                            DisciplineId = 2,
                            DisciplineName = "Біологія"
                        },
                        new
                        {
                            DisciplineId = 3,
                            DisciplineName = "Математика"
                        },
                        new
                        {
                            DisciplineId = 4,
                            DisciplineName = "Укр мова"
                        },
                        new
                        {
                            DisciplineId = 5,
                            DisciplineName = "Історія"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"), 1L, 1);

                    b.Property<string>("EndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("int");

                    b.Property<string>("StartTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            LessonId = 1,
                            EndTime = "12.45",
                            LessonNumber = 1,
                            StartTime = "12.00"
                        },
                        new
                        {
                            LessonId = 2,
                            EndTime = "13.45",
                            LessonNumber = 2,
                            StartTime = "13.00"
                        },
                        new
                        {
                            LessonId = 3,
                            EndTime = "14.45",
                            LessonNumber = 3,
                            StartTime = "14.00"
                        },
                        new
                        {
                            LessonId = 4,
                            EndTime = "15.45",
                            LessonNumber = 4,
                            StartTime = "15.00 "
                        },
                        new
                        {
                            LessonId = 5,
                            EndTime = "16.45",
                            LessonNumber = 5,
                            StartTime = "16.00"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Timetable", b =>
                {
                    b.Property<int>("TimetableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimetableId"), 1L, 1);

                    b.Property<int>("CabinetId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.HasKey("TimetableId");

                    b.HasIndex("CabinetId");

                    b.HasIndex("ClassId");

                    b.HasIndex("DayId");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("LessonId");

                    b.ToTable("Timetables");

                    b.HasData(
                        new
                        {
                            TimetableId = 1,
                            CabinetId = 1,
                            ClassId = 1,
                            DayId = 1,
                            DisciplineId = 1,
                            LessonId = 1
                        },
                        new
                        {
                            TimetableId = 2,
                            CabinetId = 2,
                            ClassId = 2,
                            DayId = 2,
                            DisciplineId = 2,
                            LessonId = 2
                        });
                });

            modelBuilder.Entity("Rozklad.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1f163de8-bda2-4ba7-952e-509fb6b52e89",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "75a0a232-95a7-4af3-9855-f6b1f49f93f5",
                            Email = "admin@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "ADMIN@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIoQhlYk3XbPVRjIxhAKGCho9Z171yT2rgyOgHTIAzCG94Bg70HK+XJvAWWWQt0DlQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2369c9dc-7e3a-4332-a41d-9f1fa9900b9a",
                            TwoFactorEnabled = false,
                            UserName = "admin@rozkladschool.com"
                        },
                        new
                        {
                            Id = "164e97af-12fb-4721-9f60-959d9242a6d2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1d164465-0d06-45f9-ad5c-d41135d1152f",
                            Email = "moderator@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MODERATOR@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "MODERATOR@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFQSkWI5wZW0OA5UqO7z9ZY76S0lU3kkbHuyDfGjZ2TBnQBnUI11+jJqWAkWs2vxjw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ec1acb67-9a99-4980-a226-59ecb9141ae6",
                            TwoFactorEnabled = false,
                            UserName = "moderator@rozkladschool.com"
                        },
                        new
                        {
                            Id = "ec095578-8b11-41ce-8f8a-58c967d5d6a5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0acb7d05-4c76-482c-adef-98438c291c97",
                            Email = "user@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "USER@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPnPm2rn7uXBNbGQcmIRYRhawoQCL/hxA3/IIgLmBWs0K8DC3QWdWz7j7GWnhWXaVg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3b98ad76-7d8f-42b1-bd35-bc978c5e67d3",
                            TwoFactorEnabled = false,
                            UserName = "user@rozkladschool.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Rozklad.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rozklad.Core.Timetable", b =>
                {
                    b.HasOne("Rozklad.Core.Cabinet", "Cabinet")
                        .WithMany("Timetables")
                        .HasForeignKey("CabinetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Class", "Class")
                        .WithMany("Timetables")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Day", "Day")
                        .WithMany("Timetables")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Discipline", "Discipline")
                        .WithMany("Timetables")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Lesson", "Lesson")
                        .WithMany("Timetables")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabinet");

                    b.Navigation("Class");

                    b.Navigation("Day");

                    b.Navigation("Discipline");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Rozklad.Core.Cabinet", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Class", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Day", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Discipline", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.Navigation("Timetables");
                });
#pragma warning restore 612, 618
        }
    }
}