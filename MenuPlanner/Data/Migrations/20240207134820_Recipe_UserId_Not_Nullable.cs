using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Recipe_UserId_Not_Nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 832, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4461), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4517), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4524), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4534), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4544), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4549), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8779), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8802), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8810), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8818), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9172), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9188), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9195), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9203), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9226), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9279), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9295), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9303), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9311), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9331), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9347), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9355), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9362), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9385), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9393), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9424), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9443), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9451), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9474), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9505), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9521), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9529), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9537), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9617), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9632), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9647), new DateTime(2024, 2, 7, 14, 48, 18, 835, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 836, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 2, 7, 14, 48, 18, 836, DateTimeKind.Local).AddTicks(5347), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Recipes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 710, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7532), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7554), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7559), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7564), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7569), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7586), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1915), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1923), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1931), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2013), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2045), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2089), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2509), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2523), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2539), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2554), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2562), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2578), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2586), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2637), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2657), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2667), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2687), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2698), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2716), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2732), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2754), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2763), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2809), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2839), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2871), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2879), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2910), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2925), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2933), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2972), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(6244), null });
        }
    }
}
