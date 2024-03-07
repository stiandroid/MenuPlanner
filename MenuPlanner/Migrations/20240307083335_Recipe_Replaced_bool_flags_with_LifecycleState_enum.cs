using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Recipe_Replaced_bool_flags_with_LifecycleState_enum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 112, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 115, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 117, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 119, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 123, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 126, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 139, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 146, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 100, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 101, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 102, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 107, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 108, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 111, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 143, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 153, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 158, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 159, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 164, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 165, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 167, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 170, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 172, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 8 });

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DropColumn(
                name: "IsDraft",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 8 },
                columns: new[] { "Amount", "SortOrder" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "Notes", "SortOrder", "Unit" },
                values: new object[,]
                {
                    { 79, 3, 1.0, null, 12, 12 },
                    { 89, 3, 1.0, null, 4, 10 },
                    { 92, 3, 4.0, null, 1, 2 },
                    { 94, 3, 2.0, null, 3, 12 },
                    { 95, 3, 3.0, null, 2, 9 },
                    { 98, 3, 50.0, null, 7, 0 },
                    { 112, 3, 0.5, null, 5, 12 },
                    { 115, 3, 0.5, null, 6, 9 },
                    { 117, 3, 3.0, null, 13, 12 },
                    { 119, 3, 4.0, null, 8, 2 },
                    { 123, 3, 1.0, null, 9, 12 },
                    { 126, 3, 3.0, null, 11, 12 },
                    { 139, 3, 400.0, null, 10, 0 },
                    { 146, 3, 2.0, null, 14, 10 },
                    { 27, 6, 200.0, null, 9, 0 },
                    { 44, 6, 150.0, null, 10, 0 },
                    { 99, 6, 0.5, null, 2, 12 },
                    { 100, 6, 0.5, null, 3, 12 },
                    { 101, 6, 0.5, null, 4, 12 },
                    { 102, 6, 0.5, null, 8, 12 },
                    { 107, 6, 200.0, null, 7, 0 },
                    { 108, 6, 3.0, null, 6, 12 },
                    { 111, 6, 0.5, null, 5, 12 },
                    { 143, 6, 400.0, null, 1, 0 },
                    { 153, 8, 2.0, null, 9, 9 },
                    { 158, 8, 0.5, null, 2, 10 },
                    { 159, 8, 0.5, null, 3, 10 },
                    { 164, 8, 2.0, null, 1, 10 },
                    { 165, 8, 0.5, null, 5, 9 },
                    { 167, 8, 1.0, null, 6, 9 },
                    { 170, 8, 0.5, null, 8, 9 },
                    { 172, 8, 2.0, null, 7, 9 },
                    { 1, 9, 1.0, null, 4, 2 },
                    { 2, 9, 225.0, null, 1, 0 },
                    { 46, 9, 0.5, null, 2, 9 },
                    { 61, 9, 60.0, null, 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "RecipeNotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecipeId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "RecipeSteps",
                keyColumn: "Id",
                keyValue: 8,
                column: "RecipeId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "State",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryCode", "Created", "Description", "DifficultyLevel", "Name", "RatingAverage", "State", "Updated", "Url" },
                values: new object[] { "NO", new DateTime(2024, 3, 7, 0, 9, 0, 0, DateTimeKind.Unspecified), "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy, bananskiver og kondensert melk, eller sukker og sitrondråper.", 0, "Pannekaker", 7.4000000000000004, 0, new DateTime(2024, 3, 7, 0, 9, 0, 0, DateTimeKind.Unspecified), "pannekaker" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryCode", "Description", "Name", "PrepTime", "RatingAverage", "State", "Url" },
                values: new object[] { "TH", "En fantastisk smakfull kyllingsuppe.", "Tom Kha Gai", new TimeSpan(0, 1, 0, 0, 0), 8.0999999999999996, 2, "tom-kha-gai" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryCode", "Description", "DifficultyLevel", "Name", "PrepTime", "RatingAverage", "State", "Url" },
                values: new object[] { "IT", "En enkel men utrolig god, klassisk pastarett.", 1, "Cacio e Pepe", new TimeSpan(0, 0, 20, 0, 0), 8.0, 2, "cacio-e-pepe" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryCode", "Description", "DifficultyLevel", "Name", "PrepTime", "RatingAverage", "State", "Url" },
                values: new object[] { "NO", "Den kjente og kjære norske klassikeren, akkurat som mamma lagde den.", 0, "Kjøttkaker med kålstuing", new TimeSpan(0, 1, 0, 0, 0), 7.2999999999999998, 2, "kjottkaker-med-kalstuing" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryCode", "Description", "Name", "RatingAverage", "State", "Url" },
                values: new object[] { "MX", "Taco fra grunnen av! Hjemmelagde hvetetortillas, tacokrydder, guacamole og salsa. Denne oppskriften legger grunnlaget for en god helg!", "Taco", 9.5, 2, "taco" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChildRecipeSortOrder", "CountryCode", "Description", "DifficultyLevel", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "State", "Url" },
                values: new object[] { null, "NO", "Saftig og smaksrik.", 1, "Ovnsbakt hel ørret", null, new TimeSpan(0, 1, 30, 0, 0), 8.0, 2, "ovnsbakt-hel-orret" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ChildRecipeSortOrder", "Description", "DifficultyLevel", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "State", "Url" },
                values: new object[] { 1, "Smakfullt tex-mex-krydder.", 0, "Tacokrydder", 6, new TimeSpan(0, 0, 0, 10, 0), 8.6999999999999993, 2, "tacokrydder" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChildRecipeSortOrder", "Description", "DifficultyLevel", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "State", "Url" },
                values: new object[] { 2, "Myke og deilige hvetetortillas! Perfekte til fredagstaco, laksewrap eller kyllingburrito!", 1, "Hvetetortillas", 6, new TimeSpan(0, 0, 30, 0, 0), 8.9000000000000004, 2, "hvetetortillas" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChildRecipeSortOrder", "Description", "Name", "ParentRecipeId", "RatingAverage", "State", "Url" },
                values: new object[] { 3, "Frisk og smakfull guacamole som er perfekt tilbehør til fredagstacoen!", "Guacamole", 6, 9.6999999999999993, 2, "guacamole" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "ChildRecipeSortOrder", "CountryCode", "Created", "Description", "DifficultyLevel", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "State", "Updated", "Url", "UserId" },
                values: new object[] { 11, 4, "MX", new DateTime(2024, 3, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), "Nydelig tomatsalsa som er perfekt tilbehør til fredagstacoen! Ha i chili etter smak, eller dropp chili for en mild salsa.", 0, "Tomatsalsa", 6, new TimeSpan(0, 0, 0, 10, 0), 9.5999999999999996, 2, new DateTime(2024, 3, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), "tomat-salsa", null });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Pannekaker", "pannekaker", "pannekaker" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Pannekaker", "pannekaker", "pannekaker" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tom Kha Gai", "tom kha gai", "tom-kha-gai" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Cacio e Pepe", "cacio e pepe", "cacio-e-pepe" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kjøttkaker med kålstuing", "kjøttkaker med kålstuing", "kjottkaker-med-kalstuing" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Recipe", "Taco", "taco", "taco" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Recipe", "Ovnsbakt hel ørret", "ovnsbakt hel ørret", "ovnsbakt-hel-orret" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vann", "vann", "vann" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvetemel", "hvetemel", "hvetemel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Pizzamel, tipo-00", "pizzamel tipo00", "pizzamel-tipo-00" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Brødmel, tipo-0", "brødmel tipo0", "brodmel-tipo-0" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Semulegryn", "semulegryn", "semulegryn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sammalt hvete, grovmalt", "sammalt hvete grovmalt", "sammalt-hvete-grovmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sammalt hvete, finmalt", "sammalt hvete finmalt", "sammalt-hvete-finmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvete helkorn", "hvete helkorn", "hvete-helkorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havregryn, lettkokt", "havregryn lettkokt", "havregryn-lettkokt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havregryn, store", "havregryn store", "havregryn-store" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havregryn, glutenfri", "havregryn glutenfri", "havregryn-glutenfri" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havremel", "havremel", "havremel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rug, helkorn", "rug helkorn", "rug-helkorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rugmel", "rugmel", "rugmel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Bygg, helkorn", "bygg helkorn", "bygg-helkorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Byggmel", "byggmel", "byggmel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gresskarkjerner", "gresskarkjerner", "gresskarkjerner" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Skummet melk", "skummet melk", "skummet-melk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lettmelk", "lettmelk", "lettmelk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Helmelk", "helmelk", "helmelk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kremfløte", "kremfløte", "kremflote" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Matfløte", "matfløte", "matflote" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lettrømme", "lettrømme", "lettromme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Seterrømme", "seterrømme", "seterromme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rømmekolle", "rømmekolle", "rommekolle" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kvarg", "kvarg", "kvarg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gulost", "gulost", "gulost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Edamer", "edamer", "edamer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gouda", "gouda", "gouda" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Brie", "brie", "brie" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kremost", "kremost", "kremost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Cottage cheese", "cottage cheese", "cottage-cheese" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Ricotta", "ricotta", "ricotta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Halloumi", "halloumi", "halloumi" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Mozzarella", "mozzarella", "mozzarella" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Cheddar", "cheddar", "cheddar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Geitost", "geitost", "geitost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fløtemysost", "fløtemysost", "flotemysost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Egg", "egg", "egg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eggeplomme", "eggeplomme", "eggeplomme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eggehvite", "eggehvite", "eggehvite" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vaktelegg", "vaktelegg", "vaktelegg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Måsegg", "måsegg", "masegg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tortillachips", "tortillachips", "tortillachips" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Nachochips", "nachochips", "nachochips" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Salt", "salt", "salt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tomatketsjup", "tomatketsjup", "tomatketsjup" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Søt sennep", "søt sennep", "sot-sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sterk sennep", "sterk sennep", "sterk-sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Dijonsennep", "dijonsennep", "dijonsennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grov sennep", "grov sennep", "grov-sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Soyasaus", "soyasaus", "soyasaus" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Saltredusert soyasaus", "saltredusert soyasaus", "saltredusert-soyasaus" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eddikessens", "eddikessens", "eddikessens" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Klar eddik", "klar eddik", "klar-eddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Brun eddik", "brun eddik", "brun-eddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eplecidereddik", "eplecidereddik", "eplecidereddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitvinseddik", "hvitvinseddik", "hvitvinseddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rødvinseddik", "rødvinseddik", "rodvinseddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sitrondråper", "sitrondråper", "sitrondråper" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Smør", "smør", "smor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Margarin", "margarin", "margarin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rapsolje", "rapsolje", "rapsolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Maisolje", "maisolje", "maisolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Olivenolje", "olivenolje", "Olivenolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sesamolje", "sesamolje", "sesamolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosolje", "kokosolje", "kokosolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Frityrolje", "frityrolje", "frityrolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sukker", "sukker", "sukker" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Blåbær", "blåbær", "blabar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Jordbær", "jordbær", "jordbar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Bringebær", "bringebær", "bringebar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønne epler", "grønne epler", "gronne-epler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Røde epler", "røde epler", "rode-epler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gule epler", "gule epler", "gule-epler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Appelsin", "appelsin", "appelsin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sitron", "sitron", "sitron" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Økologisk sitron", "økologisk sitron", "okologisk-sitron" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lime", "lime", "lime" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske mandarinbåter", "hermetiske mandarinbåter", "hermetiske-mandarinbater" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske pærer", "hermetiske pærer", "hermetiske-parer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske fersken", "hermetiske fersken", "hermetiske-fersken" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Banan", "banan", "banan" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Klementin", "klementin", "klementin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Blå druer", "blå druer", "bla-druer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønne druer", "grønne druer", "gronne-druer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rosiner", "rosiner", "rosiner" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Korinter", "korinter", "korinter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fiskesaus", "fiskesaus", "fiskesaus" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosmelk", "kokosmelk", "kokosmelk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosmelk, lett", "kokosmelk lett", "kokosmelk-lett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokoskrem", "kokoskrem", "kokoskrem" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosmasse", "kokosmasse", "kokosmasse" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sitrongress", "sitrongress", "sitrongress" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rød currypasta", "rød currypasta", "rod-currypasta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønn currypasta", "grønn currypasta", "gronn-currypasta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gul currypasta", "gul currypasta", "gul-currypasta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Galangal", "galangal", "galangal" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rød paprika", "rød paprika", "rod-paprika" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gul paprika", "gul paprika", "gul-paprika" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønn paprika", "grønn paprika", "gronn-paprika" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Isbergsalat", "isbergsalat", "isbergsalat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hjertesalat", "hjertesalat", "hjertesalat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lollosalat", "lollosalat", "lollosalat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Maiskolbe, fersk", "maiskolbe fersk", "maiskolbe-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetisk maiskolbe", "hermetisk maiskolbe", "hermetisk-maiskolbe" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske maiskorn", "hermetiske maiskorn", "hermetiske-maiskorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Plommetomat", "plommetomat", "plommetomat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kirsebærtomat", "kirsebærtomat", "kirsebartomat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tomat", "tomat", "tomat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Slangeagurk", "slangeagurk", "slangeagurk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gul løk", "gul løk", "gul-lok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rødløk", "rødløk", "rodlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chalottløk", "chalottløk", "chalottlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitløk", "hvitløk", "hvitlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Salatløk", "salatløk", "salatlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vårløk", "vårløk", "varlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Purre", "purre", "purre" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingkraft", "kyllingkraft", "kyllingkraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Storfekraft", "storfekraft", "storfekraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fiskekraft", "fiskekraft", "fiskekraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønnsakskraft", "grønnsakskraft", "gronnsakskraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chili, serrano", "chili serrano", "chili-serrano" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chili, habanero", "chili habanero", "chili-habanero" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chili, birds eye", "chili birds eye", "chili-birds-eye" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Champignon, fersk", "champignon fersk", "champignon-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Champignon, hermetisk", "champignon hermetisk", "champignon-hermetisk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Aromasopp, fersk", "aromasopp fersk", "aromasopp-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Aromasopp, tørket", "aromasopp tørket", "aromasopp-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Margarin", "margarin", "margarin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling, hel grillet", "kylling hel grillet", "kylling-hel-grillet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling, hel fersk", "kylling hel fersk", "kylling-hel-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllinglår, grillet", "kyllinglår grillet", "kyllinglar-grillet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllinglår, fersk", "kyllinglår fersk", "kyllinglar-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllinglår, frossen", "kyllinglår frossen", "kyllinglar-frossen" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingvinger, grillet", "kyllingvinger grillet", "kyllingvinger-grillet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingvinger, fersk", "kyllingvinger fersk", "kyllingvinger-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingvinger, frossen", "kyllingvinger frossen", "kyllingvinger-frossen" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling lårfilet", "kylling lårfilet", "kylling-larfilet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling brystfilet", "kylling brystfilet", "kylling-brystfilet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingkjøttdeig", "kyllingkjøttdeig", "kyllingkjottdeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kjøttdeig", "kjøttdeig", "kjottdeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Karbonadedeig", "karbonadedeig", "karbonadedeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Medisterdeig", "medisterdeig", "medisterdeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Medisterfarse", "medisterfarse", "medisterfarse" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Koriander, fersk", "koriander fersk", "koriander-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Dill, fersk", "dill fersk", "dill-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gressløk, fersk", "gressløk fersk", "gresslok-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Basilikum, fersk", "basilikum fersk", "basilikum-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Thaibasilikum, fersk", "thaibasilikum fersk", "thaibasilikum-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sort pepper, hel", "sort pepper hel", "sort-pepper-hel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sort pepper, grovmalt", "sort pepper grovmalt", "sort-pepper-grovmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sort pepper, malt", "sort pepper malt", "sort-pepper-malt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvit pepper, hel", "hvit pepper hel", "hvit-pepper-hel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvit pepper, grovmalt", "hvit pepper grovmalt", "hvit-pepper-grovmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvit pepper, malt", "hvit pepper malt", "hvit-pepper-malt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Karri", "karri", "karri" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitløkspulver", "hvitløkspulver", "hvitlokspulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Løkpulver", "løkpulver", "lokpulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kanel, hel", "kanel hel", "kanel-hel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kanel, malt", "kanel malt", "kanel-malt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kardemomme", "kardemomme", "kardemomme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitløkspulver", "hvitløkspulver", "hvitlokspulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chilipulver", "chilipulver", "chilipulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chiliflak", "chiliflak", "chiliflak" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Paprikapulver", "paprikapulver", "paprikapulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Paprikapulver, røkt", "paprikapulver røkt", "paprikapulver-rokt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rosmarin, tørket", "rosmarin tørket", "rosmarin-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Dill, tørket", "dill tørket", "dill-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Oregano, tørket", "oregano tørket", "oregano-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Basilikum, tørket", "basilikum tørket", "basilikum-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Ingredient", "Spisskum", "spisskum", "spisskum" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Ingredient", "Karve", "karve", "karve" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Protein", "protein", "protein" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Karbohydrater", "karbohydrater", "karbohydrater" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sukkerarter", "sukkerarter", "sukkerarter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Polyoler", "polyoler", "polyoler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Stivelse", "stivelse", "stivelse" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fett", "fett", "fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Mettet fett", "mettet fett", "mettet-fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Enumettet fett", "enumettet fett", "enumettet-fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Flerumettet fett", "flerumettet fett", "flerumettet-fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Transfett", "transfett", "transfett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin A, retinol", "vitamin a retinol", "vitamin-a-retinol" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B1, tiamin", "vitamin b1 tiamin", "vitamin-b1-tiamin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B2, riboflavin", "vitamin b2 riboflavin", "vitamin-b2-riboflavin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B3, niacin", "vitamin b3 niacin", "vitamin-b3-niacin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B5, pantotensyre", "vitamin b5 pantotensyre", "vitamin-b5-pantotensyre" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B7, biotin", "vitamin b7 biotin", "vitamin-b7-biotin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B9, folat", "vitamin b9 folat", "vitamin-b9-folat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B12, kobalamin", "vitamin b12 kobalamin", "vitamin-b12-kobalamin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin C, askorbinsyre", "vitamin c askorbinsyre", "vitamin-c-askorbinsyre" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin D2, ergokalsiferol", "vitamin d2 ergokalsiferol", "vitamin-d2-ergokalsiferol" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin D3, kolikalsiferol", "vitamin d3 kolikalsiferol", "vitamin-d3-kolikalsiferol" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin E, tokoferol (E306)", "vitamin e tokoferol e306", "vitamin-e-tokoferol-e306" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin K1, fyllokinon", "vitamin k1 fyllokinon", "vitamin-k1-fyllokinon" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin K2, menakinon", "vitamin k2 menakinon", "vitamin-k2-menakinon" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kalium", "kalium", "kalium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Klorin", "klorin", "klorin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Natrium", "natrium", "natrium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kalsium", "kalsium", "kalsium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fosfor", "fosfor", "fosfor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Magnesium", "magnesium", "magnesium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Jern", "jern", "jern" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sink", "sink", "sink" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Mangan", "mangan", "mangan" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kobber", "kobber", "kobber" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Jod", "jod", "jod" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Molybden", "molybden", "molybden" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Selen", "selen", "selen" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fluor", "fluor", "fluor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Krom", "krom", "krom" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Nikkel", "nikkel", "nikkel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Bor", "bor", "bor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Silisium", "silisium", "silisium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Nutrient", "Vanadium", "vanadium", "vanadium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Nutrient", "Salt", "salt", "salt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Krepsdyr", "krepsdyr", "krepsdyr" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sesamfrø", "sesamfrø", "sesamfro" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Nøtter", "nøtter", "notter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gluten", "gluten", "gluten" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Egg", "egg", "egg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fisk", "fisk", "fisk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Skalldyr", "skalldyr", "skalldyr" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sennep", "sennep", "sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Selleri", "selleri", "selleri" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Peanøtter", "peanøtter", "peanotter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Melk", "melk", "melk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sulfitt", "sulfitt", "sulfitt" });

            migrationBuilder.InsertData(
                table: "SearchIndex",
                columns: new[] { "Id", "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[,]
                {
                    { 475, "Allergen", "Soya", "soya", "soya" },
                    { 476, "Allergen", "Lupin", "lupin", "lupin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 79, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 92, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 112, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 115, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 117, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 119, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 123, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 126, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 139, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 146, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 100, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 101, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 102, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 107, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 108, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 111, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 143, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 153, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 158, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 159, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 164, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 165, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 167, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 170, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 172, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 9 });

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DropColumn(
                name: "State",
                table: "Recipes");

            migrationBuilder.AddColumn<bool>(
                name: "IsDraft",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 8 },
                columns: new[] { "Amount", "SortOrder" },
                values: new object[] { 0.5, 2 });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "Notes", "SortOrder", "Unit" },
                values: new object[,]
                {
                    { 79, 2, 1.0, null, 12, 12 },
                    { 89, 2, 1.0, null, 4, 10 },
                    { 92, 2, 4.0, null, 1, 2 },
                    { 94, 2, 2.0, null, 3, 12 },
                    { 95, 2, 3.0, null, 2, 9 },
                    { 98, 2, 50.0, null, 7, 0 },
                    { 112, 2, 0.5, null, 5, 12 },
                    { 115, 2, 0.5, null, 6, 9 },
                    { 117, 2, 3.0, null, 13, 12 },
                    { 119, 2, 4.0, null, 8, 2 },
                    { 123, 2, 1.0, null, 9, 12 },
                    { 126, 2, 3.0, null, 11, 12 },
                    { 139, 2, 400.0, null, 10, 0 },
                    { 146, 2, 2.0, null, 14, 10 },
                    { 27, 5, 200.0, null, 9, 0 },
                    { 44, 5, 150.0, null, 10, 0 },
                    { 99, 5, 0.5, null, 2, 12 },
                    { 100, 5, 0.5, null, 3, 12 },
                    { 101, 5, 0.5, null, 4, 12 },
                    { 102, 5, 0.5, null, 8, 12 },
                    { 107, 5, 200.0, null, 7, 0 },
                    { 108, 5, 3.0, null, 6, 12 },
                    { 111, 5, 0.5, null, 5, 12 },
                    { 143, 5, 400.0, null, 1, 0 },
                    { 46, 7, 1.0, null, 4, 9 },
                    { 153, 7, 2.0, null, 9, 9 },
                    { 158, 7, 0.5, null, 2, 10 },
                    { 159, 7, 0.5, null, 3, 10 },
                    { 164, 7, 2.0, null, 1, 10 },
                    { 165, 7, 0.5, null, 5, 9 },
                    { 167, 7, 1.0, null, 6, 9 },
                    { 170, 7, 0.5, null, 8, 9 },
                    { 172, 7, 2.0, null, 7, 9 },
                    { 1, 8, 1.0, null, 4, 2 },
                    { 2, 8, 225.0, null, 1, 0 },
                    { 61, 8, 60.0, null, 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "RecipeNotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecipeId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "RecipeSteps",
                keyColumn: "Id",
                keyValue: 8,
                column: "RecipeId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsDraft", "IsPublished" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryCode", "Created", "Description", "DifficultyLevel", "IsDraft", "IsPublished", "Name", "RatingAverage", "Updated", "Url" },
                values: new object[] { "TH", new DateTime(2024, 3, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), "En fantastisk smakfull kyllingsuppe.", 1, false, true, "Tom Kha Gai", 8.0999999999999996, new DateTime(2024, 3, 6, 10, 30, 0, 0, DateTimeKind.Unspecified), "tom-kha-gai" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryCode", "Description", "IsDraft", "IsPublished", "Name", "PrepTime", "RatingAverage", "Url" },
                values: new object[] { "IT", "En enkel men utrolig god, klassisk pastarett.", false, true, "Cacio e Pepe", new TimeSpan(0, 0, 20, 0, 0), 8.0, "cacio-e-pepe" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryCode", "Description", "DifficultyLevel", "IsDraft", "IsPublished", "Name", "PrepTime", "RatingAverage", "Url" },
                values: new object[] { "NO", "Den kjente og kjære norske klassikeren, akkurat som mamma lagde den.", 0, false, true, "Kjøttkaker med kålstuing", new TimeSpan(0, 1, 0, 0, 0), 7.2999999999999998, "kjottkaker-med-kalstuing" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryCode", "Description", "DifficultyLevel", "IsDraft", "IsPublished", "Name", "PrepTime", "RatingAverage", "Url" },
                values: new object[] { "MX", "Taco fra grunnen av! Hjemmelagde hvetetortillas, tacokrydder, guacamole og salsa. Denne oppskriften legger grunnlaget for en god helg!", 1, false, true, "Taco", new TimeSpan(0, 1, 30, 0, 0), 9.5, "taco" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryCode", "Description", "IsDraft", "IsPublished", "Name", "RatingAverage", "Url" },
                values: new object[] { "NO", "Saftig og smaksrik.", false, true, "Ovnsbakt hel ørret", 8.0, "ovnsbakt-hel-orret" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChildRecipeSortOrder", "CountryCode", "Description", "DifficultyLevel", "IsDraft", "IsPublished", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "Url" },
                values: new object[] { 1, "MX", "Smakfullt tex-mex-krydder.", 0, false, true, "Tacokrydder", 5, new TimeSpan(0, 0, 0, 10, 0), 8.6999999999999993, "tacokrydder" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ChildRecipeSortOrder", "Description", "DifficultyLevel", "IsDraft", "IsPublished", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "Url" },
                values: new object[] { 2, "Myke og deilige hvetetortillas! Perfekte til fredagstaco, laksewrap eller kyllingburrito!", 1, false, true, "Hvetetortillas", 5, new TimeSpan(0, 0, 30, 0, 0), 8.9000000000000004, "hvetetortillas" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChildRecipeSortOrder", "Description", "DifficultyLevel", "IsDraft", "IsPublished", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "Url" },
                values: new object[] { 3, "Frisk og smakfull guacamole som er perfekt tilbehør til fredagstacoen!", 0, false, true, "Guacamole", 5, new TimeSpan(0, 0, 0, 10, 0), 9.6999999999999993, "guacamole" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChildRecipeSortOrder", "Description", "IsDraft", "IsPublished", "Name", "ParentRecipeId", "RatingAverage", "Url" },
                values: new object[] { 4, "Nydelig tomatsalsa som er perfekt tilbehør til fredagstacoen! Ha i chili etter smak, eller dropp chili for en mild salsa.", false, true, "Tomatsalsa", 5, 9.5999999999999996, "tomat-salsa" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tom Kha Gai", "tom kha gai", "tom-kha-gai" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Cacio e Pepe", "cacio e pepe", "cacio-e-pepe" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kjøttkaker med kålstuing", "kjøttkaker med kålstuing", "kjottkaker-med-kalstuing" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Taco", "taco", "taco" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Ovnsbakt hel ørret", "ovnsbakt hel ørret", "ovnsbakt-hel-orret" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Ingredient", "Vann", "vann", "vann" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Ingredient", "Hvetemel", "hvetemel", "hvetemel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Pizzamel, tipo-00", "pizzamel tipo00", "pizzamel-tipo-00" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Brødmel, tipo-0", "brødmel tipo0", "brodmel-tipo-0" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Semulegryn", "semulegryn", "semulegryn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sammalt hvete, grovmalt", "sammalt hvete grovmalt", "sammalt-hvete-grovmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sammalt hvete, finmalt", "sammalt hvete finmalt", "sammalt-hvete-finmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvete helkorn", "hvete helkorn", "hvete-helkorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havregryn, lettkokt", "havregryn lettkokt", "havregryn-lettkokt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havregryn, store", "havregryn store", "havregryn-store" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havregryn, glutenfri", "havregryn glutenfri", "havregryn-glutenfri" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Havremel", "havremel", "havremel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rug, helkorn", "rug helkorn", "rug-helkorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rugmel", "rugmel", "rugmel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Bygg, helkorn", "bygg helkorn", "bygg-helkorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Byggmel", "byggmel", "byggmel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gresskarkjerner", "gresskarkjerner", "gresskarkjerner" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Skummet melk", "skummet melk", "skummet-melk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lettmelk", "lettmelk", "lettmelk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Helmelk", "helmelk", "helmelk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kremfløte", "kremfløte", "kremflote" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Matfløte", "matfløte", "matflote" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lettrømme", "lettrømme", "lettromme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Seterrømme", "seterrømme", "seterromme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rømmekolle", "rømmekolle", "rommekolle" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kvarg", "kvarg", "kvarg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gulost", "gulost", "gulost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Edamer", "edamer", "edamer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gouda", "gouda", "gouda" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Brie", "brie", "brie" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kremost", "kremost", "kremost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Cottage cheese", "cottage cheese", "cottage-cheese" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Ricotta", "ricotta", "ricotta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Halloumi", "halloumi", "halloumi" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Mozzarella", "mozzarella", "mozzarella" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Cheddar", "cheddar", "cheddar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Geitost", "geitost", "geitost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fløtemysost", "fløtemysost", "flotemysost" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Egg", "egg", "egg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eggeplomme", "eggeplomme", "eggeplomme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eggehvite", "eggehvite", "eggehvite" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vaktelegg", "vaktelegg", "vaktelegg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Måsegg", "måsegg", "masegg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tortillachips", "tortillachips", "tortillachips" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Nachochips", "nachochips", "nachochips" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Salt", "salt", "salt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tomatketsjup", "tomatketsjup", "tomatketsjup" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Søt sennep", "søt sennep", "sot-sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sterk sennep", "sterk sennep", "sterk-sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Dijonsennep", "dijonsennep", "dijonsennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grov sennep", "grov sennep", "grov-sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Soyasaus", "soyasaus", "soyasaus" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Saltredusert soyasaus", "saltredusert soyasaus", "saltredusert-soyasaus" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eddikessens", "eddikessens", "eddikessens" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Klar eddik", "klar eddik", "klar-eddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Brun eddik", "brun eddik", "brun-eddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Eplecidereddik", "eplecidereddik", "eplecidereddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitvinseddik", "hvitvinseddik", "hvitvinseddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rødvinseddik", "rødvinseddik", "rodvinseddik" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sitrondråper", "sitrondråper", "sitrondråper" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Smør", "smør", "smor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Margarin", "margarin", "margarin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rapsolje", "rapsolje", "rapsolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Maisolje", "maisolje", "maisolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Olivenolje", "olivenolje", "Olivenolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sesamolje", "sesamolje", "sesamolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosolje", "kokosolje", "kokosolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Frityrolje", "frityrolje", "frityrolje" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sukker", "sukker", "sukker" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Blåbær", "blåbær", "blabar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Jordbær", "jordbær", "jordbar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Bringebær", "bringebær", "bringebar" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønne epler", "grønne epler", "gronne-epler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Røde epler", "røde epler", "rode-epler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gule epler", "gule epler", "gule-epler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Appelsin", "appelsin", "appelsin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sitron", "sitron", "sitron" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Økologisk sitron", "økologisk sitron", "okologisk-sitron" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lime", "lime", "lime" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske mandarinbåter", "hermetiske mandarinbåter", "hermetiske-mandarinbater" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske pærer", "hermetiske pærer", "hermetiske-parer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske fersken", "hermetiske fersken", "hermetiske-fersken" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Banan", "banan", "banan" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Klementin", "klementin", "klementin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Blå druer", "blå druer", "bla-druer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønne druer", "grønne druer", "gronne-druer" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rosiner", "rosiner", "rosiner" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Korinter", "korinter", "korinter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fiskesaus", "fiskesaus", "fiskesaus" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosmelk", "kokosmelk", "kokosmelk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosmelk, lett", "kokosmelk lett", "kokosmelk-lett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokoskrem", "kokoskrem", "kokoskrem" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kokosmasse", "kokosmasse", "kokosmasse" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sitrongress", "sitrongress", "sitrongress" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rød currypasta", "rød currypasta", "rod-currypasta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønn currypasta", "grønn currypasta", "gronn-currypasta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gul currypasta", "gul currypasta", "gul-currypasta" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Galangal", "galangal", "galangal" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rød paprika", "rød paprika", "rod-paprika" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gul paprika", "gul paprika", "gul-paprika" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønn paprika", "grønn paprika", "gronn-paprika" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Isbergsalat", "isbergsalat", "isbergsalat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hjertesalat", "hjertesalat", "hjertesalat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lollosalat", "lollosalat", "lollosalat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Maiskolbe, fersk", "maiskolbe fersk", "maiskolbe-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetisk maiskolbe", "hermetisk maiskolbe", "hermetisk-maiskolbe" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hermetiske maiskorn", "hermetiske maiskorn", "hermetiske-maiskorn" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Plommetomat", "plommetomat", "plommetomat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kirsebærtomat", "kirsebærtomat", "kirsebartomat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Tomat", "tomat", "tomat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Slangeagurk", "slangeagurk", "slangeagurk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gul løk", "gul løk", "gul-lok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rødløk", "rødløk", "rodlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chalottløk", "chalottløk", "chalottlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitløk", "hvitløk", "hvitlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Salatløk", "salatløk", "salatlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vårløk", "vårløk", "varlok" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Purre", "purre", "purre" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingkraft", "kyllingkraft", "kyllingkraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Storfekraft", "storfekraft", "storfekraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fiskekraft", "fiskekraft", "fiskekraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Grønnsakskraft", "grønnsakskraft", "gronnsakskraft" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chili, serrano", "chili serrano", "chili-serrano" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chili, habanero", "chili habanero", "chili-habanero" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chili, birds eye", "chili birds eye", "chili-birds-eye" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Champignon, fersk", "champignon fersk", "champignon-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Champignon, hermetisk", "champignon hermetisk", "champignon-hermetisk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Aromasopp, fersk", "aromasopp fersk", "aromasopp-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Aromasopp, tørket", "aromasopp tørket", "aromasopp-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Margarin", "margarin", "margarin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling, hel grillet", "kylling hel grillet", "kylling-hel-grillet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling, hel fersk", "kylling hel fersk", "kylling-hel-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllinglår, grillet", "kyllinglår grillet", "kyllinglar-grillet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllinglår, fersk", "kyllinglår fersk", "kyllinglar-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllinglår, frossen", "kyllinglår frossen", "kyllinglar-frossen" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingvinger, grillet", "kyllingvinger grillet", "kyllingvinger-grillet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingvinger, fersk", "kyllingvinger fersk", "kyllingvinger-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingvinger, frossen", "kyllingvinger frossen", "kyllingvinger-frossen" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling lårfilet", "kylling lårfilet", "kylling-larfilet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kylling brystfilet", "kylling brystfilet", "kylling-brystfilet" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kyllingkjøttdeig", "kyllingkjøttdeig", "kyllingkjottdeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kjøttdeig", "kjøttdeig", "kjottdeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Karbonadedeig", "karbonadedeig", "karbonadedeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Medisterdeig", "medisterdeig", "medisterdeig" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Medisterfarse", "medisterfarse", "medisterfarse" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Koriander, fersk", "koriander fersk", "koriander-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Dill, fersk", "dill fersk", "dill-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gressløk, fersk", "gressløk fersk", "gresslok-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Basilikum, fersk", "basilikum fersk", "basilikum-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Thaibasilikum, fersk", "thaibasilikum fersk", "thaibasilikum-fersk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sort pepper, hel", "sort pepper hel", "sort-pepper-hel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sort pepper, grovmalt", "sort pepper grovmalt", "sort-pepper-grovmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sort pepper, malt", "sort pepper malt", "sort-pepper-malt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvit pepper, hel", "hvit pepper hel", "hvit-pepper-hel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvit pepper, grovmalt", "hvit pepper grovmalt", "hvit-pepper-grovmalt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvit pepper, malt", "hvit pepper malt", "hvit-pepper-malt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Karri", "karri", "karri" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitløkspulver", "hvitløkspulver", "hvitlokspulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Løkpulver", "løkpulver", "lokpulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kanel, hel", "kanel hel", "kanel-hel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kanel, malt", "kanel malt", "kanel-malt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kardemomme", "kardemomme", "kardemomme" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Hvitløkspulver", "hvitløkspulver", "hvitlokspulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chilipulver", "chilipulver", "chilipulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Chiliflak", "chiliflak", "chiliflak" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Paprikapulver", "paprikapulver", "paprikapulver" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Paprikapulver, røkt", "paprikapulver røkt", "paprikapulver-rokt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Rosmarin, tørket", "rosmarin tørket", "rosmarin-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Dill, tørket", "dill tørket", "dill-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Oregano, tørket", "oregano tørket", "oregano-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Basilikum, tørket", "basilikum tørket", "basilikum-torket" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Spisskum", "spisskum", "spisskum" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Karve", "karve", "karve" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Nutrient", "Protein", "protein", "protein" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Nutrient", "Karbohydrater", "karbohydrater", "karbohydrater" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sukkerarter", "sukkerarter", "sukkerarter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Polyoler", "polyoler", "polyoler" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Stivelse", "stivelse", "stivelse" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fett", "fett", "fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Mettet fett", "mettet fett", "mettet-fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Enumettet fett", "enumettet fett", "enumettet-fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Flerumettet fett", "flerumettet fett", "flerumettet-fett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Transfett", "transfett", "transfett" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin A, retinol", "vitamin a retinol", "vitamin-a-retinol" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B1, tiamin", "vitamin b1 tiamin", "vitamin-b1-tiamin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B2, riboflavin", "vitamin b2 riboflavin", "vitamin-b2-riboflavin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B3, niacin", "vitamin b3 niacin", "vitamin-b3-niacin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B5, pantotensyre", "vitamin b5 pantotensyre", "vitamin-b5-pantotensyre" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B7, biotin", "vitamin b7 biotin", "vitamin-b7-biotin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B9, folat", "vitamin b9 folat", "vitamin-b9-folat" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin B12, kobalamin", "vitamin b12 kobalamin", "vitamin-b12-kobalamin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin C, askorbinsyre", "vitamin c askorbinsyre", "vitamin-c-askorbinsyre" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin D2, ergokalsiferol", "vitamin d2 ergokalsiferol", "vitamin-d2-ergokalsiferol" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin D3, kolikalsiferol", "vitamin d3 kolikalsiferol", "vitamin-d3-kolikalsiferol" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin E, tokoferol (E306)", "vitamin e tokoferol e306", "vitamin-e-tokoferol-e306" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin K1, fyllokinon", "vitamin k1 fyllokinon", "vitamin-k1-fyllokinon" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vitamin K2, menakinon", "vitamin k2 menakinon", "vitamin-k2-menakinon" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kalium", "kalium", "kalium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Klorin", "klorin", "klorin" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Natrium", "natrium", "natrium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kalsium", "kalsium", "kalsium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fosfor", "fosfor", "fosfor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Magnesium", "magnesium", "magnesium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Jern", "jern", "jern" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sink", "sink", "sink" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Mangan", "mangan", "mangan" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Kobber", "kobber", "kobber" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Jod", "jod", "jod" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Molybden", "molybden", "molybden" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Selen", "selen", "selen" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fluor", "fluor", "fluor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Krom", "krom", "krom" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Nikkel", "nikkel", "nikkel" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Bor", "bor", "bor" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Silisium", "silisium", "silisium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Vanadium", "vanadium", "vanadium" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Salt", "salt", "salt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Allergen", "Krepsdyr", "krepsdyr", "krepsdyr" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { "Allergen", "Sesamfrø", "sesamfrø", "sesamfro" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Nøtter", "nøtter", "notter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Gluten", "gluten", "gluten" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Egg", "egg", "egg" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Fisk", "fisk", "fisk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Skalldyr", "skalldyr", "skalldyr" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sennep", "sennep", "sennep" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Selleri", "selleri", "selleri" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Peanøtter", "peanøtter", "peanotter" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Melk", "melk", "melk" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Sulfitt", "sulfitt", "sulfitt" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Soya", "soya", "soya" });

            migrationBuilder.UpdateData(
                table: "SearchIndex",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Name", "NormalizedName", "Url" },
                values: new object[] { "Lupin", "lupin", "lupin" });

            migrationBuilder.InsertData(
                table: "SearchIndex",
                columns: new[] { "Id", "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[] { 238, "Recipe", "Pannekaker", "pannekaker", "pannekaker" });
        }
    }
}
