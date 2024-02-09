using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class IntegrateOldIntoNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasBackgropImage",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasProfileImage",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterX",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Allergens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ISO3166_2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ISO3166_2);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasImage = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnergyKcalPer100g = table.Column<double>(type: "float", nullable: false),
                    IsNutritionallyVerified = table.Column<bool>(type: "bit", nullable: false),
                    DateVerified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerificationAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerificationAuthorityPerson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    AlwaysDisplay = table.Column<bool>(type: "bit", nullable: false),
                    Emphasized = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    SubTypeOf = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentRecipeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    PrepTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RatingAverage = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recipes_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "ISO3166_2");
                    table.ForeignKey(
                        name: "FK_Recipes_Recipes_ParentRecipeId",
                        column: x => x.ParentRecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IngredientAllergens",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    AllergenId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientAllergens", x => new { x.IngredientId, x.AllergenId });
                    table.ForeignKey(
                        name: "FK_IngredientAllergens_Allergens_AllergenId",
                        column: x => x.AllergenId,
                        principalTable: "Allergens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientAllergens_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientNutrients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    NutrientId = table.Column<int>(type: "int", nullable: false),
                    AmountPer100Grams = table.Column<decimal>(type: "decimal(9,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientNutrients", x => new { x.IngredientId, x.NutrientId });
                    table.ForeignKey(
                        name: "FK_IngredientNutrients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientNutrients_Nutrients_NutrientId",
                        column: x => x.NutrientId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    StepText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeSteps_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Allergens",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "Icon", "Image", "IsPublished", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 45, 55, 710, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(6231), "Informasjon", "", "crustacean.png", true, "Krepsdyr", "krepsdyr" },
                    { 2, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7491), "Informasjon", "", "sesame.png", true, "Sesamfrø", "sesamfro" },
                    { 3, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7498), "Informasjon", "", "nuts.png", true, "Nøtter", "notter" },
                    { 4, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7532), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7535), "Informasjon", "", "gluten.png", true, "Gluten", "gluten" },
                    { 5, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7540), "Informasjon", "", "egg.png", true, "Egg", "egg" },
                    { 6, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7545), "Informasjon", "", "fish.png", true, "Fisk", "fisk" },
                    { 7, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7551), "Informasjon", "", "shellfish.png", true, "Skalldyr", "skalldyr" },
                    { 8, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7554), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7556), "Informasjon", "", "mustard.png", true, "Sennep", "sennep" },
                    { 9, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7559), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7561), "Informasjon", "", "celery.png", true, "Selleri", "selleri" },
                    { 10, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7564), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7566), "Informasjon", "", "peanuts.png", true, "Peanøtter", "peanotter" },
                    { 11, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7569), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7571), "Informasjon", "", "milk.png", true, "Melk", "melk" },
                    { 12, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7577), "Informasjon", "", "sulphite.png", true, "Sulfitt", "sulfitt" },
                    { 13, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7580), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7582), "Informasjon", "", "", true, "Soya", "soya" },
                    { 14, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7586), new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(7588), "Informasjon", "", "", true, "Lupin", "lupin" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ISO3166_2", "Name" },
                values: new object[,]
                {
                    { "DE", "Tyskland" },
                    { "DK", "Danmark" },
                    { "ES", "Spania" },
                    { "FR", "Frankrike" },
                    { "GR", "Hellas" },
                    { "IT", "Italia" },
                    { "JP", "Japan" },
                    { "MX", "Mexico" },
                    { "NO", "Norge" },
                    { "PT", "Portugal" },
                    { "SE", "Sverige" },
                    { "TH", "Thailand" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DateVerified", "Description", "EnergyKcalPer100g", "HasImage", "IsNutritionallyVerified", "IsPublished", "Name", "Type", "Url", "VerificationAuthority", "VerificationAuthorityPerson" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 7, 14, 45, 55, 713, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(282), null, "Informasjon", 0.0, false, false, true, "Hvetemel", 4, "hvetemel", null, null },
                    { 2, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1901), null, "Informasjon", 0.0, false, false, true, "Sammalt hvete, grovmalt", 4, "sammalt-hvete-grovmalt", null, null },
                    { 3, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1910), null, "Informasjon", 0.0, false, false, true, "Sammalt hvete, finmalt", 4, "sammalt-hvete-finmalt", null, null },
                    { 4, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1915), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1918), null, "Informasjon", 0.0, false, false, true, "Hvete helkorn", 4, "hvete-helkorn", null, null },
                    { 5, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1923), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1925), null, "Informasjon", 0.0, false, false, true, "Havregryn, lettkokt", 4, "havregryn-lettkokt", null, null },
                    { 6, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1931), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1933), null, "Informasjon", 0.0, false, false, true, "Havregryn, store", 4, "havregryn-store", null, null },
                    { 7, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(1940), null, "Informasjon", 0.0, false, false, true, "Havregryn, glutenfri", 4, "havregryn-glutenfri", null, null },
                    { 8, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2005), null, "Informasjon", 0.0, false, false, true, "Havremel", 4, "havremel", null, null },
                    { 9, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2013), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2016), null, "Informasjon", 0.0, false, false, true, "Rug, helkorn", 4, "rug-helkorn", null, null },
                    { 10, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2024), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2026), null, "Informasjon", 0.0, false, false, true, "Rugmel", 4, "rugmel", null, null },
                    { 11, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2037), null, "Informasjon", 0.0, false, false, true, "Bygg, helkorn", 4, "bygg-helkorn", null, null },
                    { 12, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2045), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2048), null, "Informasjon", 0.0, false, false, true, "Byggmel", 4, "byggmel", null, null },
                    { 13, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2055), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2058), null, "Informasjon", 0.0, false, false, true, "Gresskarkjerner", 4, "gresskarkjerner", null, null },
                    { 14, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2069), null, "Informasjon", 0.0, false, false, true, "Skummet melk", 2, "skummet-melk", null, null },
                    { 15, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2089), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2092), null, "Informasjon", 41.0, false, false, true, "Lettmelk", 2, "lettmelk", null, null },
                    { 16, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2509), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2516), null, "Informasjon", 0.0, false, false, true, "Helmelk", 2, "helmelk", null, null },
                    { 17, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2523), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2525), null, "Informasjon", 0.0, false, false, true, "Kremfløte", 2, "kremflote", null, null },
                    { 18, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2534), null, "Informasjon", 0.0, false, false, true, "Matfløte", 2, "matflote", null, null },
                    { 19, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2539), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2541), null, "Informasjon", 0.0, false, false, true, "Lettrømme", 2, "lettromme", null, null },
                    { 20, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2549), null, "Informasjon", 0.0, false, false, true, "Seterrømme", 2, "seterromme", null, null },
                    { 21, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2554), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2557), null, "Informasjon", 0.0, false, false, true, "Rømmekolle", 2, "rommekolle", null, null },
                    { 22, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2562), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2564), null, "Informasjon", 0.0, false, false, true, "Kvarg", 2, "kvarg", null, null },
                    { 23, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2572), null, "Egg fra høne. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom eggene du har er spesielt små eller store kan du måtte justere antallet.", 0.0, false, false, true, "Egg", 8, "egg", null, null },
                    { 24, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2578), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2580), null, "Eggeplomme fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggeplommer i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet.", 0.0, false, false, true, "Eggeplomme", 8, "eggeplomme", null, null },
                    { 25, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2586), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2588), null, "Eggehvite fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggehviter i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet.", 0.0, false, false, true, "Eggehvite", 8, "eggehvite", null, null },
                    { 26, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2596), null, "Egg fra vaktel.", 0.0, false, false, true, "Vaktelegg", 8, "vaktelegg", null, null },
                    { 27, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2604), null, "Egg fra måke (måse).", 0.0, false, false, true, "Måsegg", 8, "masegg", null, null },
                    { 28, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2621), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2624), null, "Informasjon", 0.0, false, false, true, "Salt", 14, "salt", null, null },
                    { 29, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2629), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2631), null, "Informasjon", 0.0, false, false, true, "Tomatketsjup", 14, "tomatketsjup", null, null },
                    { 30, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2637), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2639), null, "Informasjon", 0.0, false, false, true, "Søt sennep", 14, "sot-sennep", null, null },
                    { 31, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2650), null, "Informasjon", 0.0, false, false, true, "Sterk sennep", 14, "sterk-sennep", null, null },
                    { 32, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2657), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2660), null, "Informasjon", 0.0, false, false, true, "Dijonsennep", 14, "dijonsennep", null, null },
                    { 33, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2667), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2670), null, "Informasjon", 0.0, false, false, true, "Grov sennep", 14, "grov-sennep", null, null },
                    { 34, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2680), null, "Informasjon", 0.0, false, false, true, "Soyasaus", 14, "soyasaus", null, null },
                    { 35, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2687), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2690), null, "Informasjon", 0.0, false, false, true, "Saltredusert soyasaus", 14, "saltredusert-soyasaus", null, null },
                    { 36, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2698), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2701), null, "35%", 0.0, false, false, true, "Eddikessens", 14, "eddikessens", null, null },
                    { 37, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2708), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2711), null, "7%", 0.0, false, false, true, "Klar eddik", 14, "klar-eddik", null, null },
                    { 38, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2716), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2719), null, "7%", 0.0, false, false, true, "Brun eddik", 14, "brun-eddik", null, null },
                    { 39, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2725), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2727), null, "Informasjon", 0.0, false, false, true, "Eplecidereddik", 14, "eplecidereddik", null, null },
                    { 40, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2732), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2735), null, "Informasjon", 0.0, false, false, true, "Hvitvinseddik", 14, "hvitvinseddik", null, null },
                    { 41, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2754), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2757), null, "Informasjon", 0.0, false, false, true, "Rødvinseddik", 14, "rodvinseddik", null, null },
                    { 42, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2763), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2766), null, "Informasjon", 0.0, false, false, true, "Sitrondråper", 14, "sitrondråper", null, null },
                    { 43, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2803), null, "Informasjon", 0.0, false, false, true, "Smør", 2, "smor", null, null },
                    { 44, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2809), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2811), null, "Informasjon", 0.0, false, false, true, "Margarin", 3, "margarin", null, null },
                    { 45, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2819), null, "Informasjon", 0.0, false, false, true, "Sukker", 13, "sukker", null, null },
                    { 46, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2826), null, "Informasjon", 0.0, false, false, true, "Blåbær", 1, "blabar", null, null },
                    { 47, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2834), null, "Informasjon", 0.0, false, false, true, "Jordbær", 1, "jordbar", null, null },
                    { 48, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2839), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2842), null, "Informasjon", 0.0, false, false, true, "Bringebær", 1, "bringebar", null, null },
                    { 49, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2849), null, "Informasjon", 0.0, false, false, true, "Grønne epler", 1, "gronne-epler", null, null },
                    { 50, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2858), null, "Informasjon", 0.0, false, false, true, "Røde epler", 1, "rode-epler", null, null },
                    { 51, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2865), null, "Informasjon", 0.0, false, false, true, "Gule epler", 1, "gule-epler", null, null },
                    { 52, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2871), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2873), null, "Informasjon", 0.0, false, false, true, "Appelsin", 1, "appelsin", null, null },
                    { 53, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2879), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2881), null, "Informasjon", 0.0, false, false, true, "Sitron", 1, "sitron", null, null },
                    { 54, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2904), null, "Informasjon", 0.0, false, false, true, "Økologisk sitron", 1, "okologisk-sitron", null, null },
                    { 55, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2910), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2912), null, "Informasjon", 0.0, false, false, true, "Lime", 1, "lime", null, null },
                    { 56, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2920), null, "Informasjon", 0.0, false, false, true, "Hermetiske mandarinbåter", 1, "hermetiske-mandarinbater", null, null },
                    { 57, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2925), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2927), null, "Informasjon", 0.0, false, false, true, "Hermetiske pærer", 1, "hermetiske-parer", null, null },
                    { 58, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2933), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2935), null, "Informasjon", 0.0, false, false, true, "Hermetiske fersken", 1, "hermetiske-fersken", null, null },
                    { 59, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2943), null, "Informasjon", 0.0, false, false, true, "Banan", 1, "banan", null, null },
                    { 60, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2951), null, "Informasjon", 0.0, false, false, true, "Klementin", 1, "klementin", null, null },
                    { 61, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2956), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2958), null, "Informasjon", 0.0, false, false, true, "Blå druer", 1, "bla-druer", null, null },
                    { 62, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2966), null, "Informasjon", 0.0, false, false, true, "Grønne druer", 1, "gronne-druer", null, null },
                    { 63, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2972), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2975), null, "Informasjon", 0.0, false, false, true, "Rosiner", 1, "rosiner", null, null },
                    { 64, new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2980), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(2982), null, "Informasjon", 0.0, false, false, true, "Korinter", 1, "korinter", null, null }
                });

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "AlwaysDisplay", "Description", "Emphasized", "Name", "SortOrder", "SubTypeOf", "Type", "Url" },
                values: new object[,]
                {
                    { 1, false, "Informasjon.", false, "Protein", 0, null, 10, "protein" },
                    { 2, false, "Total mengde karbohydrater, inkludert sukkerarter, polyoler og stivelse.", false, "Karbohydrater", 0, null, 5, "karbohydrater" },
                    { 3, false, "Informasjon.", false, "Sukkerarter", 0, 5, 6, "sukkerarter" },
                    { 4, false, "Informasjon.", false, "Polyoler", 0, 5, 7, "polyoler" },
                    { 5, false, "Informasjon.", false, "Stivelse", 0, 5, 8, "stivelse" },
                    { 6, false, "Angir total mengde fett i en ingrediens, inkludert mettet, enumettet og flerumettet fett.", false, "Fett", 1, null, 0, "fett" },
                    { 7, false, "Informasjon", false, "Mettet fett", 1, 0, 1, "mettet-fett" },
                    { 8, false, "Informasjon", false, "Enumettet fett", 2, 0, 2, "enumettet-fett" },
                    { 9, false, "Informasjon", false, "Flerumettet fett", 3, 0, 3, "flerumettet-fett" },
                    { 10, false, "Informasjon", false, "Transfett", 4, 0, 4, "transfett" },
                    { 11, false, "Informasjon", false, "Vitamin A, retinol", 0, null, 12, "vitamin-a-retinol" },
                    { 12, false, "Informasjon", false, "Vitamin B1, tiamin", 0, null, 12, "vitamin-b1-tiamin" },
                    { 13, false, "Informasjon", false, "Vitamin B2, riboflavin", 0, null, 12, "vitamin-b2-riboflavin" },
                    { 14, false, "Informasjon", false, "Vitamin B3, niacin", 0, null, 12, "vitamin-b3-niacin" },
                    { 15, false, "Informasjon", false, "Vitamin B5, pantotensyre", 0, null, 12, "vitamin-b5-pantotensyre" },
                    { 16, false, "Informasjon", false, "Vitamin B7, biotin", 0, null, 12, "vitamin-b7-biotin" },
                    { 17, false, "Informasjon", false, "Vitamin B9, folat", 0, null, 12, "vitamin-b9-folat" },
                    { 18, false, "Informasjon", false, "Vitamin B12, kobalamin", 0, null, 12, "vitamin-b12-kobalamin" },
                    { 19, false, "Informasjon", false, "Vitamin C, askorbinsyre", 0, null, 12, "vitamin-c-askorbinsyre" },
                    { 20, false, "Informasjon", false, "Vitamin D2, ergokalsiferol", 0, null, 12, "vitamin-d2-ergokalsiferol" },
                    { 21, false, "Informasjon", false, "Vitamin D3, kolikalsiferol", 0, null, 12, "vitamin-d3-kolikalsiferol" },
                    { 22, false, "Tokoferol (E306) betegner en blanding av de rene stoffene alfa-tokoferol (E307), gamma-tokoferol (E308) og delta-tokoferol (E309).", false, "Vitamin E, tokoferol (E306)", 0, null, 12, "vitamin-e-tokoferol-e306" },
                    { 23, false, "Informasjon", false, "Vitamin K1, fyllokinon", 0, null, 12, "vitamin-k1-fyllokinon" },
                    { 24, false, "Informasjon", false, "Vitamin K2, menakinon", 0, null, 12, "vitamin-k2-menakinon" },
                    { 25, false, "Engelsk navn: Potassium", false, "Kalium", 0, null, 13, "kalium" },
                    { 26, false, "Engelsk navn: Chlorine. Komponent i vanlig bordsalt (natriumklorid).", false, "Klorin", 0, null, 13, "klorin" },
                    { 27, false, "Engelsk navn: Sodium. Komponent i vanlig bordsalt (natriumklorid).", false, "Natrium", 0, null, 13, "natrium" },
                    { 28, false, "Engelsk navn: Calcium. Viktig for skjelettet og tennene.", false, "Kalsium", 0, null, 13, "kalsium" },
                    { 29, false, "Engelsk navn: Phosphorus.", false, "Fosfor", 0, null, 13, "fosfor" },
                    { 30, false, "Engelsk navn: Magnesium.", false, "Magnesium", 0, null, 13, "magnesium" },
                    { 31, false, "Engelsk navn: Iron.", false, "Jern", 0, null, 13, "jern" },
                    { 32, false, "Engelsk navn: Zinc.", false, "Sink", 0, null, 13, "sink" },
                    { 33, false, "Engelsk navn: Manganese.", false, "Mangan", 0, null, 13, "mangan" },
                    { 34, false, "Engelsk navn: Copper.", false, "Kobber", 0, null, 13, "kobber" },
                    { 35, false, "Engelsk navn: iodine.", false, "Jod", 0, null, 13, "jod" },
                    { 36, false, "Engelsk navn: Molybdenum.", false, "Molybden", 0, null, 13, "molybden" },
                    { 37, false, "Engelsk navn: Selenium.", false, "Selen", 0, null, 13, "selen" },
                    { 38, false, "Engelsk navn: Fluoride.", false, "Fluor", 0, null, 13, "fluor" },
                    { 39, false, "Engelsk navn: Chromium.", false, "Krom", 0, null, 13, "korm" },
                    { 40, false, "Engelsk navn: Nickel.", false, "Nikkel", 0, null, 13, "nikkel" },
                    { 41, false, "Engelsk navn: Boron.", false, "Bor", 0, null, 13, "bor" },
                    { 42, false, "Engelsk navn: Silicon.", false, "Silisium", 0, null, 13, "silisium" },
                    { 43, false, "Engelsk navn: Vanadium.", false, "Vanadium", 0, null, 13, "vanadium" },
                    { 44, false, "Natriumklorid (NaCl). Engelsk navn: Salt, sodium chloride.", false, "Salt", 0, null, 13, "salt" }
                });

            migrationBuilder.InsertData(
                table: "IngredientAllergens",
                columns: new[] { "AllergenId", "IngredientId", "Amount" },
                values: new object[,]
                {
                    { 4, 1, 4 },
                    { 11, 15, 4 },
                    { 5, 23, 4 }
                });

            migrationBuilder.InsertData(
                table: "IngredientNutrients",
                columns: new[] { "IngredientId", "NutrientId", "AmountPer100Grams" },
                values: new object[,]
                {
                    { 15, 1, 3.5m },
                    { 15, 2, 4.5m },
                    { 15, 3, 4.5m },
                    { 15, 6, 1m },
                    { 15, 7, 0.6m },
                    { 15, 13, 0.00015m },
                    { 15, 16, 0.000008m },
                    { 15, 18, 0.0000006m },
                    { 15, 25, 0.171m },
                    { 15, 28, 0.13m },
                    { 15, 29, 0.115m },
                    { 15, 35, 0.000016m },
                    { 15, 44, 0.10m }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CountryCode", "DateCreated", "DateUpdated", "Description", "DifficultyLevel", "IsPublished", "MainImage", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "Url", "UserId", "UserId1" },
                values: new object[] { 1, "NO", new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(5898), new DateTime(2024, 2, 7, 14, 45, 55, 714, DateTimeKind.Local).AddTicks(6244), "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy eller sukker og sitrondråper.", 0, true, null, "Pannekaker", null, new TimeSpan(0, 1, 0, 0, 0), 7.4000000000000004, "pannekaker", null, null });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "Notes", "SortOrder", "Unit" },
                values: new object[,]
                {
                    { 1, 1, 3.0, null, 1, 2 },
                    { 15, 1, 5.0, null, 2, 2 },
                    { 23, 1, 4.0, null, 3, 12 },
                    { 28, 1, 0.5, null, 4, 9 }
                });

            migrationBuilder.InsertData(
                table: "RecipeSteps",
                columns: new[] { "Id", "Image", "RecipeId", "StepNumber", "StepText" },
                values: new object[,]
                {
                    { 1, null, 1, 1, "Bland mel og salt." },
                    { 2, null, 1, 2, "Ha i halvparten av melken og visp sammen til en tykk, klumpefri røre." },
                    { 3, null, 1, 3, "Tilsett resten av melken og visp sammen." },
                    { 4, null, 1, 4, "Tilsett eggene og visp sammen til røren blir fin og gul." },
                    { 5, null, 1, 5, "La røren hvile i minst 30 minutter for best resultat." },
                    { 6, null, 1, 6, "Ha smør eller margarin i pannen og stek pannekakene til de er gyldne på begge sider." },
                    { 7, null, 1, 7, "Brett pannekakene og legg dem i en ildfast form med lokk. Slik holder de seg varme til alle er ferdig stekt." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientAllergens_AllergenId",
                table: "IngredientAllergens",
                column: "AllergenId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientNutrients_NutrientId",
                table: "IngredientNutrients",
                column: "NutrientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CountryCode",
                table: "Recipes",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ParentRecipeId",
                table: "Recipes",
                column: "ParentRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId1",
                table: "Recipes",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSteps_RecipeId",
                table: "RecipeSteps",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientAllergens");

            migrationBuilder.DropTable(
                name: "IngredientNutrients");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "RecipeSteps");

            migrationBuilder.DropTable(
                name: "Allergens");

            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HasBackgropImage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HasProfileImage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TwitterX",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "AspNetUsers");
        }
    }
}
