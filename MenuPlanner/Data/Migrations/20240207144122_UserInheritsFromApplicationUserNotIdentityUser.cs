using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class UserInheritsFromApplicationUserNotIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 73, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8030), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8046), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8084), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8104), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Allergens",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 2, 7, 15, 17, 31, 75, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2152), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2208), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2216), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2231), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2239), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2254), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2262), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2606), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2655), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2662), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2670), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2732), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2765), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2789), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2808), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2848), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2872), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2888), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2924), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2931), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2939), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2971), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2979), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2995), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3050), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3087), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 2, 7, 15, 17, 31, 76, DateTimeKind.Local).AddTicks(6065) });
        }
    }
}
