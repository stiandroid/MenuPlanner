using MenuPlanner.ExtensionMethods;

namespace MenuPlanner.Data
{
    public class DataContext(DbContextOptions<DataContext> options, IMapper mapper) : IdentityDbContext<User>(options)
    {
        private readonly IMapper _mapper = mapper;

        private static int _searchIndexId = 0;
        private static int NextIndex() => ++_searchIndexId;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasKey(naturalKey =>
                    naturalKey.ISO3166_2);

            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(compositeKey => new {
                    compositeKey.RecipeId,
                    compositeKey.IngredientId
                });

            modelBuilder.Entity<IngredientNutrient>()
                .HasKey(compositeKey => new {
                    compositeKey.IngredientId,
                    compositeKey.NutrientId
                });

            modelBuilder.Entity<IngredientAllergen>()
                .HasKey(compositeKey => new {
                    compositeKey.IngredientId,
                    compositeKey.AllergenId
                });

            modelBuilder.Entity<Recipe>() // En oppskrift kan ha underoppskrifter. Nyttig n�r en oppskrift best�r av flere elementer, som f.eks. kj�tt, saus, br�d, salat.
                .HasMany(r => r.SubRecipes)
                .WithOne()
                .HasForeignKey(r => r.ParentRecipeId)
                .OnDelete(DeleteBehavior.NoAction); // P� grunn av "cycles or multiple cascade paths" m� sletting av tilh�rende oppskrifter skje manuelt i koden.

            modelBuilder.Entity<Recipe>()
                .HasMany(s => s.Steps)
                .WithOne(r => r.Recipe)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Recipe>() // En oppskrift har ett land, et land har mange oppskrifter
                .HasOne(c => c.Country)
                .WithMany()
                .HasForeignKey(cc => cc.CountryCode);

            modelBuilder.Entity<Recipe>() // En oppskrift har mange ingredienser, en ingrediens har mange oppskrifter
                .HasMany(ri => ri.RecipeIngredients)
                .WithOne(r => r.Recipe)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ingredient>() // En ingrediens har mange allergener, et allergen finnes i mange ingredienser
                .HasMany(ia => ia.IngredientAllergens)
                .WithOne(i => i.Ingredient)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ingredient>() // En ingrediens har mange n�ringsstoffer, et n�ringsstoff finnes i mange ingredienser
                .HasMany(n => n.IngredientNutrients)
                .WithOne(i => i.Ingredient)
                .OnDelete(DeleteBehavior.Cascade);


            // Seeding

            // Land
            modelBuilder.Entity<Country>()
                .HasData(DataSeeding.Countries);

            // N�ringsstoffer
            modelBuilder.Entity<Nutrient>()
                .HasData(DataSeeding.Nutrients);

            // Allergener
            modelBuilder.Entity<Allergen>()
                .HasData(DataSeeding.Allergens);

            // Oppskrifter
            modelBuilder.Entity<Recipe>()
                .HasData(DataSeeding.ParentRecipes);
            modelBuilder.Entity<Recipe>()
                .HasData(DataSeeding.ChildRecipes);

            // Steg for oppskrifter
            modelBuilder.Entity<RecipeStep>()
                .HasData(DataSeeding.RecipeSteps);

            // Merknader for oppskrifter
            modelBuilder.Entity<RecipeNote>()
                .HasData(DataSeeding.RecipeNotes);

            // Ingredienser
            modelBuilder.Entity<Ingredient>()
                .HasData(DataSeeding.Ingredients);

            // Mange-til-mange-linke-tabell for n�ringsstoffer i ingredienser
            modelBuilder.Entity<IngredientNutrient>()
                .HasData(DataSeeding.IngredientNutrients);

            // Mange-til-mange-linke-tabell for allergener i ingredienser
            modelBuilder.Entity<IngredientAllergen>()
                .HasData(DataSeeding.IngredientAllergens);

            // Mange-til-mange-linke-tabell for ingredienser i oppskrifter
            modelBuilder.Entity<RecipeIngredient>()
                .HasData(DataSeeding.RecipeIngredients);

            // SearchIndex
            // Kombinasjonstabell for Recipe, Ingredient, Nutrient og Allergen for mer effektivt s�k
            List<SearchIndex> searchIndex = [];
            foreach (var recipe in DataSeeding.ParentRecipes)
            {
                searchIndex.Add(new SearchIndex() { 
                    Id = NextIndex(),
                    EntityType = "Recipe",
                    Name = recipe.Name,
                    NormalizedName = recipe.Name.SearchIndexNormalize(),
                    Slug = recipe.Slug
                });
            }
            foreach (var ingredient in DataSeeding.Ingredients)
            {
                searchIndex.Add(new SearchIndex()
                {
                    Id = NextIndex(),
                    EntityType = "Ingredient",
                    Name = ingredient.Name,
                    NormalizedName = ingredient.Name.SearchIndexNormalize(),
                    Slug = ingredient.Slug
                });
            }
            foreach (var nutrient in DataSeeding.Nutrients)
            {
                searchIndex.Add(new SearchIndex()
                {
                    Id = NextIndex(),
                    EntityType = "Nutrient",
                    Name = nutrient.Name,
                    NormalizedName = nutrient.Name.SearchIndexNormalize(),
                    Slug = nutrient.Slug
                });
            }
            foreach (var allergen in DataSeeding.Allergens)
            {
                searchIndex.Add(new SearchIndex()
                {
                    Id = NextIndex(),
                    EntityType = "Allergen",
                    Name = allergen.Name,
                    NormalizedName = allergen.Name.SearchIndexNormalize(),
                    Slug = allergen.Slug
                });
            }
            modelBuilder.Entity<SearchIndex>()
                .HasData(searchIndex);
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeStep> RecipeSteps { get; set; }
        public DbSet<RecipeNote> RecipeNotes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientNutrient> IngredientNutrients { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<IngredientAllergen> IngredientAllergens { get; set; }
        public DbSet<Allergen> Allergens { get; set; }
        public DbSet<SearchIndex> SearchIndex { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
