using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsProtectedSystemUser = table.Column<bool>(type: "bit", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailConfirmationExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasProfileImage = table.Column<bool>(type: "bit", nullable: false),
                    HasBackgropImage = table.Column<bool>(type: "bit", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "SearchIndex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchIndex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentRecipeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChildRecipeSortOrder = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    PrepTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    RatingAverage = table.Column<double>(type: "float", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_UserId",
                        column: x => x.UserId,
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
                name: "RecipeNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeNotes_Recipes_RecipeId",
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
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
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
                    { 1, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "crustacean.png", true, "Krepsdyr", "krepsdyr" },
                    { 2, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "sesame.png", true, "Sesamfrø", "sesamfro" },
                    { 3, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "nuts.png", true, "Nøtter", "notter" },
                    { 4, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "gluten.png", true, "Gluten", "gluten" },
                    { 5, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "egg.png", true, "Egg", "egg" },
                    { 6, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "fish.png", true, "Fisk", "fisk" },
                    { 7, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "shellfish.png", true, "Skalldyr", "skalldyr" },
                    { 8, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "mustard.png", true, "Sennep", "sennep" },
                    { 9, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "celery.png", true, "Selleri", "selleri" },
                    { 10, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "peanuts.png", true, "Peanøtter", "peanotter" },
                    { 11, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "milk.png", true, "Melk", "melk" },
                    { 12, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "sulphite.png", true, "Sulfitt", "sulfitt" },
                    { 13, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "", true, "Soya", "soya" },
                    { 14, new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Informasjon", "", "", true, "Lupin", "lupin" }
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
                    { "GB", "Storbritannia" },
                    { "GR", "Hellas" },
                    { "IT", "Italia" },
                    { "JP", "Japan" },
                    { "MX", "Mexico" },
                    { "NO", "Norge" },
                    { "PT", "Portugal" },
                    { "SE", "Sverige" },
                    { "TH", "Thailand" },
                    { "US", "USA" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Alias", "DateCreated", "DateUpdated", "DateVerified", "Description", "EnergyKcalPer100g", "HasImage", "IsNutritionallyVerified", "IsPublished", "Name", "Type", "Url", "VerificationAuthority", "VerificationAuthorityPerson" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Vann", 17, "vann", null, null },
                    { 2, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvetemel", 4, "hvetemel", null, null },
                    { 3, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Pizzamel, tipo-00", 4, "pizzamel-tipo-00", null, null },
                    { 4, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Brødmel, tipo-0", 4, "brodmel-tipo-0", null, null },
                    { 5, "Semolina", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Semulegryn", 4, "semulegryn", null, null },
                    { 6, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sammalt hvete, grovmalt", 4, "sammalt-hvete-grovmalt", null, null },
                    { 7, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sammalt hvete, finmalt", 4, "sammalt-hvete-finmalt", null, null },
                    { 8, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvete helkorn", 4, "hvete-helkorn", null, null },
                    { 9, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Havregryn, lettkokt", 4, "havregryn-lettkokt", null, null },
                    { 10, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Havregryn, store", 4, "havregryn-store", null, null },
                    { 11, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Havregryn, glutenfri", 4, "havregryn-glutenfri", null, null },
                    { 12, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Havremel", 4, "havremel", null, null },
                    { 13, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rug, helkorn", 4, "rug-helkorn", null, null },
                    { 14, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rugmel", 4, "rugmel", null, null },
                    { 15, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Bygg, helkorn", 4, "bygg-helkorn", null, null },
                    { 16, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Byggmel", 4, "byggmel", null, null },
                    { 17, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gresskarkjerner", 4, "gresskarkjerner", null, null },
                    { 18, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Skummet melk", 2, "skummet-melk", null, null },
                    { 19, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 41.0, false, false, true, "Lettmelk", 2, "lettmelk", null, null },
                    { 20, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Helmelk", 2, "helmelk", null, null },
                    { 21, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kremfløte", 2, "kremflote", null, null },
                    { 22, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Matfløte", 2, "matflote", null, null },
                    { 23, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Lettrømme", 2, "lettromme", null, null },
                    { 24, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Seterrømme", 2, "seterromme", null, null },
                    { 25, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rømmekolle", 2, "rommekolle", null, null },
                    { 26, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kvarg", 2, "kvarg", null, null },
                    { 27, "Hvitost", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gulost", 2, "gulost", null, null },
                    { 28, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Edamer", 2, "edamer", null, null },
                    { 29, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gouda", 2, "gouda", null, null },
                    { 30, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Brie", 2, "brie", null, null },
                    { 31, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kremost", 2, "kremost", null, null },
                    { 32, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Cottage cheese", 2, "cottage-cheese", null, null },
                    { 33, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Ricotta", 2, "ricotta", null, null },
                    { 34, "Grillost", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Halloumi", 2, "halloumi", null, null },
                    { 35, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Mozzarella", 2, "mozzarella", null, null },
                    { 36, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Cheddar", 2, "cheddar", null, null },
                    { 37, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Geitost", 2, "geitost", null, null },
                    { 38, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Fløtemysost", 2, "flotemysost", null, null },
                    { 39, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Egg fra høne. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom eggene du har er spesielt små eller store kan du måtte justere antallet.", 0.0, false, false, true, "Egg", 8, "egg", null, null },
                    { 40, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Eggeplomme fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggeplommer i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet.", 0.0, false, false, true, "Eggeplomme", 8, "eggeplomme", null, null },
                    { 41, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Eggehvite fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggehviter i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet.", 0.0, false, false, true, "Eggehvite", 8, "eggehvite", null, null },
                    { 42, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Egg fra vaktel.", 0.0, false, false, true, "Vaktelegg", 8, "vaktelegg", null, null },
                    { 43, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Egg fra måke (måse).", 0.0, false, false, true, "Måsegg", 8, "masegg", null, null },
                    { 44, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Tortillachips", 17, "tortillachips", null, null },
                    { 45, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Nachochips", 17, "nachochips", null, null },
                    { 46, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Salt", 14, "salt", null, null },
                    { 47, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Tomatketsjup", 14, "tomatketsjup", null, null },
                    { 48, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Søt sennep", 14, "sot-sennep", null, null },
                    { 49, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sterk sennep", 14, "sterk-sennep", null, null },
                    { 50, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Dijonsennep", 14, "dijonsennep", null, null },
                    { 51, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Grov sennep", 14, "grov-sennep", null, null },
                    { 52, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Soyasaus", 14, "soyasaus", null, null },
                    { 53, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Saltredusert soyasaus", 14, "saltredusert-soyasaus", null, null },
                    { 54, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "35%", 0.0, false, false, true, "Eddikessens", 14, "eddikessens", null, null },
                    { 55, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "7%", 0.0, false, false, true, "Klar eddik", 14, "klar-eddik", null, null },
                    { 56, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "7%", 0.0, false, false, true, "Brun eddik", 14, "brun-eddik", null, null },
                    { 57, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Eplecidereddik", 14, "eplecidereddik", null, null },
                    { 58, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvitvinseddik", 14, "hvitvinseddik", null, null },
                    { 59, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rødvinseddik", 14, "rodvinseddik", null, null },
                    { 60, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sitrondråper", 14, "sitrondråper", null, null },
                    { 61, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Smør", 2, "smor", null, null },
                    { 62, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Margarin", 3, "margarin", null, null },
                    { 63, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rapsolje", 15, "rapsolje", null, null },
                    { 64, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Maisolje", 15, "maisolje", null, null },
                    { 65, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Olivenolje", 15, "Olivenolje", null, null },
                    { 66, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sesamolje", 15, "sesamolje", null, null },
                    { 67, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kokosolje", 15, "kokosolje", null, null },
                    { 68, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Frityrolje", 15, "frityrolje", null, null },
                    { 69, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sukker", 13, "sukker", null, null },
                    { 70, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Blåbær", 1, "blabar", null, null },
                    { 71, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Jordbær", 1, "jordbar", null, null },
                    { 72, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Bringebær", 1, "bringebar", null, null },
                    { 73, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Grønne epler", 1, "gronne-epler", null, null },
                    { 74, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Røde epler", 1, "rode-epler", null, null },
                    { 75, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gule epler", 1, "gule-epler", null, null },
                    { 76, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Appelsin", 1, "appelsin", null, null },
                    { 77, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sitron", 1, "sitron", null, null },
                    { 78, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Økologisk sitron", 1, "okologisk-sitron", null, null },
                    { 79, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Lime", 1, "lime", null, null },
                    { 80, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hermetiske mandarinbåter", 1, "hermetiske-mandarinbater", null, null },
                    { 81, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hermetiske pærer", 1, "hermetiske-parer", null, null },
                    { 82, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hermetiske fersken", 1, "hermetiske-fersken", null, null },
                    { 83, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Banan", 1, "banan", null, null },
                    { 84, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Klementin", 1, "klementin", null, null },
                    { 85, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Blå druer", 1, "bla-druer", null, null },
                    { 86, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Grønne druer", 1, "gronne-druer", null, null },
                    { 87, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rosiner", 1, "rosiner", null, null },
                    { 88, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Korinter", 1, "korinter", null, null },
                    { 89, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Fiskesaus", 14, "fiskesaus", null, null },
                    { 90, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kokosmelk", 16, "kokosmelk", null, null },
                    { 91, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kokosmelk, lett", 16, "kokosmelk-lett", null, null },
                    { 92, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kokoskrem", 16, "kokoskrem", null, null },
                    { 93, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kokosmasse", 16, "kokosmasse", null, null },
                    { 94, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sitrongress", 12, "sitrongress", null, null },
                    { 95, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rød currypasta", 14, "rod-currypasta", null, null },
                    { 96, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Grønn currypasta", 14, "gronn-currypasta", null, null },
                    { 97, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gul currypasta", 14, "gul-currypasta", null, null },
                    { 98, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Galangal", 12, "galangal", null, null },
                    { 99, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rød paprika", 0, "rod-paprika", null, null },
                    { 100, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gul paprika", 0, "gul-paprika", null, null },
                    { 101, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Grønn paprika", 0, "gronn-paprika", null, null },
                    { 102, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Isbergsalat", 0, "isbergsalat", null, null },
                    { 103, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hjertesalat", 0, "hjertesalat", null, null },
                    { 104, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Lollosalat", 0, "lollosalat", null, null },
                    { 105, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Maiskolbe, fersk", 0, "maiskolbe-fersk", null, null },
                    { 106, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hermetisk maiskolbe", 0, "hermetisk-maiskolbe", null, null },
                    { 107, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hermetiske maiskorn", 0, "hermetiske-maiskorn", null, null },
                    { 108, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Plommetomat", 0, "plommetomat", null, null },
                    { 109, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kirsebærtomat", 0, "kirsebartomat", null, null },
                    { 110, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Tomat", 0, "tomat", null, null },
                    { 111, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Slangeagurk", 0, "slangeagurk", null, null },
                    { 112, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gul løk", 0, "gul-lok", null, null },
                    { 113, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rødløk", 0, "rodlok", null, null },
                    { 114, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Chalottløk", 0, "chalottlok", null, null },
                    { 115, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvitløk", 0, "hvitlok", null, null },
                    { 116, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Salatløk", 0, "salatlok", null, null },
                    { 117, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Vårløk", 0, "varlok", null, null },
                    { 118, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Purre", 0, "purre", null, null },
                    { 119, "Kyllingbuljong", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllingkraft", 17, "kyllingkraft", null, null },
                    { 120, "Storfebuljong", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Storfekraft", 17, "storfekraft", null, null },
                    { 121, "Fiskebuljong", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Fiskekraft", 17, "fiskekraft", null, null },
                    { 122, "Grønnsaksbuljong", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Grønnsakskraft", 17, "gronnsakskraft", null, null },
                    { 123, "Rød chili", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Den vanlige, røde chilien du kjenner fra dagligvarebutikken.", 0.0, false, false, true, "Chili, serrano", 0, "chili-serrano", null, null },
                    { 124, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "En sterkere chili.", 0.0, false, false, true, "Chili, habanero", 0, "chili-habanero", null, null },
                    { 125, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Også kalt thai-chili. Sterkere enn serrano.", 0.0, false, false, true, "Chili, birds eye", 0, "chili-birds-eye", null, null },
                    { 126, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Champignon, fersk", 0, "champignon-fersk", null, null },
                    { 127, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Champignon, hermetisk", 0, "champignon-hermetisk", null, null },
                    { 128, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Aromasopp, fersk", 0, "aromasopp-fersk", null, null },
                    { 129, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Aromasopp, tørket", 0, "aromasopp-torket", null, null },
                    { 130, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Margarin", 3, "margarin", null, null },
                    { 131, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kylling, hel grillet", 7, "kylling-hel-grillet", null, null },
                    { 132, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kylling, hel fersk", 7, "kylling-hel-fersk", null, null },
                    { 133, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllinglår, grillet", 7, "kyllinglar-grillet", null, null },
                    { 134, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllinglår, fersk", 7, "kyllinglar-fersk", null, null },
                    { 135, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllinglår, frossen", 7, "kyllinglar-frossen", null, null },
                    { 136, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllingvinger, grillet", 7, "kyllingvinger-grillet", null, null },
                    { 137, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllingvinger, fersk", 7, "kyllingvinger-fersk", null, null },
                    { 138, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllingvinger, frossen", 7, "kyllingvinger-frossen", null, null },
                    { 139, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kylling lårfilet", 7, "kylling-larfilet", null, null },
                    { 140, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kylling brystfilet", 7, "kylling-brystfilet", null, null },
                    { 141, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kyllingkjøttdeig", 7, "kyllingkjottdeig", null, null },
                    { 142, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kjøttdeig", 5, "kjottdeig", null, null },
                    { 143, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Karbonadedeig", 5, "karbonadedeig", null, null },
                    { 144, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Medisterdeig", 5, "medisterdeig", null, null },
                    { 145, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Medisterfarse", 5, "medisterfarse", null, null },
                    { 146, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Koriander, fersk", 12, "koriander-fersk", null, null },
                    { 147, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Dill, fersk", 12, "dill-fersk", null, null },
                    { 148, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Gressløk, fersk", 12, "gresslok-fersk", null, null },
                    { 149, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Basilikum, fersk", 12, "basilikum-fersk", null, null },
                    { 150, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Thaibasilikum, fersk", 12, "thaibasilikum-fersk", null, null },
                    { 151, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sort pepper, hel", 12, "sort-pepper-hel", null, null },
                    { 152, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sort pepper, grovmalt", 12, "sort-pepper-grovmalt", null, null },
                    { 153, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Sort pepper, malt", 12, "sort-pepper-malt", null, null },
                    { 154, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvit pepper, hel", 12, "hvit-pepper-hel", null, null },
                    { 155, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvit pepper, grovmalt", 12, "hvit-pepper-grovmalt", null, null },
                    { 156, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvit pepper, malt", 12, "hvit-pepper-malt", null, null },
                    { 157, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Karri", 12, "karri", null, null },
                    { 158, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvitløkspulver", 12, "hvitlokspulver", null, null },
                    { 159, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Løkpulver", 12, "lokpulver", null, null },
                    { 160, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kanel, hel", 12, "kanel-hel", null, null },
                    { 161, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kanel, malt", 12, "kanel-malt", null, null },
                    { 162, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Kardemomme", 12, "kardemomme", null, null },
                    { 163, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Hvitløkspulver", 12, "hvitlokspulver", null, null },
                    { 164, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Chilipulver", 12, "chilipulver", null, null },
                    { 165, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Chiliflak", 12, "chiliflak", null, null },
                    { 166, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Paprikapulver", 12, "paprikapulver", null, null },
                    { 167, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Paprikapulver, røkt", 12, "paprikapulver-rokt", null, null },
                    { 168, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Rosmarin, tørket", 12, "rosmarin-torket", null, null },
                    { 169, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Dill, tørket", 12, "dill-torket", null, null },
                    { 170, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Oregano, tørket", 12, "oregano-torket", null, null },
                    { 171, "", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Informasjon", 0.0, false, false, true, "Basilikum, tørket", 12, "basilikum-torket", null, null },
                    { 172, "Spisskummen, spisskarve, cumin, Roman caraway", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Latin: Cuminum cyminum. Engelsk: Cumin eller Roman caraway. Spisskum kan også kalles spisskummen eller spisskarve, og er ikke det samme som karve.", 0.0, false, false, true, "Spisskum", 12, "spisskum", null, null },
                    { 173, "Caraway", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), null, "Latin: Carum carvi. Engelsk: Caraway. Karve er ikke det samme som spisskum/spisskummen/spisskarve/Roman caraway.", 0.0, false, false, true, "Karve", 12, "karve", null, null }
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
                    { 35, false, "Engelsk navn: Iodine.", false, "Jod", 0, null, 13, "jod" },
                    { 36, false, "Engelsk navn: Molybdenum.", false, "Molybden", 0, null, 13, "molybden" },
                    { 37, false, "Engelsk navn: Selenium.", false, "Selen", 0, null, 13, "selen" },
                    { 38, false, "Engelsk navn: Fluoride.", false, "Fluor", 0, null, 13, "fluor" },
                    { 39, false, "Engelsk navn: Chromium.", false, "Krom", 0, null, 13, "krom" },
                    { 40, false, "Engelsk navn: Nickel.", false, "Nikkel", 0, null, 13, "nikkel" },
                    { 41, false, "Engelsk navn: Boron.", false, "Bor", 0, null, 13, "bor" },
                    { 42, false, "Engelsk navn: Silicon.", false, "Silisium", 0, null, 13, "silisium" },
                    { 43, false, "Engelsk navn: Vanadium.", false, "Vanadium", 0, null, 13, "vanadium" },
                    { 44, false, "Natriumklorid (NaCl). Engelsk navn: Salt, sodium chloride.", false, "Salt", 0, null, 13, "salt" }
                });

            migrationBuilder.InsertData(
                table: "SearchIndex",
                columns: new[] { "Id", "EntityType", "Name", "NormalizedName", "Url" },
                values: new object[,]
                {
                    { 238, "Recipe", "Pannekaker", "pannekaker", "pannekaker" },
                    { 239, "Recipe", "Tom Kha Gai", "tom kha gai", "tom-kha-gai" },
                    { 240, "Recipe", "Cacio e Pepe", "cacio e pepe", "cacio-e-pepe" },
                    { 241, "Recipe", "Kjøttkaker med kålstuing", "kjøttkaker med kålstuing", "kjottkaker-med-kalstuing" },
                    { 242, "Recipe", "Taco", "taco", "taco" },
                    { 243, "Recipe", "Ovnsbakt hel ørret", "ovnsbakt hel ørret", "ovnsbakt-hel-orret" },
                    { 244, "Ingredient", "Vann", "vann", "vann" },
                    { 245, "Ingredient", "Hvetemel", "hvetemel", "hvetemel" },
                    { 246, "Ingredient", "Pizzamel, tipo-00", "pizzamel tipo00", "pizzamel-tipo-00" },
                    { 247, "Ingredient", "Brødmel, tipo-0", "brødmel tipo0", "brodmel-tipo-0" },
                    { 248, "Ingredient", "Semulegryn", "semulegryn", "semulegryn" },
                    { 249, "Ingredient", "Sammalt hvete, grovmalt", "sammalt hvete grovmalt", "sammalt-hvete-grovmalt" },
                    { 250, "Ingredient", "Sammalt hvete, finmalt", "sammalt hvete finmalt", "sammalt-hvete-finmalt" },
                    { 251, "Ingredient", "Hvete helkorn", "hvete helkorn", "hvete-helkorn" },
                    { 252, "Ingredient", "Havregryn, lettkokt", "havregryn lettkokt", "havregryn-lettkokt" },
                    { 253, "Ingredient", "Havregryn, store", "havregryn store", "havregryn-store" },
                    { 254, "Ingredient", "Havregryn, glutenfri", "havregryn glutenfri", "havregryn-glutenfri" },
                    { 255, "Ingredient", "Havremel", "havremel", "havremel" },
                    { 256, "Ingredient", "Rug, helkorn", "rug helkorn", "rug-helkorn" },
                    { 257, "Ingredient", "Rugmel", "rugmel", "rugmel" },
                    { 258, "Ingredient", "Bygg, helkorn", "bygg helkorn", "bygg-helkorn" },
                    { 259, "Ingredient", "Byggmel", "byggmel", "byggmel" },
                    { 260, "Ingredient", "Gresskarkjerner", "gresskarkjerner", "gresskarkjerner" },
                    { 261, "Ingredient", "Skummet melk", "skummet melk", "skummet-melk" },
                    { 262, "Ingredient", "Lettmelk", "lettmelk", "lettmelk" },
                    { 263, "Ingredient", "Helmelk", "helmelk", "helmelk" },
                    { 264, "Ingredient", "Kremfløte", "kremfløte", "kremflote" },
                    { 265, "Ingredient", "Matfløte", "matfløte", "matflote" },
                    { 266, "Ingredient", "Lettrømme", "lettrømme", "lettromme" },
                    { 267, "Ingredient", "Seterrømme", "seterrømme", "seterromme" },
                    { 268, "Ingredient", "Rømmekolle", "rømmekolle", "rommekolle" },
                    { 269, "Ingredient", "Kvarg", "kvarg", "kvarg" },
                    { 270, "Ingredient", "Gulost", "gulost", "gulost" },
                    { 271, "Ingredient", "Edamer", "edamer", "edamer" },
                    { 272, "Ingredient", "Gouda", "gouda", "gouda" },
                    { 273, "Ingredient", "Brie", "brie", "brie" },
                    { 274, "Ingredient", "Kremost", "kremost", "kremost" },
                    { 275, "Ingredient", "Cottage cheese", "cottage cheese", "cottage-cheese" },
                    { 276, "Ingredient", "Ricotta", "ricotta", "ricotta" },
                    { 277, "Ingredient", "Halloumi", "halloumi", "halloumi" },
                    { 278, "Ingredient", "Mozzarella", "mozzarella", "mozzarella" },
                    { 279, "Ingredient", "Cheddar", "cheddar", "cheddar" },
                    { 280, "Ingredient", "Geitost", "geitost", "geitost" },
                    { 281, "Ingredient", "Fløtemysost", "fløtemysost", "flotemysost" },
                    { 282, "Ingredient", "Egg", "egg", "egg" },
                    { 283, "Ingredient", "Eggeplomme", "eggeplomme", "eggeplomme" },
                    { 284, "Ingredient", "Eggehvite", "eggehvite", "eggehvite" },
                    { 285, "Ingredient", "Vaktelegg", "vaktelegg", "vaktelegg" },
                    { 286, "Ingredient", "Måsegg", "måsegg", "masegg" },
                    { 287, "Ingredient", "Tortillachips", "tortillachips", "tortillachips" },
                    { 288, "Ingredient", "Nachochips", "nachochips", "nachochips" },
                    { 289, "Ingredient", "Salt", "salt", "salt" },
                    { 290, "Ingredient", "Tomatketsjup", "tomatketsjup", "tomatketsjup" },
                    { 291, "Ingredient", "Søt sennep", "søt sennep", "sot-sennep" },
                    { 292, "Ingredient", "Sterk sennep", "sterk sennep", "sterk-sennep" },
                    { 293, "Ingredient", "Dijonsennep", "dijonsennep", "dijonsennep" },
                    { 294, "Ingredient", "Grov sennep", "grov sennep", "grov-sennep" },
                    { 295, "Ingredient", "Soyasaus", "soyasaus", "soyasaus" },
                    { 296, "Ingredient", "Saltredusert soyasaus", "saltredusert soyasaus", "saltredusert-soyasaus" },
                    { 297, "Ingredient", "Eddikessens", "eddikessens", "eddikessens" },
                    { 298, "Ingredient", "Klar eddik", "klar eddik", "klar-eddik" },
                    { 299, "Ingredient", "Brun eddik", "brun eddik", "brun-eddik" },
                    { 300, "Ingredient", "Eplecidereddik", "eplecidereddik", "eplecidereddik" },
                    { 301, "Ingredient", "Hvitvinseddik", "hvitvinseddik", "hvitvinseddik" },
                    { 302, "Ingredient", "Rødvinseddik", "rødvinseddik", "rodvinseddik" },
                    { 303, "Ingredient", "Sitrondråper", "sitrondråper", "sitrondråper" },
                    { 304, "Ingredient", "Smør", "smør", "smor" },
                    { 305, "Ingredient", "Margarin", "margarin", "margarin" },
                    { 306, "Ingredient", "Rapsolje", "rapsolje", "rapsolje" },
                    { 307, "Ingredient", "Maisolje", "maisolje", "maisolje" },
                    { 308, "Ingredient", "Olivenolje", "olivenolje", "Olivenolje" },
                    { 309, "Ingredient", "Sesamolje", "sesamolje", "sesamolje" },
                    { 310, "Ingredient", "Kokosolje", "kokosolje", "kokosolje" },
                    { 311, "Ingredient", "Frityrolje", "frityrolje", "frityrolje" },
                    { 312, "Ingredient", "Sukker", "sukker", "sukker" },
                    { 313, "Ingredient", "Blåbær", "blåbær", "blabar" },
                    { 314, "Ingredient", "Jordbær", "jordbær", "jordbar" },
                    { 315, "Ingredient", "Bringebær", "bringebær", "bringebar" },
                    { 316, "Ingredient", "Grønne epler", "grønne epler", "gronne-epler" },
                    { 317, "Ingredient", "Røde epler", "røde epler", "rode-epler" },
                    { 318, "Ingredient", "Gule epler", "gule epler", "gule-epler" },
                    { 319, "Ingredient", "Appelsin", "appelsin", "appelsin" },
                    { 320, "Ingredient", "Sitron", "sitron", "sitron" },
                    { 321, "Ingredient", "Økologisk sitron", "økologisk sitron", "okologisk-sitron" },
                    { 322, "Ingredient", "Lime", "lime", "lime" },
                    { 323, "Ingredient", "Hermetiske mandarinbåter", "hermetiske mandarinbåter", "hermetiske-mandarinbater" },
                    { 324, "Ingredient", "Hermetiske pærer", "hermetiske pærer", "hermetiske-parer" },
                    { 325, "Ingredient", "Hermetiske fersken", "hermetiske fersken", "hermetiske-fersken" },
                    { 326, "Ingredient", "Banan", "banan", "banan" },
                    { 327, "Ingredient", "Klementin", "klementin", "klementin" },
                    { 328, "Ingredient", "Blå druer", "blå druer", "bla-druer" },
                    { 329, "Ingredient", "Grønne druer", "grønne druer", "gronne-druer" },
                    { 330, "Ingredient", "Rosiner", "rosiner", "rosiner" },
                    { 331, "Ingredient", "Korinter", "korinter", "korinter" },
                    { 332, "Ingredient", "Fiskesaus", "fiskesaus", "fiskesaus" },
                    { 333, "Ingredient", "Kokosmelk", "kokosmelk", "kokosmelk" },
                    { 334, "Ingredient", "Kokosmelk, lett", "kokosmelk lett", "kokosmelk-lett" },
                    { 335, "Ingredient", "Kokoskrem", "kokoskrem", "kokoskrem" },
                    { 336, "Ingredient", "Kokosmasse", "kokosmasse", "kokosmasse" },
                    { 337, "Ingredient", "Sitrongress", "sitrongress", "sitrongress" },
                    { 338, "Ingredient", "Rød currypasta", "rød currypasta", "rod-currypasta" },
                    { 339, "Ingredient", "Grønn currypasta", "grønn currypasta", "gronn-currypasta" },
                    { 340, "Ingredient", "Gul currypasta", "gul currypasta", "gul-currypasta" },
                    { 341, "Ingredient", "Galangal", "galangal", "galangal" },
                    { 342, "Ingredient", "Rød paprika", "rød paprika", "rod-paprika" },
                    { 343, "Ingredient", "Gul paprika", "gul paprika", "gul-paprika" },
                    { 344, "Ingredient", "Grønn paprika", "grønn paprika", "gronn-paprika" },
                    { 345, "Ingredient", "Isbergsalat", "isbergsalat", "isbergsalat" },
                    { 346, "Ingredient", "Hjertesalat", "hjertesalat", "hjertesalat" },
                    { 347, "Ingredient", "Lollosalat", "lollosalat", "lollosalat" },
                    { 348, "Ingredient", "Maiskolbe, fersk", "maiskolbe fersk", "maiskolbe-fersk" },
                    { 349, "Ingredient", "Hermetisk maiskolbe", "hermetisk maiskolbe", "hermetisk-maiskolbe" },
                    { 350, "Ingredient", "Hermetiske maiskorn", "hermetiske maiskorn", "hermetiske-maiskorn" },
                    { 351, "Ingredient", "Plommetomat", "plommetomat", "plommetomat" },
                    { 352, "Ingredient", "Kirsebærtomat", "kirsebærtomat", "kirsebartomat" },
                    { 353, "Ingredient", "Tomat", "tomat", "tomat" },
                    { 354, "Ingredient", "Slangeagurk", "slangeagurk", "slangeagurk" },
                    { 355, "Ingredient", "Gul løk", "gul løk", "gul-lok" },
                    { 356, "Ingredient", "Rødløk", "rødløk", "rodlok" },
                    { 357, "Ingredient", "Chalottløk", "chalottløk", "chalottlok" },
                    { 358, "Ingredient", "Hvitløk", "hvitløk", "hvitlok" },
                    { 359, "Ingredient", "Salatløk", "salatløk", "salatlok" },
                    { 360, "Ingredient", "Vårløk", "vårløk", "varlok" },
                    { 361, "Ingredient", "Purre", "purre", "purre" },
                    { 362, "Ingredient", "Kyllingkraft", "kyllingkraft", "kyllingkraft" },
                    { 363, "Ingredient", "Storfekraft", "storfekraft", "storfekraft" },
                    { 364, "Ingredient", "Fiskekraft", "fiskekraft", "fiskekraft" },
                    { 365, "Ingredient", "Grønnsakskraft", "grønnsakskraft", "gronnsakskraft" },
                    { 366, "Ingredient", "Chili, serrano", "chili serrano", "chili-serrano" },
                    { 367, "Ingredient", "Chili, habanero", "chili habanero", "chili-habanero" },
                    { 368, "Ingredient", "Chili, birds eye", "chili birds eye", "chili-birds-eye" },
                    { 369, "Ingredient", "Champignon, fersk", "champignon fersk", "champignon-fersk" },
                    { 370, "Ingredient", "Champignon, hermetisk", "champignon hermetisk", "champignon-hermetisk" },
                    { 371, "Ingredient", "Aromasopp, fersk", "aromasopp fersk", "aromasopp-fersk" },
                    { 372, "Ingredient", "Aromasopp, tørket", "aromasopp tørket", "aromasopp-torket" },
                    { 373, "Ingredient", "Margarin", "margarin", "margarin" },
                    { 374, "Ingredient", "Kylling, hel grillet", "kylling hel grillet", "kylling-hel-grillet" },
                    { 375, "Ingredient", "Kylling, hel fersk", "kylling hel fersk", "kylling-hel-fersk" },
                    { 376, "Ingredient", "Kyllinglår, grillet", "kyllinglår grillet", "kyllinglar-grillet" },
                    { 377, "Ingredient", "Kyllinglår, fersk", "kyllinglår fersk", "kyllinglar-fersk" },
                    { 378, "Ingredient", "Kyllinglår, frossen", "kyllinglår frossen", "kyllinglar-frossen" },
                    { 379, "Ingredient", "Kyllingvinger, grillet", "kyllingvinger grillet", "kyllingvinger-grillet" },
                    { 380, "Ingredient", "Kyllingvinger, fersk", "kyllingvinger fersk", "kyllingvinger-fersk" },
                    { 381, "Ingredient", "Kyllingvinger, frossen", "kyllingvinger frossen", "kyllingvinger-frossen" },
                    { 382, "Ingredient", "Kylling lårfilet", "kylling lårfilet", "kylling-larfilet" },
                    { 383, "Ingredient", "Kylling brystfilet", "kylling brystfilet", "kylling-brystfilet" },
                    { 384, "Ingredient", "Kyllingkjøttdeig", "kyllingkjøttdeig", "kyllingkjottdeig" },
                    { 385, "Ingredient", "Kjøttdeig", "kjøttdeig", "kjottdeig" },
                    { 386, "Ingredient", "Karbonadedeig", "karbonadedeig", "karbonadedeig" },
                    { 387, "Ingredient", "Medisterdeig", "medisterdeig", "medisterdeig" },
                    { 388, "Ingredient", "Medisterfarse", "medisterfarse", "medisterfarse" },
                    { 389, "Ingredient", "Koriander, fersk", "koriander fersk", "koriander-fersk" },
                    { 390, "Ingredient", "Dill, fersk", "dill fersk", "dill-fersk" },
                    { 391, "Ingredient", "Gressløk, fersk", "gressløk fersk", "gresslok-fersk" },
                    { 392, "Ingredient", "Basilikum, fersk", "basilikum fersk", "basilikum-fersk" },
                    { 393, "Ingredient", "Thaibasilikum, fersk", "thaibasilikum fersk", "thaibasilikum-fersk" },
                    { 394, "Ingredient", "Sort pepper, hel", "sort pepper hel", "sort-pepper-hel" },
                    { 395, "Ingredient", "Sort pepper, grovmalt", "sort pepper grovmalt", "sort-pepper-grovmalt" },
                    { 396, "Ingredient", "Sort pepper, malt", "sort pepper malt", "sort-pepper-malt" },
                    { 397, "Ingredient", "Hvit pepper, hel", "hvit pepper hel", "hvit-pepper-hel" },
                    { 398, "Ingredient", "Hvit pepper, grovmalt", "hvit pepper grovmalt", "hvit-pepper-grovmalt" },
                    { 399, "Ingredient", "Hvit pepper, malt", "hvit pepper malt", "hvit-pepper-malt" },
                    { 400, "Ingredient", "Karri", "karri", "karri" },
                    { 401, "Ingredient", "Hvitløkspulver", "hvitløkspulver", "hvitlokspulver" },
                    { 402, "Ingredient", "Løkpulver", "løkpulver", "lokpulver" },
                    { 403, "Ingredient", "Kanel, hel", "kanel hel", "kanel-hel" },
                    { 404, "Ingredient", "Kanel, malt", "kanel malt", "kanel-malt" },
                    { 405, "Ingredient", "Kardemomme", "kardemomme", "kardemomme" },
                    { 406, "Ingredient", "Hvitløkspulver", "hvitløkspulver", "hvitlokspulver" },
                    { 407, "Ingredient", "Chilipulver", "chilipulver", "chilipulver" },
                    { 408, "Ingredient", "Chiliflak", "chiliflak", "chiliflak" },
                    { 409, "Ingredient", "Paprikapulver", "paprikapulver", "paprikapulver" },
                    { 410, "Ingredient", "Paprikapulver, røkt", "paprikapulver røkt", "paprikapulver-rokt" },
                    { 411, "Ingredient", "Rosmarin, tørket", "rosmarin tørket", "rosmarin-torket" },
                    { 412, "Ingredient", "Dill, tørket", "dill tørket", "dill-torket" },
                    { 413, "Ingredient", "Oregano, tørket", "oregano tørket", "oregano-torket" },
                    { 414, "Ingredient", "Basilikum, tørket", "basilikum tørket", "basilikum-torket" },
                    { 415, "Ingredient", "Spisskum", "spisskum", "spisskum" },
                    { 416, "Ingredient", "Karve", "karve", "karve" },
                    { 417, "Nutrient", "Protein", "protein", "protein" },
                    { 418, "Nutrient", "Karbohydrater", "karbohydrater", "karbohydrater" },
                    { 419, "Nutrient", "Sukkerarter", "sukkerarter", "sukkerarter" },
                    { 420, "Nutrient", "Polyoler", "polyoler", "polyoler" },
                    { 421, "Nutrient", "Stivelse", "stivelse", "stivelse" },
                    { 422, "Nutrient", "Fett", "fett", "fett" },
                    { 423, "Nutrient", "Mettet fett", "mettet fett", "mettet-fett" },
                    { 424, "Nutrient", "Enumettet fett", "enumettet fett", "enumettet-fett" },
                    { 425, "Nutrient", "Flerumettet fett", "flerumettet fett", "flerumettet-fett" },
                    { 426, "Nutrient", "Transfett", "transfett", "transfett" },
                    { 427, "Nutrient", "Vitamin A, retinol", "vitamin a retinol", "vitamin-a-retinol" },
                    { 428, "Nutrient", "Vitamin B1, tiamin", "vitamin b1 tiamin", "vitamin-b1-tiamin" },
                    { 429, "Nutrient", "Vitamin B2, riboflavin", "vitamin b2 riboflavin", "vitamin-b2-riboflavin" },
                    { 430, "Nutrient", "Vitamin B3, niacin", "vitamin b3 niacin", "vitamin-b3-niacin" },
                    { 431, "Nutrient", "Vitamin B5, pantotensyre", "vitamin b5 pantotensyre", "vitamin-b5-pantotensyre" },
                    { 432, "Nutrient", "Vitamin B7, biotin", "vitamin b7 biotin", "vitamin-b7-biotin" },
                    { 433, "Nutrient", "Vitamin B9, folat", "vitamin b9 folat", "vitamin-b9-folat" },
                    { 434, "Nutrient", "Vitamin B12, kobalamin", "vitamin b12 kobalamin", "vitamin-b12-kobalamin" },
                    { 435, "Nutrient", "Vitamin C, askorbinsyre", "vitamin c askorbinsyre", "vitamin-c-askorbinsyre" },
                    { 436, "Nutrient", "Vitamin D2, ergokalsiferol", "vitamin d2 ergokalsiferol", "vitamin-d2-ergokalsiferol" },
                    { 437, "Nutrient", "Vitamin D3, kolikalsiferol", "vitamin d3 kolikalsiferol", "vitamin-d3-kolikalsiferol" },
                    { 438, "Nutrient", "Vitamin E, tokoferol (E306)", "vitamin e tokoferol e306", "vitamin-e-tokoferol-e306" },
                    { 439, "Nutrient", "Vitamin K1, fyllokinon", "vitamin k1 fyllokinon", "vitamin-k1-fyllokinon" },
                    { 440, "Nutrient", "Vitamin K2, menakinon", "vitamin k2 menakinon", "vitamin-k2-menakinon" },
                    { 441, "Nutrient", "Kalium", "kalium", "kalium" },
                    { 442, "Nutrient", "Klorin", "klorin", "klorin" },
                    { 443, "Nutrient", "Natrium", "natrium", "natrium" },
                    { 444, "Nutrient", "Kalsium", "kalsium", "kalsium" },
                    { 445, "Nutrient", "Fosfor", "fosfor", "fosfor" },
                    { 446, "Nutrient", "Magnesium", "magnesium", "magnesium" },
                    { 447, "Nutrient", "Jern", "jern", "jern" },
                    { 448, "Nutrient", "Sink", "sink", "sink" },
                    { 449, "Nutrient", "Mangan", "mangan", "mangan" },
                    { 450, "Nutrient", "Kobber", "kobber", "kobber" },
                    { 451, "Nutrient", "Jod", "jod", "jod" },
                    { 452, "Nutrient", "Molybden", "molybden", "molybden" },
                    { 453, "Nutrient", "Selen", "selen", "selen" },
                    { 454, "Nutrient", "Fluor", "fluor", "fluor" },
                    { 455, "Nutrient", "Krom", "krom", "krom" },
                    { 456, "Nutrient", "Nikkel", "nikkel", "nikkel" },
                    { 457, "Nutrient", "Bor", "bor", "bor" },
                    { 458, "Nutrient", "Silisium", "silisium", "silisium" },
                    { 459, "Nutrient", "Vanadium", "vanadium", "vanadium" },
                    { 460, "Nutrient", "Salt", "salt", "salt" },
                    { 461, "Allergen", "Krepsdyr", "krepsdyr", "krepsdyr" },
                    { 462, "Allergen", "Sesamfrø", "sesamfrø", "sesamfro" },
                    { 463, "Allergen", "Nøtter", "nøtter", "notter" },
                    { 464, "Allergen", "Gluten", "gluten", "gluten" },
                    { 465, "Allergen", "Egg", "egg", "egg" },
                    { 466, "Allergen", "Fisk", "fisk", "fisk" },
                    { 467, "Allergen", "Skalldyr", "skalldyr", "skalldyr" },
                    { 468, "Allergen", "Sennep", "sennep", "sennep" },
                    { 469, "Allergen", "Selleri", "selleri", "selleri" },
                    { 470, "Allergen", "Peanøtter", "peanøtter", "peanotter" },
                    { 471, "Allergen", "Melk", "melk", "melk" },
                    { 472, "Allergen", "Sulfitt", "sulfitt", "sulfitt" },
                    { 473, "Allergen", "Soya", "soya", "soya" },
                    { 474, "Allergen", "Lupin", "lupin", "lupin" }
                });

            migrationBuilder.InsertData(
                table: "IngredientAllergens",
                columns: new[] { "AllergenId", "IngredientId", "Amount" },
                values: new object[,]
                {
                    { 4, 2, 4 },
                    { 11, 19, 4 },
                    { 5, 39, 4 }
                });

            migrationBuilder.InsertData(
                table: "IngredientNutrients",
                columns: new[] { "IngredientId", "NutrientId", "AmountPer100Grams" },
                values: new object[,]
                {
                    { 19, 1, 3.5m },
                    { 19, 2, 4.5m },
                    { 19, 3, 4.5m },
                    { 19, 6, 1m },
                    { 19, 7, 0.6m },
                    { 19, 13, 0.00015m },
                    { 19, 16, 0.000008m },
                    { 19, 18, 0.0000006m },
                    { 19, 25, 0.171m },
                    { 19, 28, 0.13m },
                    { 19, 29, 0.115m },
                    { 19, 35, 0.000016m },
                    { 19, 44, 0.10m }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "ChildRecipeSortOrder", "CountryCode", "DateCreated", "DateUpdated", "Description", "DifficultyLevel", "IsPublished", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "Url", "UserId" },
                values: new object[,]
                {
                    { 1, null, "NO", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy eller sukker og sitrondråper.", 0, true, "Pannekaker", 1, new TimeSpan(0, 1, 0, 0, 0), 7.4000000000000004, "pannekaker", null },
                    { 2, null, "TH", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "En fantastisk smakfull kyllingsuppe.", 1, true, "Tom Kha Gai", 2, new TimeSpan(0, 1, 0, 0, 0), 8.0999999999999996, "tom-kha-gai", null },
                    { 3, null, "IT", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "En enkel men utrolig god, klassisk pastarett.", 1, true, "Cacio e Pepe", 3, new TimeSpan(0, 0, 20, 0, 0), 8.0, "cacio-e-pepe", null },
                    { 4, null, "NO", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Den kjente og kjære norske klassikeren, akkurat som mamma lagde den.", 0, true, "Kjøttkaker med kålstuing", 4, new TimeSpan(0, 1, 0, 0, 0), 7.2999999999999998, "kjottkaker-med-kalstuing", null },
                    { 5, null, "MX", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Taco fra grunnen av! Hjemmelagde hvetetortillas, tacokrydder, guacamole og salsa. Denne oppskriften legger grunnlaget for en god helg!", 1, true, "Taco", 5, new TimeSpan(0, 1, 30, 0, 0), 9.5, "taco", null },
                    { 6, null, "NO", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Saftig og smaksrik.", 1, true, "Ovnsbakt hel ørret", 6, new TimeSpan(0, 1, 30, 0, 0), 8.0, "ovnsbakt-hel-orret", null }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "Notes", "SortOrder", "Unit" },
                values: new object[,]
                {
                    { 2, 1, 3.0, null, 1, 2 },
                    { 19, 1, 5.0, null, 2, 2 },
                    { 39, 1, 4.0, null, 3, 12 },
                    { 46, 1, 0.5, null, 4, 9 },
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
                    { 143, 5, 400.0, null, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeSteps",
                columns: new[] { "Id", "Image", "RecipeId", "SortOrder", "Text", "Title" },
                values: new object[,]
                {
                    { 1, null, 1, 1, "Bland mel og salt.", "Bland de tørre ingrediensene" },
                    { 2, null, 1, 2, "Ha i halvparten av melken og visp sammen til en tykk, klumpefri røre.", "Rør ut melken, steg 1/2" },
                    { 3, null, 1, 3, "Tilsett resten av melken og visp sammen.", "Rør ut melken, steg 2/2" },
                    { 4, null, 1, 4, "Tilsett eggene og visp sammen til røren blir fin og gul.", "Tilsett egg" },
                    { 5, null, 1, 5, "La røren hvile i minst 30 minutter for best resultat.", "Hviletid" },
                    { 6, null, 1, 6, "Ha smør eller margarin i pannen og stek pannekakene til de er gyldne på begge sider.", "Stek pannekakene" },
                    { 7, null, 1, 7, "Brett pannekakene og legg dem i en ildfast form med lokk. Slik holder de seg varme til alle er ferdig stekt.", "Hold pannekakene varme til servering" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "ChildRecipeSortOrder", "CountryCode", "DateCreated", "DateUpdated", "Description", "DifficultyLevel", "IsPublished", "Name", "ParentRecipeId", "PrepTime", "RatingAverage", "Url", "UserId" },
                values: new object[,]
                {
                    { 7, 1, "MX", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Smakfullt tex-mex-krydder.", 0, true, "Tacokrydder", 5, new TimeSpan(0, 0, 0, 10, 0), 8.6999999999999993, "tacokrydder", null },
                    { 8, 2, "MX", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Myke og deilige hvetetortillas! Perfekte til fredagstaco, laksewrap eller kyllingburrito!", 1, true, "Hvetetortillas", 5, new TimeSpan(0, 0, 30, 0, 0), 8.9000000000000004, "hvetetortillas", null },
                    { 9, 3, "MX", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Frisk og smakfull guacamole som er perfekt tilbehør til fredagstacoen!", 0, true, "Guacamole", 5, new TimeSpan(0, 0, 0, 10, 0), 9.6999999999999993, "guacamole", null },
                    { 10, 4, "MX", new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 3, 4, 13, 43, 51, 123, DateTimeKind.Local).AddTicks(6655), "Nydelig tomatsalsa som er perfekt tilbehør til fredagstacoen! Ha i chili etter smak, eller dropp chili for en mild salsa.", 0, true, "Tomatsalsa", 5, new TimeSpan(0, 0, 0, 10, 0), 9.5999999999999996, "tomat-salsa", null }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "Notes", "SortOrder", "Unit" },
                values: new object[,]
                {
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
                    { 46, 8, 0.5, null, 2, 9 },
                    { 61, 8, 60.0, null, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "RecipeNotes",
                columns: new[] { "Id", "Image", "RecipeId", "SortOrder", "Text", "Title" },
                values: new object[] { 1, null, 7, 1, "Hvis du ikke bruker opp all kryddermiksen, kan resten oppbevares i en lufttett beholder i opp til seks måneder uten å miste smak og aroma. Etter dette er det ikke farlig å bruke det, men smaken kan tape seg noe.", "Oppbevaring av rester" });

            migrationBuilder.InsertData(
                table: "RecipeSteps",
                columns: new[] { "Id", "Image", "RecipeId", "SortOrder", "Text", "Title" },
                values: new object[] { 8, null, 7, 1, "Bland alle ingrediensene i en morter og støt dem sammen til alt er godt blandet.", "Bland alt sammen" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_RecipeNotes_RecipeId",
                table: "RecipeNotes",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CountryCode",
                table: "Recipes",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ParentRecipeId",
                table: "Recipes",
                column: "ParentRecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSteps_RecipeId",
                table: "RecipeSteps",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "IngredientAllergens");

            migrationBuilder.DropTable(
                name: "IngredientNutrients");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "RecipeNotes");

            migrationBuilder.DropTable(
                name: "RecipeSteps");

            migrationBuilder.DropTable(
                name: "SearchIndex");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Allergens");

            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
