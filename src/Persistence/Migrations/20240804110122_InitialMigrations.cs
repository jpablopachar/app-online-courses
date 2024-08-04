using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "courses",
                columns: new[] { "Id", "Description", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { new Guid("44470082-5de4-4647-a423-7d270d42faf1"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6286), "Small Concrete Shirt" },
                    { new Guid("50b12adf-8a8a-4839-8ad3-7f0fba0bc4ca"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6362), "Unbranded Soft Table" },
                    { new Guid("8aac6cff-a1da-48de-986b-64f432ea527a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6444), "Licensed Soft Sausages" },
                    { new Guid("92792d35-5127-4183-9c94-f245296c0580"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6380), "Sleek Concrete Shoes" },
                    { new Guid("c05bf9d1-6701-4b16-9569-140c3c9ac694"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6397), "Unbranded Metal Chair" },
                    { new Guid("cacfed7f-bcdf-4a8b-9007-fe5ea19e78dd"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6416), "Rustic Steel Bacon" },
                    { new Guid("e0eafc4f-df5b-405c-8383-b2d4995884e4"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6459), "Fantastic Concrete Tuna" },
                    { new Guid("e1298ad7-b3b7-458f-8069-eeec55f8d7d0"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6316), "Incredible Plastic Fish" },
                    { new Guid("ff333ee9-81da-4b6f-98f4-7a53666f9bf9"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 8, 4, 11, 1, 22, 50, DateTimeKind.Utc).AddTicks(6342), "Handcrafted Plastic Chair" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "AcademicDegree", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("152a5e56-7011-45cd-9d43-ab188e044a5c"), "Principal Mobility Designer", "Zachery", "Johnson" },
                    { new Guid("168a59f8-887e-4ecb-972d-c851c6456a2e"), "Forward Identity Designer", "Asa", "Ziemann" },
                    { new Guid("2bd0a8f5-ff77-46ce-8c21-6ed9c32f4458"), "International Mobility Planner", "Aniyah", "Kuvalis" },
                    { new Guid("3d9a352d-994e-4735-86d9-61d8258e88ba"), "Regional Directives Technician", "Jordon", "Fisher" },
                    { new Guid("4762fb41-032a-449f-b4d4-6fcb9c8acc31"), "Corporate Group Engineer", "Laverna", "Keeling" },
                    { new Guid("9408973c-d62a-456d-8538-e64f9428d97a"), "Internal Configuration Facilitator", "Khalid", "Schneider" },
                    { new Guid("b7fdc041-f682-4290-88d5-a96ed0c75b0a"), "Future Brand Developer", "Mekhi", "Torp" },
                    { new Guid("c8448252-830a-4520-a434-eb15041fe016"), "Direct Group Developer", "Kaley", "Watsica" },
                    { new Guid("f4f45d79-28d3-465f-b712-2637a81e7d4b"), "Chief Quality Architect", "Kenna", "Renner" },
                    { new Guid("fede0017-9297-404e-a855-56b6522e8e0b"), "Customer Interactions Consultant", "Megane", "Price" }
                });

            migrationBuilder.InsertData(
                table: "prices",
                columns: new[] { "Id", "ActualPrice", "Name", "PromotionalPrice" },
                values: new object[] { new Guid("5b26ce59-03cd-4571-877e-871c8f16437e"), 10.0m, "Regular Price", 8.0m });

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
                name: "course_instructors");

            migrationBuilder.DropTable(
                name: "course_prices");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "qualifications");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "prices");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
