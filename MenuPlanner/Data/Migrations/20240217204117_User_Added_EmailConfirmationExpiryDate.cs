using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class User_Added_EmailConfirmationExpiryDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRegistered",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EmailConfirmationExpiryDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 472, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5512), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5600), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5684), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5732), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5769), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5805), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15764c03-647f-454a-b718-81fec69dea1d", null, "SysAdmin", "SYSADMIN" },
                    { "454c0450-6f52-433c-b74b-2f4f01268797", null, "UserAdmin", "USERADMIN" },
                    { "4b348c33-a260-4f6a-9f42-01d0c3a61976", null, "ArticleEditor", "ARTICLEEDITOR" },
                    { "6aefc702-e0f5-4a12-9241-28bac89f89ac", null, "RecipeEditor", "RECIPEEDITOR" },
                    { "711384f1-9c1f-4a9f-b269-1d13076d3b3f", null, "AllergenAdmin", "ALLERGENADMIN" },
                    { "96b4e3f5-0abf-409a-b527-5ce144ff9d09", null, "CommunityMod", "COMMUNITYMOD" },
                    { "9e1f91fc-1733-4dde-9527-9490f45555bf", null, "IngredientEditor", "INGREDIENTEDITOR" },
                    { "9e5414e6-75f4-40f5-bd89-5104480758df", null, "ArticleMod", "ARTICLEMOD" },
                    { "ba4c5a9b-d8b3-4b0b-984f-3c303d42ec02", null, "IngredientMod", "INGREDIENTMOD" },
                    { "be25a244-cba8-411e-8148-da345c8beec6", null, "RecipeMod", "RECIPEMOD" },
                    { "c8856ff2-7643-48c7-b9fa-1f474b05ec56", null, "NutrientAdmin", "NUTRIENTADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateRegistered", "Email", "EmailConfirmationExpiryDate", "EmailConfirmed", "Facebook", "FirstName", "HasBackgropImage", "HasProfileImage", "Instagram", "Introduction", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwitterX", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[] { "bcfc8991-12c0-49a6-a9d6-58c1b38f3811", 0, "5d52c286-7c29-47e4-b10a-f691a51983ad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "stian.saether@gmail.com", null, false, null, "Stian", false, false, null, "", "Sæther", false, null, "STIAN.SAETHER@GMAIL.COM", "STIAN.SAETHER@GMAIL.COM", null, "90794163", false, "e7832d33-d388-498c-b05f-d34278d0acc7", null, false, "stian.saether@gmail.com", null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 2, 17, 21, 41, 15, 477, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4114), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4155), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4197), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4294), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4315), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4334), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4359), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4395), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4411), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4454), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5391), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5410), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5453), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5472), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5489), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5525), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5632), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5690), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5709), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5748), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5784), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5802), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5821), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5839), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5878), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5920), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6077), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6095), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6173), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6209), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6299), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6316), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6371), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6376) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6512), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6618), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6777), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6890), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6907), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6943), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6961), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7014), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7088), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7141), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7230), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7248), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7266), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7301), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7319), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7356), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7375), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7560), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7579), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7596), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7616), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7638), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7675), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7719), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7755), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7774), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7792), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7827), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7868), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7887), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7923), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 2, 17, 21, 41, 15, 478, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(3505), new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6535), new DateTime(2024, 2, 17, 21, 41, 15, 479, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15764c03-647f-454a-b718-81fec69dea1d", "bcfc8991-12c0-49a6-a9d6-58c1b38f3811" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "454c0450-6f52-433c-b74b-2f4f01268797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b348c33-a260-4f6a-9f42-01d0c3a61976");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aefc702-e0f5-4a12-9241-28bac89f89ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "711384f1-9c1f-4a9f-b269-1d13076d3b3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b4e3f5-0abf-409a-b527-5ce144ff9d09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e1f91fc-1733-4dde-9527-9490f45555bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e5414e6-75f4-40f5-bd89-5104480758df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba4c5a9b-d8b3-4b0b-984f-3c303d42ec02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be25a244-cba8-411e-8148-da345c8beec6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8856ff2-7643-48c7-b9fa-1f474b05ec56");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15764c03-647f-454a-b718-81fec69dea1d", "bcfc8991-12c0-49a6-a9d6-58c1b38f3811" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15764c03-647f-454a-b718-81fec69dea1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcfc8991-12c0-49a6-a9d6-58c1b38f3811");

            migrationBuilder.DropColumn(
                name: "DateRegistered",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmationExpiryDate",
                table: "AspNetUsers");

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
    }
}
