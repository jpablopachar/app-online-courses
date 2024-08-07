using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    AcademicDegree = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    AcademicDegree = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "prices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR", maxLength: 250, nullable: true),
                    ActualPrice = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false),
                    PromotionalPrice = table.Column<decimal>(type: "TEXT", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PublicId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_photos_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "qualifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Student = table.Column<string>(type: "TEXT", nullable: true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qualifications_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "course_instructors",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstructorId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_instructors", x => new { x.InstructorId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_course_instructors_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_instructors_instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "course_prices",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PriceId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_prices", x => new { x.PriceId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_course_prices_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_prices_prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a0e1180-d414-455e-85a6-963b5c44032d", null, "CLIENT", "CLIENT" },
                    { "34541f26-18ad-4cf5-84a4-ee5484e76131", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { new Guid("013f9729-83fd-4136-a5af-917f4fd04caf"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2500), "Incredible Fresh Tuna" },
                    { new Guid("090be071-43eb-42bc-a5a4-80387015f4e9"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2408), "Intelligent Metal Table" },
                    { new Guid("2383e465-8f0f-4969-885c-dc32a0c21343"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2519), "Generic Granite Sausages" },
                    { new Guid("a0a6c6d2-6e40-4c8e-b60b-c23bc4a6a84a"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2536), "Generic Metal Shirt" },
                    { new Guid("a0e9f264-fbbc-441a-b584-2a6b574ca99f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2431), "Ergonomic Concrete Sausages" },
                    { new Guid("af35b163-ed36-4e5a-bff6-879bcb8b97d8"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2231), "Awesome Metal Chips" },
                    { new Guid("d488e230-1bca-45c3-8acb-d02eb61eaa68"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2482), "Gorgeous Fresh Chips" },
                    { new Guid("d8259fb7-c1ac-4a1c-abda-1abc98560568"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2259), "Ergonomic Metal Chair" },
                    { new Guid("e7669ae2-177f-4127-91a0-651e8ac10053"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 8, 7, 6, 15, 44, 803, DateTimeKind.Utc).AddTicks(2449), "Awesome Wooden Soap" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "AcademicDegree", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1cef0982-10eb-475d-8719-acced171a8c6"), "Corporate Branding Manager", "Leatha", "Trantow" },
                    { new Guid("2b347b72-e246-4e14-a359-5c924b82e138"), "Principal Directives Consultant", "Lew", "Veum" },
                    { new Guid("45d97b7b-651e-4005-a129-feec9fed4e9c"), "Corporate Infrastructure Executive", "Markus", "Pagac" },
                    { new Guid("47fa107b-3f04-4ad7-9019-e271c79c9ad8"), "Corporate Solutions Orchestrator", "Marcellus", "Hermann" },
                    { new Guid("6d837e48-9833-422b-9058-40a9dd5bde7b"), "Direct Functionality Liaison", "Emily", "Moore" },
                    { new Guid("7354a458-5ca4-47a3-9ff9-de5ebcc4107a"), "Product Infrastructure Liaison", "Angelita", "Wolf" },
                    { new Guid("a49dea58-6ed3-4358-8f0e-03172d27e373"), "Chief Accountability Supervisor", "Haley", "Bayer" },
                    { new Guid("ccec0afb-c63f-4f24-83df-f54e80ceba61"), "Corporate Functionality Consultant", "Matt", "Heaney" },
                    { new Guid("e8bb3582-9681-43bf-925a-8df3d62fbbf6"), "Senior Paradigm Developer", "Emery", "King" },
                    { new Guid("e8f16c5c-6db2-4a9b-9634-df9750a5d2e4"), "Legacy Infrastructure Orchestrator", "Luella", "Goyette" }
                });

            migrationBuilder.InsertData(
                table: "prices",
                columns: new[] { "Id", "ActualPrice", "Name", "PromotionalPrice" },
                values: new object[] { new Guid("2b1c976a-9d91-4114-8879-7b9710d2364c"), 10.0m, "Regular Price", 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "COURSE_READ", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 2, "POLICIES", "COURSE_UPDATE", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 3, "POLICIES", "COURSE_WRITE", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 4, "POLICIES", "COURSE_DELETE", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 8, "POLICIES", "COMMENT_READ", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 9, "POLICIES", "COMMENT_DELETE", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 10, "POLICIES", "COMMENT_CREATE", "34541f26-18ad-4cf5-84a4-ee5484e76131" },
                    { 11, "POLICIES", "COURSE_READ", "1a0e1180-d414-455e-85a6-963b5c44032d" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "1a0e1180-d414-455e-85a6-963b5c44032d" },
                    { 13, "POLICIES", "COMMENT_READ", "1a0e1180-d414-455e-85a6-963b5c44032d" },
                    { 14, "POLICIES", "COMMENT_CREATE", "1a0e1180-d414-455e-85a6-963b5c44032d" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_course_instructors_CourseId",
                table: "course_instructors",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_course_prices_CourseId",
                table: "course_prices",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_photos_CourseId",
                table: "photos",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_qualifications_CourseId",
                table: "qualifications",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "course_instructors");

            migrationBuilder.DropTable(
                name: "course_prices");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "qualifications");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "prices");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
