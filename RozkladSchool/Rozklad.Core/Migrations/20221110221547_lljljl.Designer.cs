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
    [Migration("20221110221547_lljljl")]
    partial class lljljl
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
                            Id = "c8fe1408-f0c7-49d6-bcaf-abf24bab7f7e",
                            ConcurrencyStamp = "1abb86f6-d980-4759-9947-64a4ab55ea24",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ea6ee342-44e4-4025-a193-14a089920c1f",
                            ConcurrencyStamp = "8e641602-f33c-4489-9aca-ef7219d69b67",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "170e8f30-0c02-49df-8fa4-2dd6d1ee3d8c",
                            ConcurrencyStamp = "dc7600b8-9c99-4e70-8ae0-6691687d1b48",
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
                            UserId = "68dbf660-8355-41a0-a29d-f0a5274ed506",
                            RoleId = "c8fe1408-f0c7-49d6-bcaf-abf24bab7f7e"
                        },
                        new
                        {
                            UserId = "68dbf660-8355-41a0-a29d-f0a5274ed506",
                            RoleId = "170e8f30-0c02-49df-8fa4-2dd6d1ee3d8c"
                        },
                        new
                        {
                            UserId = "5961e49e-6f36-4166-b80c-d152987bc29c",
                            RoleId = "170e8f30-0c02-49df-8fa4-2dd6d1ee3d8c"
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

                    b.Property<string>("CabinetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomCapacity")
                        .HasColumnType("int");

                    b.HasKey("CabinetId");

                    b.ToTable("Cabinets");

                    b.HasData(
                        new
                        {
                            CabinetId = 1,
                            CabinetName = "GeographyLab",
                            RoomCapacity = 0
                        },
                        new
                        {
                            CabinetId = 2,
                            CabinetName = "BiologyLab",
                            RoomCapacity = 0
                        },
                        new
                        {
                            CabinetId = 3,
                            CabinetName = "MathLab",
                            RoomCapacity = 0
                        },
                        new
                        {
                            CabinetId = 4,
                            CabinetName = "UkrLab",
                            RoomCapacity = 0
                        });
                });

            modelBuilder.Entity("Rozklad.Core.ClassRoom", b =>
                {
                    b.Property<int>("ClassRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassRoomId"), 1L, 1);

                    b.Property<string>("ClassRoomName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ClassRoomId");

                    b.ToTable("ClassRooms");

                    b.HasData(
                        new
                        {
                            ClassRoomId = 1,
                            ClassRoomName = "1-A",
                            Year = 1
                        },
                        new
                        {
                            ClassRoomId = 2,
                            ClassRoomName = "1-B",
                            Year = 1
                        },
                        new
                        {
                            ClassRoomId = 3,
                            ClassRoomName = "2-A",
                            Year = 2
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
                            DisciplineName = "Geography"
                        },
                        new
                        {
                            DisciplineId = 2,
                            DisciplineName = "Biology"
                        },
                        new
                        {
                            DisciplineId = 3,
                            DisciplineName = "Math"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"), 1L, 1);

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<string>("LessonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PupilId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("LessonId");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("PupilId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            LessonId = 1,
                            DisciplineId = 1,
                            LessonName = "Geography, 1-st year, 1-A clas",
                            PupilId = 1,
                            TeacherId = 1,
                            Year = 1
                        },
                        new
                        {
                            LessonId = 2,
                            DisciplineId = 2,
                            LessonName = "Biology, 1-st year, 1-B clas",
                            PupilId = 2,
                            TeacherId = 2,
                            Year = 1
                        },
                        new
                        {
                            LessonId = 3,
                            DisciplineId = 3,
                            LessonName = "Math, 2-st year, 2-A clas",
                            PupilId = 3,
                            TeacherId = 3,
                            Year = 2
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Pupil", b =>
                {
                    b.Property<int>("PupilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PupilId"), 1L, 1);

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<string>("IconPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PupilName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("PupilId");

                    b.HasIndex("ClassRoomId");

                    b.ToTable("Pupils");

                    b.HasData(
                        new
                        {
                            PupilId = 1,
                            ClassRoomId = 1,
                            IconPath = "Images\\1200h790_1-4_klass_t.png",
                            PupilName = "Belinskiy O.O",
                            Year = 1
                        },
                        new
                        {
                            PupilId = 2,
                            ClassRoomId = 2,
                            IconPath = "Images\\1200h790_1-4_klass_t.png",
                            PupilName = "Koshubinskiy P.R",
                            Year = 1
                        },
                        new
                        {
                            PupilId = 3,
                            ClassRoomId = 3,
                            IconPath = "Images\\1200h790_1-4_klass_t.png",
                            PupilName = "Bohach V.E",
                            Year = 2
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            TeacherName = "Kvashuk O.V."
                        },
                        new
                        {
                            TeacherId = 2,
                            TeacherName = "Zubenko I.R."
                        },
                        new
                        {
                            TeacherId = 3,
                            TeacherName = "Popchuk M.A."
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

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("LessonNumber")
                        .HasColumnType("int");

                    b.Property<string>("TimeEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeStart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WeekId")
                        .HasColumnType("int");

                    b.HasKey("TimetableId");

                    b.HasIndex("CabinetId");

                    b.HasIndex("LessonId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeekId");

                    b.ToTable("Timetables");

                    b.HasData(
                        new
                        {
                            TimetableId = 1,
                            CabinetId = 1,
                            Day = "Monday",
                            LessonId = 1,
                            LessonNumber = 1,
                            TimeEnd = "9:45",
                            TimeStart = "9:00",
                            UserId = "68dbf660-8355-41a0-a29d-f0a5274ed506",
                            WeekId = 1
                        },
                        new
                        {
                            TimetableId = 2,
                            CabinetId = 2,
                            Day = "Monday",
                            LessonId = 2,
                            LessonNumber = 2,
                            TimeEnd = "9:45",
                            TimeStart = "9:00",
                            UserId = "68dbf660-8355-41a0-a29d-f0a5274ed506",
                            WeekId = 2
                        },
                        new
                        {
                            TimetableId = 3,
                            CabinetId = 3,
                            Day = "Monday",
                            LessonId = 3,
                            LessonNumber = 3,
                            TimeEnd = "9:45",
                            TimeStart = "9:00",
                            UserId = "68dbf660-8355-41a0-a29d-f0a5274ed506",
                            WeekId = 3
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
                            Id = "68dbf660-8355-41a0-a29d-f0a5274ed506",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "be864912-8c67-4a78-8189-fba04f1d358c",
                            Email = "admin@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "ADMIN@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBFN4aLvELjm7SsLDuxA6u38i70U0wijL4x2+24AJQExVcPrlDn5GB0UtwJwjfH0iQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "52e92aa6-dc4d-48b8-be70-943e4d3f2b5d",
                            TwoFactorEnabled = false,
                            UserName = "admin@rozkladschool.com"
                        },
                        new
                        {
                            Id = "dd891594-7785-43e9-b774-3fde8712dbb7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d01056bf-9150-4f15-a35a-7cb2dc4b3b73",
                            Email = "moderator@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MODERATOR@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "MODERATOR@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFg6XWa8obCxhTE3bZGrXSzkV50QmRqFSav3IHyGkscaCD2ByOH54v1xj3omfgPe+Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f8a1b42c-87dd-47ed-ba3e-05399a68f8a9",
                            TwoFactorEnabled = false,
                            UserName = "moderator@rozkladschool.com"
                        },
                        new
                        {
                            Id = "5961e49e-6f36-4166-b80c-d152987bc29c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c755f9f-ff9e-4a94-b09d-e58a98ff8b1b",
                            Email = "user@rozkladschool.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@ROZKLADSCHOOL.COM",
                            NormalizedUserName = "USER@ROZKLADSCHOOL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPCcylAa8TnEJb9rlbKY9EMHvk2TUs9FJKJktJ7no8JYL67aEoPXy8EPf/O+/n5xHw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "024868db-b2b8-44a0-ad7e-6183a98e9add",
                            TwoFactorEnabled = false,
                            UserName = "user@rozkladschool.com"
                        });
                });

            modelBuilder.Entity("Rozklad.Core.Week", b =>
                {
                    b.Property<int>("WeekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeekId"), 1L, 1);

                    b.Property<string>("WeekName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeekId");

                    b.ToTable("Weeks");

                    b.HasData(
                        new
                        {
                            WeekId = 1,
                            WeekName = "07.11.2022-11.11.2022"
                        },
                        new
                        {
                            WeekId = 2,
                            WeekName = "14.11.2022-18.11.2022"
                        },
                        new
                        {
                            WeekId = 3,
                            WeekName = "21.11.2022-25.11.2022"
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

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.HasOne("Rozklad.Core.Discipline", "Discipline")
                        .WithMany("Lessons")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Pupil", "Pupil")
                        .WithMany("Lessons")
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Teacher", "Teacher")
                        .WithMany("Lessons")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Pupil");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Rozklad.Core.Pupil", b =>
                {
                    b.HasOne("Rozklad.Core.ClassRoom", "ClassRoom")
                        .WithMany("Pupils")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");
                });

            modelBuilder.Entity("Rozklad.Core.Timetable", b =>
                {
                    b.HasOne("Rozklad.Core.Cabinet", "Cabinet")
                        .WithMany("Timetables")
                        .HasForeignKey("CabinetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.Lesson", "Lesson")
                        .WithMany("Timetables")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rozklad.Core.User", "User")
                        .WithMany("Timetables")
                        .HasForeignKey("UserId");

                    b.HasOne("Rozklad.Core.Week", "Week")
                        .WithMany("Timetables")
                        .HasForeignKey("WeekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabinet");

                    b.Navigation("Lesson");

                    b.Navigation("User");

                    b.Navigation("Week");
                });

            modelBuilder.Entity("Rozklad.Core.Cabinet", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.ClassRoom", b =>
                {
                    b.Navigation("Pupils");
                });

            modelBuilder.Entity("Rozklad.Core.Discipline", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("Rozklad.Core.Lesson", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Pupil", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("Rozklad.Core.Teacher", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("Rozklad.Core.User", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Rozklad.Core.Week", b =>
                {
                    b.Navigation("Timetables");
                });
#pragma warning restore 612, 618
        }
    }
}
