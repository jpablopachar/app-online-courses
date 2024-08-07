﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(OnlineCoursesDbContext))]
    partial class OnlineCoursesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Domain.Course", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1cf80e4e-0908-4942-8cd9-958a29d321c6"),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4220),
                            Title = "Tasty Plastic Pants"
                        },
                        new
                        {
                            Id = new Guid("2d55c8a0-d158-4504-911b-86216844a5c3"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4242),
                            Title = "Small Metal Soap"
                        },
                        new
                        {
                            Id = new Guid("115620f8-2362-4761-a896-8517d9d43a6a"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4257),
                            Title = "Sleek Wooden Sausages"
                        },
                        new
                        {
                            Id = new Guid("890b98a1-b83a-4a3d-ba1a-02c5dd0a0386"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4281),
                            Title = "Awesome Cotton Pizza"
                        },
                        new
                        {
                            Id = new Guid("22f0d84e-924d-4f7a-b4c5-aa9512f9bb86"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4303),
                            Title = "Licensed Plastic Keyboard"
                        },
                        new
                        {
                            Id = new Guid("c3bee471-9d71-4ac0-b96f-53e122b20911"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4322),
                            Title = "Fantastic Frozen Shoes"
                        },
                        new
                        {
                            Id = new Guid("87b8e013-5d90-4d27-8f73-cee334906418"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4335),
                            Title = "Unbranded Wooden Chips"
                        },
                        new
                        {
                            Id = new Guid("7a824b68-f0e6-4a23-8aa6-6a83f853f62d"),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4347),
                            Title = "Small Wooden Chips"
                        },
                        new
                        {
                            Id = new Guid("a6ee4a40-b749-4b05-a444-061860a5b50e"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            PublicationDate = new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4359),
                            Title = "Handmade Fresh Sausages"
                        });
                });

            modelBuilder.Entity("Domain.CourseInstructor", b =>
                {
                    b.Property<Guid?>("InstructorId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("TEXT");

                    b.HasKey("InstructorId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("course_instructors", (string)null);
                });

            modelBuilder.Entity("Domain.CoursePrice", b =>
                {
                    b.Property<Guid?>("PriceId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("TEXT");

                    b.HasKey("PriceId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("course_prices", (string)null);
                });

            modelBuilder.Entity("Domain.Instructor", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AcademicDegree")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b5f5760f-0b86-4121-acc9-bcb9b7ca5411"),
                            AcademicDegree = "Dynamic Paradigm Executive",
                            FirstName = "Alek",
                            LastName = "Watsica"
                        },
                        new
                        {
                            Id = new Guid("e721c988-baa5-4867-b267-dc25b24fbd43"),
                            AcademicDegree = "Future Infrastructure Coordinator",
                            FirstName = "Austin",
                            LastName = "Weber"
                        },
                        new
                        {
                            Id = new Guid("7d9bec40-e6f7-4824-b2af-0584fdd4b066"),
                            AcademicDegree = "Chief Directives Manager",
                            FirstName = "Lyda",
                            LastName = "Klein"
                        },
                        new
                        {
                            Id = new Guid("0a265900-6adc-4ec9-af21-bf943568752a"),
                            AcademicDegree = "Internal Program Developer",
                            FirstName = "Millie",
                            LastName = "Littel"
                        },
                        new
                        {
                            Id = new Guid("1ce74329-8b51-4c99-9c63-e79c81e81047"),
                            AcademicDegree = "Principal Integration Director",
                            FirstName = "Micah",
                            LastName = "Mante"
                        },
                        new
                        {
                            Id = new Guid("a4b9a7dc-f367-4af8-9ea7-ca60bb731d96"),
                            AcademicDegree = "Lead Division Agent",
                            FirstName = "Janelle",
                            LastName = "Wunsch"
                        },
                        new
                        {
                            Id = new Guid("53a50b2a-d3c1-4dd8-8ef2-41f7421308cf"),
                            AcademicDegree = "Central Applications Assistant",
                            FirstName = "Halle",
                            LastName = "Bernier"
                        },
                        new
                        {
                            Id = new Guid("0386a495-d6b7-4d25-98ab-0de311672244"),
                            AcademicDegree = "Direct Applications Officer",
                            FirstName = "Breana",
                            LastName = "Larkin"
                        },
                        new
                        {
                            Id = new Guid("a4d62706-7136-4035-a5f9-0445ac2850b3"),
                            AcademicDegree = "Direct Research Administrator",
                            FirstName = "Dorian",
                            LastName = "Fay"
                        },
                        new
                        {
                            Id = new Guid("f4baa447-ffba-48bf-af00-785e92736527"),
                            AcademicDegree = "Dynamic Marketing Analyst",
                            FirstName = "Kaycee",
                            LastName = "Kutch"
                        });
                });

            modelBuilder.Entity("Domain.Photo", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("photos", (string)null);
                });

            modelBuilder.Entity("Domain.Price", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ActualPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("PromotionalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("prices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7aeaefba-3b3d-4e71-9a98-e404af7a1e75"),
                            ActualPrice = 10.0m,
                            Name = "Regular Price",
                            PromotionalPrice = 8.0m
                        });
                });

            modelBuilder.Entity("Domain.Qualification", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Student")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("qualifications", (string)null);
                });

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
                            Id = "5a050d50-cd57-4d70-853f-97e81bb723f4",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "032e6534-119a-429e-9a20-f53ebf47e301",
                            Name = "CLIENT",
                            NormalizedName = "CLIENT"
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "POLICIES",
                            ClaimValue = "COURSE_READ",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "COURSE_UPDATE",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "COURSE_WRITE",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "COURSE_DELETE",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_CREATE",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_UPDATE",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMMENT_READ",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMMENT_DELETE",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMMENT_CREATE",
                            RoleId = "5a050d50-cd57-4d70-853f-97e81bb723f4"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "POLICIES",
                            ClaimValue = "COURSE_READ",
                            RoleId = "032e6534-119a-429e-9a20-f53ebf47e301"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "032e6534-119a-429e-9a20-f53ebf47e301"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMMENT_READ",
                            RoleId = "032e6534-119a-429e-9a20-f53ebf47e301"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMMENT_CREATE",
                            RoleId = "032e6534-119a-429e-9a20-f53ebf47e301"
                        });
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

            modelBuilder.Entity("Persistence.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AcademicDegree")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Domain.CourseInstructor", b =>
                {
                    b.HasOne("Domain.Course", "Course")
                        .WithMany("CourseInstructors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Instructor", "Instructor")
                        .WithMany("CourseInstructors")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Domain.CoursePrice", b =>
                {
                    b.HasOne("Domain.Course", "Course")
                        .WithMany("CoursePrices")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Price", "Price")
                        .WithMany("CoursePrices")
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("Domain.Photo", b =>
                {
                    b.HasOne("Domain.Course", "Course")
                        .WithMany("Photos")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Domain.Qualification", b =>
                {
                    b.HasOne("Domain.Course", "Course")
                        .WithMany("Qualifications")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Course");
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
                    b.HasOne("Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Persistence.Models.AppUser", null)
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

                    b.HasOne("Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Course", b =>
                {
                    b.Navigation("CourseInstructors");

                    b.Navigation("CoursePrices");

                    b.Navigation("Photos");

                    b.Navigation("Qualifications");
                });

            modelBuilder.Entity("Domain.Instructor", b =>
                {
                    b.Navigation("CourseInstructors");
                });

            modelBuilder.Entity("Domain.Price", b =>
                {
                    b.Navigation("CoursePrices");
                });
#pragma warning restore 612, 618
        }
    }
}
