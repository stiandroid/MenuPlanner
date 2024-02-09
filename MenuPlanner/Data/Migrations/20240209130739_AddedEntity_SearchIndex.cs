using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class AddedEntity_SearchIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchIndex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchIndex", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchIndex");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 522, DateTimeKind.Local).AddTicks(5141), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4220), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4241), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4250), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4258), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4273), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4315), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4322), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4337), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4344), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4351), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9107), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9116), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9136), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9171), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9191), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9238), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9677), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9759), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9771), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9783), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9792), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9802), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9821), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9830), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9839), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9849), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9858), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9868), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9899), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9946), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9975), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9984), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9994), new DateTime(2024, 2, 7, 15, 41, 20, 525, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(3), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(34), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(53), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(154), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(164), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(182), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(210), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(325), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(3223), new DateTime(2024, 2, 7, 15, 41, 20, 526, DateTimeKind.Local).AddTicks(3532) });
        }
    }
}
