using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class SearchIndex_AddedName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SearchIndex",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 37, 40, 593, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 2, 9, 15, 37, 40, 593, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.InsertData(
                table: "SearchIndex",
                columns: new[] { "Id", "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[,]
                {
                    { 124, "Recipe", "Pannekaker", "pannekaker", "pannekaker" },
                    { 125, "Ingredient", "Hvetemel", "hvetemel", "hvetemel" },
                    { 126, "Ingredient", "Sammalt hvete, grovmalt", "sammalt hvete grovmalt", "sammalt-hvete-grovmalt" },
                    { 127, "Ingredient", "Sammalt hvete, finmalt", "sammalt hvete finmalt", "sammalt-hvete-finmalt" },
                    { 128, "Ingredient", "Hvete helkorn", "hvete helkorn", "hvete-helkorn" },
                    { 129, "Ingredient", "Havregryn, lettkokt", "havregryn lettkokt", "havregryn-lettkokt" },
                    { 130, "Ingredient", "Havregryn, store", "havregryn store", "havregryn-store" },
                    { 131, "Ingredient", "Havregryn, glutenfri", "havregryn glutenfri", "havregryn-glutenfri" },
                    { 132, "Ingredient", "Havremel", "havremel", "havremel" },
                    { 133, "Ingredient", "Rug, helkorn", "rug helkorn", "rug-helkorn" },
                    { 134, "Ingredient", "Rugmel", "rugmel", "rugmel" },
                    { 135, "Ingredient", "Bygg, helkorn", "bygg helkorn", "bygg-helkorn" },
                    { 136, "Ingredient", "Byggmel", "byggmel", "byggmel" },
                    { 137, "Ingredient", "Gresskarkjerner", "gresskarkjerner", "gresskarkjerner" },
                    { 138, "Ingredient", "Skummet melk", "skummet melk", "skummet-melk" },
                    { 139, "Ingredient", "Lettmelk", "lettmelk", "lettmelk" },
                    { 140, "Ingredient", "Helmelk", "helmelk", "helmelk" },
                    { 141, "Ingredient", "Kremfløte", "kremfløte", "kremflote" },
                    { 142, "Ingredient", "Matfløte", "matfløte", "matflote" },
                    { 143, "Ingredient", "Lettrømme", "lettrømme", "lettromme" },
                    { 144, "Ingredient", "Seterrømme", "seterrømme", "seterromme" },
                    { 145, "Ingredient", "Rømmekolle", "rømmekolle", "rommekolle" },
                    { 146, "Ingredient", "Kvarg", "kvarg", "kvarg" },
                    { 147, "Ingredient", "Egg", "egg", "egg" },
                    { 148, "Ingredient", "Eggeplomme", "eggeplomme", "eggeplomme" },
                    { 149, "Ingredient", "Eggehvite", "eggehvite", "eggehvite" },
                    { 150, "Ingredient", "Vaktelegg", "vaktelegg", "vaktelegg" },
                    { 151, "Ingredient", "Måsegg", "måsegg", "masegg" },
                    { 152, "Ingredient", "Salt", "salt", "salt" },
                    { 153, "Ingredient", "Tomatketsjup", "tomatketsjup", "tomatketsjup" },
                    { 154, "Ingredient", "Søt sennep", "søt sennep", "sot-sennep" },
                    { 155, "Ingredient", "Sterk sennep", "sterk sennep", "sterk-sennep" },
                    { 156, "Ingredient", "Dijonsennep", "dijonsennep", "dijonsennep" },
                    { 157, "Ingredient", "Grov sennep", "grov sennep", "grov-sennep" },
                    { 158, "Ingredient", "Soyasaus", "soyasaus", "soyasaus" },
                    { 159, "Ingredient", "Saltredusert soyasaus", "saltredusert soyasaus", "saltredusert-soyasaus" },
                    { 160, "Ingredient", "Eddikessens", "eddikessens", "eddikessens" },
                    { 161, "Ingredient", "Klar eddik", "klar eddik", "klar-eddik" },
                    { 162, "Ingredient", "Brun eddik", "brun eddik", "brun-eddik" },
                    { 163, "Ingredient", "Eplecidereddik", "eplecidereddik", "eplecidereddik" },
                    { 164, "Ingredient", "Hvitvinseddik", "hvitvinseddik", "hvitvinseddik" },
                    { 165, "Ingredient", "Rødvinseddik", "rødvinseddik", "rodvinseddik" },
                    { 166, "Ingredient", "Sitrondråper", "sitrondråper", "sitrondråper" },
                    { 167, "Ingredient", "Smør", "smør", "smor" },
                    { 168, "Ingredient", "Margarin", "margarin", "margarin" },
                    { 169, "Ingredient", "Sukker", "sukker", "sukker" },
                    { 170, "Ingredient", "Blåbær", "blåbær", "blabar" },
                    { 171, "Ingredient", "Jordbær", "jordbær", "jordbar" },
                    { 172, "Ingredient", "Bringebær", "bringebær", "bringebar" },
                    { 173, "Ingredient", "Grønne epler", "grønne epler", "gronne-epler" },
                    { 174, "Ingredient", "Røde epler", "røde epler", "rode-epler" },
                    { 175, "Ingredient", "Gule epler", "gule epler", "gule-epler" },
                    { 176, "Ingredient", "Appelsin", "appelsin", "appelsin" },
                    { 177, "Ingredient", "Sitron", "sitron", "sitron" },
                    { 178, "Ingredient", "Økologisk sitron", "økologisk sitron", "okologisk-sitron" },
                    { 179, "Ingredient", "Lime", "lime", "lime" },
                    { 180, "Ingredient", "Hermetiske mandarinbåter", "hermetiske mandarinbåter", "hermetiske-mandarinbater" },
                    { 181, "Ingredient", "Hermetiske pærer", "hermetiske pærer", "hermetiske-parer" },
                    { 182, "Ingredient", "Hermetiske fersken", "hermetiske fersken", "hermetiske-fersken" },
                    { 183, "Ingredient", "Banan", "banan", "banan" },
                    { 184, "Ingredient", "Klementin", "klementin", "klementin" },
                    { 185, "Ingredient", "Blå druer", "blå druer", "bla-druer" },
                    { 186, "Ingredient", "Grønne druer", "grønne druer", "gronne-druer" },
                    { 187, "Ingredient", "Rosiner", "rosiner", "rosiner" },
                    { 188, "Ingredient", "Korinter", "korinter", "korinter" },
                    { 189, "Nutrient", "Protein", "protein", "protein" },
                    { 190, "Nutrient", "Karbohydrater", "karbohydrater", "karbohydrater" },
                    { 191, "Nutrient", "Sukkerarter", "sukkerarter", "sukkerarter" },
                    { 192, "Nutrient", "Polyoler", "polyoler", "polyoler" },
                    { 193, "Nutrient", "Stivelse", "stivelse", "stivelse" },
                    { 194, "Nutrient", "Fett", "fett", "fett" },
                    { 195, "Nutrient", "Mettet fett", "mettet fett", "mettet-fett" },
                    { 196, "Nutrient", "Enumettet fett", "enumettet fett", "enumettet-fett" },
                    { 197, "Nutrient", "Flerumettet fett", "flerumettet fett", "flerumettet-fett" },
                    { 198, "Nutrient", "Transfett", "transfett", "transfett" },
                    { 199, "Nutrient", "Vitamin A, retinol", "vitamin a retinol", "vitamin-a-retinol" },
                    { 200, "Nutrient", "Vitamin B1, tiamin", "vitamin b1 tiamin", "vitamin-b1-tiamin" },
                    { 201, "Nutrient", "Vitamin B2, riboflavin", "vitamin b2 riboflavin", "vitamin-b2-riboflavin" },
                    { 202, "Nutrient", "Vitamin B3, niacin", "vitamin b3 niacin", "vitamin-b3-niacin" },
                    { 203, "Nutrient", "Vitamin B5, pantotensyre", "vitamin b5 pantotensyre", "vitamin-b5-pantotensyre" },
                    { 204, "Nutrient", "Vitamin B7, biotin", "vitamin b7 biotin", "vitamin-b7-biotin" },
                    { 205, "Nutrient", "Vitamin B9, folat", "vitamin b9 folat", "vitamin-b9-folat" },
                    { 206, "Nutrient", "Vitamin B12, kobalamin", "vitamin b12 kobalamin", "vitamin-b12-kobalamin" },
                    { 207, "Nutrient", "Vitamin C, askorbinsyre", "vitamin c askorbinsyre", "vitamin-c-askorbinsyre" },
                    { 208, "Nutrient", "Vitamin D2, ergokalsiferol", "vitamin d2 ergokalsiferol", "vitamin-d2-ergokalsiferol" },
                    { 209, "Nutrient", "Vitamin D3, kolikalsiferol", "vitamin d3 kolikalsiferol", "vitamin-d3-kolikalsiferol" },
                    { 210, "Nutrient", "Vitamin E, tokoferol (E306)", "vitamin e tokoferol e306", "vitamin-e-tokoferol-e306" },
                    { 211, "Nutrient", "Vitamin K1, fyllokinon", "vitamin k1 fyllokinon", "vitamin-k1-fyllokinon" },
                    { 212, "Nutrient", "Vitamin K2, menakinon", "vitamin k2 menakinon", "vitamin-k2-menakinon" },
                    { 213, "Nutrient", "Kalium", "kalium", "kalium" },
                    { 214, "Nutrient", "Klorin", "klorin", "klorin" },
                    { 215, "Nutrient", "Natrium", "natrium", "natrium" },
                    { 216, "Nutrient", "Kalsium", "kalsium", "kalsium" },
                    { 217, "Nutrient", "Fosfor", "fosfor", "fosfor" },
                    { 218, "Nutrient", "Magnesium", "magnesium", "magnesium" },
                    { 219, "Nutrient", "Jern", "jern", "jern" },
                    { 220, "Nutrient", "Sink", "sink", "sink" },
                    { 221, "Nutrient", "Mangan", "mangan", "mangan" },
                    { 222, "Nutrient", "Kobber", "kobber", "kobber" },
                    { 223, "Nutrient", "Jod", "jod", "jod" },
                    { 224, "Nutrient", "Molybden", "molybden", "molybden" },
                    { 225, "Nutrient", "Selen", "selen", "selen" },
                    { 226, "Nutrient", "Fluor", "fluor", "fluor" },
                    { 227, "Nutrient", "Krom", "krom", "korm" },
                    { 228, "Nutrient", "Nikkel", "nikkel", "nikkel" },
                    { 229, "Nutrient", "Bor", "bor", "bor" },
                    { 230, "Nutrient", "Silisium", "silisium", "silisium" },
                    { 231, "Nutrient", "Vanadium", "vanadium", "vanadium" },
                    { 232, "Nutrient", "Salt", "salt", "salt" },
                    { 233, "Allergen", "Krepsdyr", "krepsdyr", "krepsdyr" },
                    { 234, "Allergen", "Sesamfrø", "sesamfrø", "sesamfro" },
                    { 235, "Allergen", "Nøtter", "nøtter", "notter" },
                    { 236, "Allergen", "Gluten", "gluten", "gluten" },
                    { 237, "Allergen", "Egg", "egg", "egg" },
                    { 238, "Allergen", "Fisk", "fisk", "fisk" },
                    { 239, "Allergen", "Skalldyr", "skalldyr", "skalldyr" },
                    { 240, "Allergen", "Sennep", "sennep", "sennep" },
                    { 241, "Allergen", "Selleri", "selleri", "selleri" },
                    { 242, "Allergen", "Peanøtter", "peanøtter", "peanotter" },
                    { 243, "Allergen", "Melk", "melk", "melk" },
                    { 244, "Allergen", "Sulfitt", "sulfitt", "sulfitt" },
                    { 245, "Allergen", "Soya", "soya", "soya" },
                    { 246, "Allergen", "Lupin", "lupin", "lupin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SearchIndex");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 469, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6885), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6892), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6899), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6906), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6912), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 472, DateTimeKind.Local).AddTicks(9704), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2148), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2158), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2169), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2232), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2262), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2273), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2283), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2719), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2739), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2794), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2805), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2815), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2825), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2836), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2846), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2926), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2969), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3004), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3014), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3035), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3055), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3065), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3076), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3107), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3118), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3128), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3152), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3183), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3194), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3225), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3234), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3245), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3266), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3315), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3390), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(6815), new DateTime(2024, 2, 9, 14, 7, 38, 473, DateTimeKind.Local).AddTicks(7206) });
        }
    }
}
