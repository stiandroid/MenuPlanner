using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Role_AddedGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "AspNetRoles",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 468, DateTimeKind.Local).AddTicks(5744), new DateTime(2024, 2, 19, 11, 35, 56, 470, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(881), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(944), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(954), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(969), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(978), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(985), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1009), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1016), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(2838), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4906), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4913), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4947), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4956), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4964), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4972), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4979), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4995), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5352), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5366), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5397), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5406), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5469), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5478), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5485), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5493), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5509), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5516), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5524), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5540), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5548), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5575), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5593), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5678), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5790), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5798), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5806), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5837), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5845), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5876), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5884), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5891), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5908), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5931), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5947), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5955), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6012), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6027), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6098), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6107), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6123), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6130), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6138), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6157), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6165), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6187), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6195), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6202), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6210), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6218), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6234), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6241), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6283), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6290), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6305), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6313), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6321), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6336), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6343), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6351), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6367), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6374), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6440), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6448), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6456), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6471), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6479), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6486), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6502), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6510), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6520), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6528), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 2, 19, 11, 35, 56, 471, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(648), new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(655), new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 2, 19, 11, 35, 56, 472, DateTimeKind.Local).AddTicks(674) });
        }
    }
}
