using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class DomainModelsCleanUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildRecipeSortOrder",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "SearchIndex",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Recipes",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Nutrients",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Ingredients",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Allergens",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Allergens",
                newName: "Alias");

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Nutrients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Nutrients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alias",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasImage",
                table: "Allergens",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Allergens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Allergens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "crustacean.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "sesame.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "nuts.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "gluten.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "egg.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "fish.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "shellfish.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "mustard.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "celery.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "peanuts.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "milk.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Alias", "HasImage", "Icon", "SortOrder", "UserId" },
                values: new object[] { "", false, "sulphite.png", 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HasImage", "SortOrder", "UserId" },
                values: new object[] { false, 0, null });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "HasImage", "SortOrder", "UserId" },
                values: new object[] { false, 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "SortOrder", "UserId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Alias", "UserId" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 0 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Alias", "SortOrder", "Updated" },
                values: new object[] { "", 0, null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 0 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 0 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 0 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 0 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 0 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 1 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 2 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 3 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Alias", "SortOrder" },
                values: new object[] { "", 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Nutrients");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "HasImage",
                table: "Allergens");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Allergens");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Allergens");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "SearchIndex",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Recipes",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Nutrients",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Ingredients",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Allergens",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Alias",
                table: "Allergens",
                newName: "Image");

            migrationBuilder.AddColumn<int>(
                name: "ChildRecipeSortOrder",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alias",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "crustacean.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "sesame.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "nuts.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "gluten.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "egg.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "fish.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "shellfish.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "mustard.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "celery.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "peanuts.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "milk.png" });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Icon", "Image" },
                values: new object[] { "", "sulphite.png" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChildRecipeSortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChildRecipeSortOrder", "Updated" },
                values: new object[] { null, new DateTime(2024, 3, 7, 0, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChildRecipeSortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ChildRecipeSortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ChildRecipeSortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ChildRecipeSortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ChildRecipeSortOrder",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ChildRecipeSortOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ChildRecipeSortOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ChildRecipeSortOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ChildRecipeSortOrder",
                value: 4);
        }
    }
}
