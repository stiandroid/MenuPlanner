using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Role_Remove_Property_Icon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 3, 4, 14, 12, 1, 581, DateTimeKind.Local).AddTicks(772) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655) });
        }
    }
}
