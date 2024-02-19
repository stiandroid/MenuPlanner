using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class NewEntity_Role_ExtendsIdentityRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0993cc48-9285-46de-a41a-9b83d6b2dedc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "228aa0bf-f99c-4410-931f-3c8021234e6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c29b0dd-a4cd-40f9-9251-02ed4fefe6bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d06d13f-da1f-424f-bdd3-18b7e0e7ac03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b78512b-a418-41f4-abc5-20d3c2c13742");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cc74d2a-2abd-461f-9418-edbd6f56cd97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "624d12e0-4722-4d41-ae83-0778edad0e86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a17f83ae-0cd9-4549-86cf-0c40c53f2c9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78dc326-2771-458d-9ebd-bf8e030abb5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb61637a-2b7d-444b-a7cf-039d810bb341");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f66d106a-d729-4e84-a71c-99402cbe1fcb");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 691, DateTimeKind.Local).AddTicks(3435), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9948), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9991), new DateTime(2024, 2, 18, 0, 45, 21, 693, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(22), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(71), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0993cc48-9285-46de-a41a-9b83d6b2dedc", null, "SysAdmin", "SYSADMIN" },
                    { "228aa0bf-f99c-4410-931f-3c8021234e6d", null, "ArticleMod", "ARTICLEMOD" },
                    { "2c29b0dd-a4cd-40f9-9251-02ed4fefe6bb", null, "IngredientMod", "INGREDIENTMOD" },
                    { "2d06d13f-da1f-424f-bdd3-18b7e0e7ac03", null, "AllergenAdmin", "ALLERGENADMIN" },
                    { "3b78512b-a418-41f4-abc5-20d3c2c13742", null, "UserAdmin", "USERADMIN" },
                    { "4cc74d2a-2abd-461f-9418-edbd6f56cd97", null, "RecipeEditor", "RECIPEEDITOR" },
                    { "624d12e0-4722-4d41-ae83-0778edad0e86", null, "CommunityMod", "COMMUNITYMOD" },
                    { "a17f83ae-0cd9-4549-86cf-0c40c53f2c9b", null, "IngredientEditor", "INGREDIENTEDITOR" },
                    { "c78dc326-2771-458d-9ebd-bf8e030abb5e", null, "ArticleEditor", "ARTICLEEDITOR" },
                    { "cb61637a-2b7d-444b-a7cf-039d810bb341", null, "NutrientAdmin", "NUTRIENTADMIN" },
                    { "f66d106a-d729-4e84-a71c-99402cbe1fcb", null, "RecipeMod", "RECIPEMOD" }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(2783), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5945), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5981), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6005), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6031), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6061), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6823), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6838), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6875), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6883), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6893), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6901), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6911), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6952), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6961), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6989), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(6999), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7142), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7256), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7264), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7273), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7352), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7363), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7474), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7489), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7526), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7534), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7557), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7565), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7601), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7610), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7617), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7627), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7635), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7655), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7665), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7682), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7716), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7795), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7803), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7819), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7852), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7868), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7876), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7883), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7904), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7912), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7920), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7937), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7944), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7954), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7963), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7983), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7994), new DateTime(2024, 2, 18, 0, 45, 21, 694, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2261), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2314), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2325), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 2, 18, 0, 45, 21, 695, DateTimeKind.Local).AddTicks(2335) });
        }
    }
}
