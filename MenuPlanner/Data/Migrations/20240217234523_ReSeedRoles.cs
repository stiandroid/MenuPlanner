using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class ReSeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05a2b555-2f16-4496-b300-8a3b4839932d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "186224e2-74fb-4111-9ab8-1785336a7051");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1891c655-dd35-4a26-b482-d66e600fa699");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22c5a5f1-01f8-4175-afd9-a308aae251e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63c80632-e89e-4b02-9a17-625b5de64bcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8200bef0-d1c2-4177-9071-d76097999119");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86b69eb5-29b7-4813-b6a9-f51ca7a473ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bfcb6c-f662-4fc5-b927-2c32dfe2ad72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9d37e42-63f6-4ba1-a246-2bab903567a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deb1f5fc-64d4-4caa-ab1b-059d5ae46e58");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 691, DateTimeKind.Local).AddTicks(3435), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9948), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9991), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0993cc48-9285-46de-a41a-9b83d6b2dedc", null, "SysAdmin", "SYSADMIN" },
                    { "228aa0bf-f99c-4410-931f-3c8021234e6d", null, "ArticleMod", "ARTICLEMOD" },
                    { "2c29b0dd-a4cd-40f9-9251-02ed4fefe6bb", null, "IngredientMod", "INGREDIENTMOD" },
                    { "2d06d13f-da1f-424f-bdd3-18b7e0e7ac03", null, "AllergenAdmin", "ALLERGENADMIN" },
                    { "3b78512b-a418-41f4-abc5-20d3c2c13742", null, "UserAdmin", "USERADMIN" },
                    { "4cc74d2a-2abd-461f-9418-edbd6f56cd97", null, "RecipeEditor", "RECIPEEDITOR" },
                    { "624d12e0-4722-4d41-ae83-0778edad0e86", null, "CommunityMod", "COMMUNITYMOD" },
                    { "a17f83ae-0cd9-4549-86cf-0c40c53f2c9b", null, "IngredientEditor", "INGREDIENTEDITOR" },
                    { "c78dc326-2771-458d-9ebd-bf8e030abb5e", null, "ArticleEditor", "ARTICLEEDITOR" },
                    { "cb61637a-2b7d-444b-a7cf-039d810bb341", null, "NutrientAdmin", "NUTRIENTADMIN" },
                    { "f66d106a-d729-4e84-a71c-99402cbe1fcb", null, "RecipeMod", "RECIPEMOD" }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(2783), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5945), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6031), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6061), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6823), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6875), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6883), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6893), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6901), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6911), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6952), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6961), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6989), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6999), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7256), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7264), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7273), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7352), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7363), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7474), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7489), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7526), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7557), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7565), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7601), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7617), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7627), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7635), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7655), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7665), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7682), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7716), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7795), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7803), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7819), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7852), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7868), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7912), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7937), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7944), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7954), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7963), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7983), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7994), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2325), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2335) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0993cc48-9285-46de-a41a-9b83d6b2dedc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "228aa0bf-f99c-4410-931f-3c8021234e6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c29b0dd-a4cd-40f9-9251-02ed4fefe6bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d06d13f-da1f-424f-bdd3-18b7e0e7ac03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b78512b-a418-41f4-abc5-20d3c2c13742");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cc74d2a-2abd-461f-9418-edbd6f56cd97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "624d12e0-4722-4d41-ae83-0778edad0e86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17f83ae-0cd9-4549-86cf-0c40c53f2c9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78dc326-2771-458d-9ebd-bf8e030abb5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb61637a-2b7d-444b-a7cf-039d810bb341");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f66d106a-d729-4e84-a71c-99402cbe1fcb");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 122, DateTimeKind.Local).AddTicks(608), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9357), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9395), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9421), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9517), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9530), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9540), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 2, 17, 23, 45, 21, 125, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05a2b555-2f16-4496-b300-8a3b4839932d", null, "AllergenAdmin", "ALLERGENADMIN" },
                    { "186224e2-74fb-4111-9ab8-1785336a7051", null, "RecipeMod", "RECIPEMOD" },
                    { "1891c655-dd35-4a26-b482-d66e600fa699", null, "NutrientAdmin", "NUTRIENTADMIN" },
                    { "22c5a5f1-01f8-4175-afd9-a308aae251e6", null, "RecipeEditor", "RECIPEEDITOR" },
                    { "63c80632-e89e-4b02-9a17-625b5de64bcc", null, "CommunityMod", "COMMUNITYMOD" },
                    { "8200bef0-d1c2-4177-9071-d76097999119", null, "IngredientMod", "INGREDIENTMOD" },
                    { "86b69eb5-29b7-4813-b6a9-f51ca7a473ab", null, "ArticleEditor", "ARTICLEEDITOR" },
                    { "a9bfcb6c-f662-4fc5-b927-2c32dfe2ad72", null, "UserAdmin", "USERADMIN" },
                    { "d9d37e42-63f6-4ba1-a246-2bab903567a9", null, "IngredientEditor", "INGREDIENTEDITOR" },
                    { "deb1f5fc-64d4-4caa-ab1b-059d5ae46e58", null, "ArticleMod", "ARTICLEMOD" }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(1720), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4262), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4287), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4312), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4325), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4348), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4427), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4438), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5017), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5034), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5052), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5076), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5088), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5101), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5113), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5164), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5280), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5317), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5329), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5343), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5365), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5378), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5389), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5418), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5430), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5443), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5469), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5483), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5498), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5527), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5542), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5567), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5581), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5593), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5677), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5739), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5764), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5801), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5813), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5842), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5853), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5865), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5876), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5913), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5924), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5956), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5996), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6007), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6034), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6060), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6089), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6100), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6299), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6354), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6365), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6377), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6405), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6434), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6482), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6497), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6511), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6565), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6579), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6591), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6614), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6640), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6662), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6673), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6684), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6696), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6719), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6836), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6876), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6887), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 2, 17, 23, 45, 21, 126, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(449), new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2854), new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 2, 17, 23, 45, 21, 127, DateTimeKind.Local).AddTicks(2902) });
        }
    }
}
