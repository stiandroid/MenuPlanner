using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Role_AddedSortOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "AspNetRoles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 438, DateTimeKind.Local).AddTicks(5035), new DateTime(2024, 2, 22, 14, 34, 48, 441, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1855), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1890), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1939), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2011), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2036), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2048), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2060), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2076), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7783), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7848), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7862), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7935), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7966), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8532), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8679), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8879), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8892), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8905), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8935), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8982), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9015), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9027), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9055), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9068), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9094), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9108), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9121), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9148), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9192), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9250), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9264), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9279), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9293), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9351), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9461), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9537), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9550), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9562), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9575), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9616), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9630), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9653), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9689), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9702), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9718), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9761), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9783), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9822), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9842), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9856), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9896), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 2, 22, 14, 34, 48, 442, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(34), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(72), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(85), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(97), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(123), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(135), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(199), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(256), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(283), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(297), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(323), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(349), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(437), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(480), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(614), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(656), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(689), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(754), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(5005), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7463), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7493), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7533), new DateTime(2024, 2, 22, 14, 34, 48, 443, DateTimeKind.Local).AddTicks(7537) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 539, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7725), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7840), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7854), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7867), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7880), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7897), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7910), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7929), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7960), new DateTime(2024, 2, 22, 13, 0, 4, 543, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(1092), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5617), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5633), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5802), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5816), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6503), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6579), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6593), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6608), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6641), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6672), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6716), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6772), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6881), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6894), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6923), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6936), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7228), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7254), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7269), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7285), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7355), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7369), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7424), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7441), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7459), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7497), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7529), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7648), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7661), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7675), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7746), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7772), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7829), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7842), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7854), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7867), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7881), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7955), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7971), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7983), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8011), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8028), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8053), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8067), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8122), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8151), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8166), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8872), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8907), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8923), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8939), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8965), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8991), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9016), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9029), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9103), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9114), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9138), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9270), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9408), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 2, 22, 13, 0, 4, 544, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(1926), new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5593), new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 2, 22, 13, 0, 4, 546, DateTimeKind.Local).AddTicks(5643) });
        }
    }
}
