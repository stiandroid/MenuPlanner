using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class ReSeedAdministrator_2ndAttempt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
