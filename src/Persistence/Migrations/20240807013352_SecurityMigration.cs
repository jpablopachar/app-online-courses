using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SecurityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("44470082-5de4-4647-a423-7d270d42faf1"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("50b12adf-8a8a-4839-8ad3-7f0fba0bc4ca"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("8aac6cff-a1da-48de-986b-64f432ea527a"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("92792d35-5127-4183-9c94-f245296c0580"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("c05bf9d1-6701-4b16-9569-140c3c9ac694"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("cacfed7f-bcdf-4a8b-9007-fe5ea19e78dd"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("e0eafc4f-df5b-405c-8383-b2d4995884e4"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("e1298ad7-b3b7-458f-8069-eeec55f8d7d0"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("ff333ee9-81da-4b6f-98f4-7a53666f9bf9"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("152a5e56-7011-45cd-9d43-ab188e044a5c"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("168a59f8-887e-4ecb-972d-c851c6456a2e"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("2bd0a8f5-ff77-46ce-8c21-6ed9c32f4458"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("3d9a352d-994e-4735-86d9-61d8258e88ba"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("4762fb41-032a-449f-b4d4-6fcb9c8acc31"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("9408973c-d62a-456d-8538-e64f9428d97a"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("b7fdc041-f682-4290-88d5-a96ed0c75b0a"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("c8448252-830a-4520-a434-eb15041fe016"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("f4f45d79-28d3-465f-b712-2637a81e7d4b"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("fede0017-9297-404e-a855-56b6522e8e0b"));

            migrationBuilder.DeleteData(
                table: "prices",
                keyColumn: "Id",
                keyValue: new Guid("5b26ce59-03cd-4571-877e-871c8f16437e"));

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "032e6534-119a-429e-9a20-f53ebf47e301", null, "CLIENT", "CLIENT" },
                    { "5a050d50-cd57-4d70-853f-97e81bb723f4", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Description", "PublicationDate", "Title" },
                values: new object[,]
                {
                    { new Guid("115620f8-2362-4761-a896-8517d9d43a6a"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4257), "Sleek Wooden Sausages" },
                    { new Guid("1cf80e4e-0908-4942-8cd9-958a29d321c6"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4220), "Tasty Plastic Pants" },
                    { new Guid("22f0d84e-924d-4f7a-b4c5-aa9512f9bb86"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4303), "Licensed Plastic Keyboard" },
                    { new Guid("2d55c8a0-d158-4504-911b-86216844a5c3"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4242), "Small Metal Soap" },
                    { new Guid("7a824b68-f0e6-4a23-8aa6-6a83f853f62d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4347), "Small Wooden Chips" },
                    { new Guid("87b8e013-5d90-4d27-8f73-cee334906418"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4335), "Unbranded Wooden Chips" },
                    { new Guid("890b98a1-b83a-4a3d-ba1a-02c5dd0a0386"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4281), "Awesome Cotton Pizza" },
                    { new Guid("a6ee4a40-b749-4b05-a444-061860a5b50e"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4359), "Handmade Fresh Sausages" },
                    { new Guid("c3bee471-9d71-4ac0-b96f-53e122b20911"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 8, 7, 1, 33, 51, 296, DateTimeKind.Utc).AddTicks(4322), "Fantastic Frozen Shoes" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "AcademicDegree", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0386a495-d6b7-4d25-98ab-0de311672244"), "Direct Applications Officer", "Breana", "Larkin" },
                    { new Guid("0a265900-6adc-4ec9-af21-bf943568752a"), "Internal Program Developer", "Millie", "Littel" },
                    { new Guid("1ce74329-8b51-4c99-9c63-e79c81e81047"), "Principal Integration Director", "Micah", "Mante" },
                    { new Guid("53a50b2a-d3c1-4dd8-8ef2-41f7421308cf"), "Central Applications Assistant", "Halle", "Bernier" },
                    { new Guid("7d9bec40-e6f7-4824-b2af-0584fdd4b066"), "Chief Directives Manager", "Lyda", "Klein" },
                    { new Guid("a4b9a7dc-f367-4af8-9ea7-ca60bb731d96"), "Lead Division Agent", "Janelle", "Wunsch" },
                    { new Guid("a4d62706-7136-4035-a5f9-0445ac2850b3"), "Direct Research Administrator", "Dorian", "Fay" },
                    { new Guid("b5f5760f-0b86-4121-acc9-bcb9b7ca5411"), "Dynamic Paradigm Executive", "Alek", "Watsica" },
                    { new Guid("e721c988-baa5-4867-b267-dc25b24fbd43"), "Future Infrastructure Coordinator", "Austin", "Weber" },
                    { new Guid("f4baa447-ffba-48bf-af00-785e92736527"), "Dynamic Marketing Analyst", "Kaycee", "Kutch" }
                });

            migrationBuilder.InsertData(
                table: "prices",
                columns: new[] { "Id", "ActualPrice", "Name", "PromotionalPrice" },
                values: new object[] { new Guid("7aeaefba-3b3d-4e71-9a98-e404af7a1e75"), 10.0m, "Regular Price", 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "COURSE_READ", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 2, "POLICIES", "COURSE_UPDATE", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 3, "POLICIES", "COURSE_WRITE", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 4, "POLICIES", "COURSE_DELETE", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 8, "POLICIES", "COMMENT_READ", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 9, "POLICIES", "COMMENT_DELETE", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 10, "POLICIES", "COMMENT_CREATE", "5a050d50-cd57-4d70-853f-97e81bb723f4" },
                    { 11, "POLICIES", "COURSE_READ", "032e6534-119a-429e-9a20-f53ebf47e301" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "032e6534-119a-429e-9a20-f53ebf47e301" },
                    { 13, "POLICIES", "COMMENT_READ", "032e6534-119a-429e-9a20-f53ebf47e301" },
                    { 14, "POLICIES", "COMMENT_CREATE", "032e6534-119a-429e-9a20-f53ebf47e301" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("115620f8-2362-4761-a896-8517d9d43a6a"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("1cf80e4e-0908-4942-8cd9-958a29d321c6"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("22f0d84e-924d-4f7a-b4c5-aa9512f9bb86"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("2d55c8a0-d158-4504-911b-86216844a5c3"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("7a824b68-f0e6-4a23-8aa6-6a83f853f62d"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("87b8e013-5d90-4d27-8f73-cee334906418"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("890b98a1-b83a-4a3d-ba1a-02c5dd0a0386"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("a6ee4a40-b749-4b05-a444-061860a5b50e"));

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: new Guid("c3bee471-9d71-4ac0-b96f-53e122b20911"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("0386a495-d6b7-4d25-98ab-0de311672244"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("0a265900-6adc-4ec9-af21-bf943568752a"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("1ce74329-8b51-4c99-9c63-e79c81e81047"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("53a50b2a-d3c1-4dd8-8ef2-41f7421308cf"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("7d9bec40-e6f7-4824-b2af-0584fdd4b066"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("a4b9a7dc-f367-4af8-9ea7-ca60bb731d96"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("a4d62706-7136-4035-a5f9-0445ac2850b3"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("b5f5760f-0b86-4121-acc9-bcb9b7ca5411"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("e721c988-baa5-4867-b267-dc25b24fbd43"));

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: new Guid("f4baa447-ffba-48bf-af00-785e92736527"));

            migrationBuilder.DeleteData(
                table: "prices",
                keyColumn: "Id",
                keyValue: new Guid("7aeaefba-3b3d-4e71-9a98-e404af7a1e75"));

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
        }
    }
}
