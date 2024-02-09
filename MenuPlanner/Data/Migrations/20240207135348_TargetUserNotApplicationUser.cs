using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class TargetUserNotApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Introduction",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasProfileImage",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasBackgropImage",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 2, 7, 14, 53, 47, 14, DateTimeKind.Local).AddTicks(6762) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Introduction",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "HasProfileImage",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasBackgropImage",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 14, 48, 18, 836, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 2, 7, 14, 48, 18, 836, DateTimeKind.Local).AddTicks(5347) });
        }
    }
}
