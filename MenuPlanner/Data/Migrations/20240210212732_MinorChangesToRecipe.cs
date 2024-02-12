using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class MinorChangesToRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 234, DateTimeKind.Local).AddTicks(1554), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3178), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3184), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3190), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3196), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3203), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3209), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3244), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3256), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7582), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7591), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7601), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7727), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7751), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7761), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7779), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7788), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7797), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8177), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8186), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8205), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8214), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8253), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8263), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8291), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8319), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8346), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8355), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8395), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8516), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8574), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8607), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8617), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8654), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8682), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8758), new DateTime(2024, 2, 10, 22, 27, 31, 237, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 39,
                column: "Url",
                value: "krom");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 10, 22, 27, 31, 238, DateTimeKind.Local).AddTicks(1200), new DateTime(2024, 2, 10, 22, 27, 31, 238, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 227,
                column: "Url",
                value: "krom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 589, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3266), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3301), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3310), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3327), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3415), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3426), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(6535), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8687), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8703), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8711), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8742), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8803), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9253), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9269), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9277), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9357), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9383), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9398), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9429), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9467), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9475), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9498), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9506), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9526), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9534), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9587), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9604), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9612), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9619), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9636), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9643), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9651), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9659), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9667), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 2, 9, 15, 37, 40, 592, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 39,
                column: "Url",
                value: "korm");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MainImage" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 593, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 2, 9, 15, 37, 40, 593, DateTimeKind.Local).AddTicks(2827), null });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 227,
                column: "Url",
                value: "korm");
        }
    }
}
