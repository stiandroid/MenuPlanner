using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class SeedRolesUserAndUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 10, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5316), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5368), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5393), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5405), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5481), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5496), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5531), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5553), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "316663bb-5bc2-4ea9-97e3-add8cb4f21c7", null, "UserAdmin", "USERADMIN" },
                    { "36e62375-fabc-4eee-9627-227ae2e7124b", null, "AllergenAdmin", "ALLERGENADMIN" },
                    { "53ef74d9-061c-4c32-9e4c-b5506a29106c", null, "ArticleEditor", "ARTICLEEDITOR" },
                    { "6541f79c-e876-4b50-aa63-18e1073b2cf1", null, "CommunityMod", "COMMUNITYMOD" },
                    { "93982ad3-a7bf-49e1-8b0e-174dbf7ed0f2", null, "SysAdmin", "SYSADMIN" },
                    { "9b8a9139-8141-438d-bb76-1cf03235ad39", null, "IngredientEditor", "INGREDIENTEDITOR" },
                    { "a690aeeb-caab-4463-8f23-652f324774b7", null, "RecipeMod", "RECIPEMOD" },
                    { "ca7fc373-1371-45be-8243-24b5648e9e55", null, "RecipeEditor", "RECIPEEDITOR" },
                    { "dd389822-30ce-4403-bad3-7b393a67bb94", null, "IngredientMod", "INGREDIENTMOD" },
                    { "efc3e1e4-c89c-442a-a4d7-d8eb53a874d3", null, "ArticleMod", "ARTICLEMOD" },
                    { "fb897a51-7e30-4aab-8407-36ae17b4db7e", null, "NutrientAdmin", "NUTRIENTADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Facebook", "FirstName", "HasBackgropImage", "HasProfileImage", "Instagram", "Introduction", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwitterX", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[] { "c1568388-9fbe-415d-bf8a-01552278ba03", 0, "6edc40d4-8b9a-45bd-a28a-e6c9b4f32cec", "stian.saether@gmail.com", false, null, "Stian", false, false, null, "", "Sæther", false, null, "STIAN.SAETHER@GMAIL.COM", "STIAN.SAETHER@GMAIL.COM", null, "90794163", false, "90b9ecb0-d25b-4617-8aac-8dafc45bd65d", null, false, "stian.saether@gmail.com", null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(7881), new DateTime(2024, 2, 14, 14, 35, 54, 14, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1384), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1465), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1480), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1493), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1603), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1617), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1643), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2173), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2258), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2307), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2319), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2338), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2366), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2386), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2396), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2405), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2415), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2424), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2436), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2478), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2489), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2632), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2656), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2667), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2680), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2692), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2739), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2753), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2765), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2789), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2801), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2814), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2825), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2837), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2849), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2861), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2875), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2901), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2927), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2936), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2967), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2977), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2996), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3005), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3014), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3072), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3082), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3192), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3222), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3237), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3249), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3263), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3277), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3379), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3391), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3414), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3426), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3452), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3490), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3560), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3622), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3635), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3669), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3756), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3826), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3845), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3854), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3863), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3887), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3896), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3906), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3916), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(7909), new DateTime(2024, 2, 14, 14, 35, 54, 15, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(383), new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(407), new DateTime(2024, 2, 14, 14, 35, 54, 16, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "93982ad3-a7bf-49e1-8b0e-174dbf7ed0f2", "c1568388-9fbe-415d-bf8a-01552278ba03" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "316663bb-5bc2-4ea9-97e3-add8cb4f21c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36e62375-fabc-4eee-9627-227ae2e7124b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53ef74d9-061c-4c32-9e4c-b5506a29106c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6541f79c-e876-4b50-aa63-18e1073b2cf1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b8a9139-8141-438d-bb76-1cf03235ad39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a690aeeb-caab-4463-8f23-652f324774b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca7fc373-1371-45be-8243-24b5648e9e55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd389822-30ce-4403-bad3-7b393a67bb94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efc3e1e4-c89c-442a-a4d7-d8eb53a874d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb897a51-7e30-4aab-8407-36ae17b4db7e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93982ad3-a7bf-49e1-8b0e-174dbf7ed0f2", "c1568388-9fbe-415d-bf8a-01552278ba03" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93982ad3-a7bf-49e1-8b0e-174dbf7ed0f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1568388-9fbe-415d-bf8a-01552278ba03");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 162, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7137), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7261), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7286), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7297), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7319), new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 166, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2837), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2932), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2943), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2978), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2989), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3524), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3563), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3574), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3625), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3636), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3648), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3836), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3862), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3874), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3886), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3975), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4044), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4067), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4107), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4143), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4165), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4187), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4198), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4210), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4235), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4246), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4364), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4387), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4401), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4423), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4446), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4457), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4480), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4492), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4504), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4542), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4555), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4566), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4577), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4633), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4801), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4812), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4845), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4879), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4891), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4904), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4966), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4978), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5011), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5022), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5033), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5045), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5056), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5079), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5090), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5114), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5152), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5164), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5175), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5186), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5326), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5349), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 2, 12, 12, 6, 29, 167, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1614), new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1641), new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1652), new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1664), new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1676), new DateTime(2024, 2, 12, 12, 6, 29, 168, DateTimeKind.Local).AddTicks(1679) });
        }
    }
}
