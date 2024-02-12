namespace MenuPlanner.Tests
{ 
    public class TestFixture
    {
        public DataContext DbContext { get; }
        public IMapper Mapper { get; }

        public TestFixture()
        {
            // Build configuration (for å få tak i connection string fra hovedprosjektet)
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Set the base path to the test project directory
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // DbContext:
            string? connectionString = configuration
                .GetConnectionString("TestDBConnection"); // Kjør unit-tester mot test-databasen
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseSqlServer(connectionString).Options;
            DbContext = new DataContext(options, Mapper);

            // AutoMapper:
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AllergenProfile>();
                cfg.AddProfile<CountryProfile>();
                cfg.AddProfile<IngredientAllergenProfile>();
                cfg.AddProfile<IngredientNutrientProfile>();
                cfg.AddProfile<IngredientProfile>();
                cfg.AddProfile<NutrientProfile>();
                cfg.AddProfile<RecipeIngredientProfile>();
                cfg.AddProfile<RecipeProfile>();
                cfg.AddProfile<RecipeStepProfile>();
                cfg.AddProfile<SearchIndexProfile>();
            });
            mapperConfiguration.AssertConfigurationIsValid();
            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}
