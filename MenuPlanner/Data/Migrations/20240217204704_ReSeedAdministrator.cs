using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class ReSeedAdministrator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 276, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 2, 17, 21, 47, 2, 278, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(788), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(806), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(814), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(847), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(919), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b668c8e-99f6-4171-906d-37fb78724c2b", null, "IngredientEditor", "INGREDIENTEDITOR" },
                    { "2304028e-176a-41bc-a7f2-fddd3664f9d5", null, "CommunityMod", "COMMUNITYMOD" },
                    { "251e4921-9ff5-4092-b0ae-3ce24df0d7a9", null, "RecipeMod", "RECIPEMOD" },
                    { "58da53ae-f365-4ff8-b127-2d75b3e386ad", null, "AllergenAdmin", "ALLERGENADMIN" },
                    { "667dec01-4984-4784-a324-8c90229cbfbf", null, "IngredientMod", "INGREDIENTMOD" },
                    { "6cc714ff-e99b-4f06-82a8-75bfc53015d4", null, "RecipeEditor", "RECIPEEDITOR" },
                    { "7b3fa5c1-2eea-465f-8857-847dd188b04f", null, "ArticleEditor", "ARTICLEEDITOR" },
                    { "89f2b59b-167f-4820-971e-f45549d9b5d3", null, "ArticleMod", "ARTICLEMOD" },
                    { "b92ae293-6057-4a78-9abe-dc2b9f17751a", null, "SysAdmin", "SYSADMIN" },
                    { "d8807d97-c20f-4ab7-a3ca-366b48f77374", null, "UserAdmin", "USERADMIN" },
                    { "db3190ad-71ea-46ba-898e-661637789ce5", null, "NutrientAdmin", "NUTRIENTADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateRegistered", "Email", "EmailConfirmationExpiryDate", "EmailConfirmed", "Facebook", "FirstName", "HasBackgropImage", "HasProfileImage", "Instagram", "Introduction", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwitterX", "TwoFactorEnabled", "UserName", "Website" },
                values: new object[] { "97eb4532-3e83-409e-a6f3-bbcceec0c5e7", 0, "bdebb2f9-a1a3-4ef0-9581-c65a56f43a55", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@menuplanner.yes", null, false, null, "Adam I.", false, false, null, "", "Strator", false, null, "ADMIN@MENUPLANNER.YES", "ADMIN@MENUPLANNER.YES", null, "99999999", false, "5dcf1ea2-11c7-4c32-9802-858b99ea4cb2", null, false, "admin@menuplanner.yes", null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(2700), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4707), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4726), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4812), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4828), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5202), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5291), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5332), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5340), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5348), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5372), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5387), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5395), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5402), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5410), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5418), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5444), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5481), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5488), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5496), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5503), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5511), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5534), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5541), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5549), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5728), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5736), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5744), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5800), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5823), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5831), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5838), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5846), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5855), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5863), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5879), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5905), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(5998), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6006), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6022), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6038), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6047), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6055), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6107), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6114), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6129), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6144), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6152), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6159), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6175), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6183), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6191), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6217), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6240), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6278), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6323), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6339), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6354), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6374), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6383), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6398), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6428), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6454), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6469), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 2, 17, 21, 47, 2, 279, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(207), new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(224), new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 2, 17, 21, 47, 2, 280, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b92ae293-6057-4a78-9abe-dc2b9f17751a", "97eb4532-3e83-409e-a6f3-bbcceec0c5e7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b668c8e-99f6-4171-906d-37fb78724c2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2304028e-176a-41bc-a7f2-fddd3664f9d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "251e4921-9ff5-4092-b0ae-3ce24df0d7a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58da53ae-f365-4ff8-b127-2d75b3e386ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "667dec01-4984-4784-a324-8c90229cbfbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cc714ff-e99b-4f06-82a8-75bfc53015d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b3fa5c1-2eea-465f-8857-847dd188b04f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89f2b59b-167f-4820-971e-f45549d9b5d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8807d97-c20f-4ab7-a3ca-366b48f77374");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db3190ad-71ea-46ba-898e-661637789ce5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b92ae293-6057-4a78-9abe-dc2b9f17751a", "97eb4532-3e83-409e-a6f3-bbcceec0c5e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b92ae293-6057-4a78-9abe-dc2b9f17751a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97eb4532-3e83-409e-a6f3-bbcceec0c5e7");

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
    }
}
