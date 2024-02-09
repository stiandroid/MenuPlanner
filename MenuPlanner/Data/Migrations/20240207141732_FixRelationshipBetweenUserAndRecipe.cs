using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class FixRelationshipBetweenUserAndRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId1",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_UserId1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 73, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8084), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8104), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2152), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2208), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2231), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2239), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2254), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2262), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2606), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2655), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2662), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2670), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2732), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2765), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2789), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2808), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2848), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2872), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2888), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2924), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2931), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2995), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3087), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(6065), null });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 10, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7395), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7435), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7442), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7453), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7486), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7492), new DateTime(2024, 2, 7, 14, 53, 47, 13, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(55), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2232), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2355), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2368), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2387), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2428), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2472), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2515), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3094), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3125), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3134), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3144), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3153), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3183), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3203), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3213), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3260), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3270), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3308), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3315), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3323), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3331), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3338), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3387), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3415), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3423), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3431), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3453), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3461), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3468), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3475), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3483), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3499), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3517), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3525), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3540), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3554), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3562), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId", "UserId1" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(6762), 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId1",
                table: "Recipes",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId1",
                table: "Recipes",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
