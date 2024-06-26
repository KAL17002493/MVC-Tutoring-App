﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SAD.Data;

#nullable disable

namespace SAD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230514191904_subjects")]
    partial class subjects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "78bf8cbe-1f70-4d6d-890b-247bc57e6150",
                            ConcurrencyStamp = "231728ec-ceef-4de5-8c95-7f82a488cc0d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02",
                            ConcurrencyStamp = "68144efc-092a-403e-a7fe-3c276de06a72",
                            Name = "Tutor",
                            NormalizedName = "TUTOR"
                        },
                        new
                        {
                            Id = "2e97d46f-5885-4d65-aa2f-29e7e2d323fd",
                            ConcurrencyStamp = "2a956498-1cb2-4a0f-8d27-236a95c6e820",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "143d3180-1104-46f0-8646-62d630056f42",
                            RoleId = "78bf8cbe-1f70-4d6d-890b-247bc57e6150"
                        },
                        new
                        {
                            UserId = "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                            RoleId = "2e97d46f-5885-4d65-aa2f-29e7e2d323fd"
                        },
                        new
                        {
                            UserId = "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                            RoleId = "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SAD.Models.BookingModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeSlot")
                        .HasColumnType("TEXT");

                    b.Property<string>("TutorId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("SAD.Models.CustomUserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("teacherCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "143d3180-1104-46f0-8646-62d630056f42",
                            About = "",
                            AccessFailedCount = 0,
                            Available = true,
                            ConcurrencyStamp = "231728ec-ceef-4de5-8c95-7f82a488cc0d",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIbU946PJQI+K2cKYN6u0yWehcd2dW8br2JXFvWHlzhHq/JVtArCIF0RW65L4EqyGQ==",
                            PhoneNumberConfirmed = false,
                            SName = "Admin",
                            SecurityStamp = "13eebb7a-9e00-4d67-b160-a019fbdbe06f",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com",
                            teacherCode = "24055348-2b29-421d-aca3-d183a07feb93"
                        },
                        new
                        {
                            Id = "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                            About = "",
                            AccessFailedCount = 0,
                            Available = true,
                            ConcurrencyStamp = "2a956498-1cb2-4a0f-8d27-236a95c6e820",
                            Email = "student@student.com",
                            EmailConfirmed = false,
                            FName = "Student",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT@STUDENT.COM",
                            NormalizedUserName = "STUDENT@STUDENT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBIvKza0nnBMzDoSL1+DqhyK0HsIpLDuMdbRin+8t+fxmA1kAOEI49971r5kPzOBfA==",
                            PhoneNumberConfirmed = false,
                            SName = "Student",
                            SecurityStamp = "45b32b06-098d-446f-9110-fa6ef8eb913d",
                            TwoFactorEnabled = false,
                            UserName = "student@student.com",
                            teacherCode = "c8be3112-1b2d-4b68-96a2-e8cde2adb92f"
                        },
                        new
                        {
                            Id = "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                            About = "I am an experienced teacher with 10 years of experience in teaching Math and Science.",
                            AccessFailedCount = 0,
                            Available = true,
                            ConcurrencyStamp = "68144efc-092a-403e-a7fe-3c276de06a72",
                            Email = "tutor@tutor.com",
                            EmailConfirmed = false,
                            FName = "Tutor",
                            LockoutEnabled = false,
                            NormalizedEmail = "TUTOR@TUTOR.COM",
                            NormalizedUserName = "TUTOR@TUTOR.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENtCdte3h7DvA4H1/5U2XsyG87oN+423XV45d47SD+ym7vCtF4jAAUQJpwlphHOJyg==",
                            PhoneNumberConfirmed = false,
                            SName = "Tutor",
                            SecurityStamp = "8e048036-2aab-4fbc-a02a-f39fd6a0b3e1",
                            TwoFactorEnabled = false,
                            UserName = "tutor@tutor.com",
                            teacherCode = "1234567890"
                        });
                });

            modelBuilder.Entity("SAD.Models.FollowModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FollowerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FollowingId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FollowerId");

                    b.HasIndex("FollowingId");

                    b.ToTable("Follow");
                });

            modelBuilder.Entity("SAD.Models.SlotModel", b =>
                {
                    b.Property<int>("SlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookingId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CardColour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SlotTime")
                        .HasColumnType("TEXT");

                    b.HasKey("SlotId");

                    b.ToTable("Slot");
                });

            modelBuilder.Entity("SAD.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mathematics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Physics"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chemistry"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Biology"
                        },
                        new
                        {
                            Id = 5,
                            Name = "English Literature"
                        },
                        new
                        {
                            Id = 6,
                            Name = "History"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Geography"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Computer Science"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Spanish"
                        },
                        new
                        {
                            Id = 10,
                            Name = "French"
                        },
                        new
                        {
                            Id = 11,
                            Name = "German"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Physical Education"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Psychology"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Sociology"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Economics"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Business Studies"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Accounting"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Chemical Engineering"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Civil Engineering"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Electrical Engineering"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Mechanical Engineering"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Astronomy"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Environmental Science"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Political Science"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Law"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Philosophy"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Anthropology"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Archaeology"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Religious Studies"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Film Studies"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Media Studies"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Graphic Design"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Mobile App Development"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Machine Learning"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Robotics"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Advertising"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Statistics"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Mathematical Statistics"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Actuarial Science"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Literary Studies"
                        });
                });

            modelBuilder.Entity("SAD.Models.TutorAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("End")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("TutorId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TutorAvailabilities");
                });

            modelBuilder.Entity("SAD.Models.UserSubject", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTeachable")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("UserSubject");
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
                    b.HasOne("SAD.Models.CustomUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", null)
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

                    b.HasOne("SAD.Models.CustomUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SAD.Models.BookingModel", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SAD.Models.CustomUserModel", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("SAD.Models.FollowModel", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", "Follower")
                        .WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SAD.Models.CustomUserModel", "Following")
                        .WithMany()
                        .HasForeignKey("FollowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Follower");

                    b.Navigation("Following");
                });

            modelBuilder.Entity("SAD.Models.UserSubject", b =>
                {
                    b.HasOne("SAD.Models.Subject", "Subject")
                        .WithMany("UserSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SAD.Models.CustomUserModel", "User")
                        .WithMany("UserSubjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SAD.Models.CustomUserModel", b =>
                {
                    b.Navigation("UserSubjects");
                });

            modelBuilder.Entity("SAD.Models.Subject", b =>
                {
                    b.Navigation("UserSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
