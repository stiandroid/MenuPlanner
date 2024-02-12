namespace MenuPlanner.Tests.ServiceTests
{
    public class IngredientServiceTests : IClassFixture<TestFixture>
    {
        private readonly TestFixture _testFixture;
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;
        private readonly IngredientService _ingredientService;

        public IngredientServiceTests(TestFixture fixture)
        {
            _testFixture = fixture;
            _mapper = _testFixture.Mapper;

            // Felles Arrange for alle tester:
            _dataContext = _testFixture.DbContext;
            _ingredientService = new IngredientService(_dataContext, _mapper);
        }

        [Fact]
        public async Task GetAll_ShouldReturnListOfIngredients()
        {
            // Arrange
            int expectedCount = await _dataContext!.Ingredients.CountAsync();

            // Act
            var result = await _ingredientService.GetAll();

            // Assert
            // The result is a list of the correct type
            Assert.IsType<ServiceResponse<List<IngredientDisplayDTO>>>(result);

            // result.Data contains the correct number of items
            int actualCount = result.Data!.Count;
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public async Task GetByUrl_ShouldReturnRequestedIngredient()
        {
            // Arrange
            // Create and add an ingredient to the test database
            string name = $"GETBYURL {DateTime.Now}";
            var newIngredient = new Ingredient() 
            { 
                Name = name,
                Url = name,
                IsPublished = false
            };
            _dataContext.Ingredients.Add(newIngredient);
            await _dataContext.SaveChangesAsync();

            // Act
            var result = await _ingredientService.GetByUrl(name);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Equal(newIngredient.Url, result.Data?.Url);

            // Clean-up
            if (result.Success) // Ingrediensen ble opprettet, så da må vi slette den igjen
            {
                Ingredient? dbIngredient = await _dataContext.Ingredients
                    .FindAsync(newIngredient.Id);
                if (dbIngredient != null)
                {
                    _dataContext.Remove(dbIngredient);
                    await _dataContext.SaveChangesAsync();
                }
            }
        }

        [Fact]
        public async Task Create_ShouldCreateIngredient()
        {
            // Arrange
            string name = $"CREATED {DateTime.Now}";
            IngredientEditDTO newIngredient = new() { Name = name, IsPublished = false };

            // Act
            var result = await _ingredientService.Edit(newIngredient); // Id = null => Create new

            // Assert
            Ingredient? dbIngredient = await _dataContext.Ingredients
                .Where(i => i.Name == name)
                .FirstOrDefaultAsync();

            Assert.NotNull(dbIngredient);
            Assert.Equal(newIngredient.Name, dbIngredient.Name);

            // Clean-up
            if (dbIngredient != null)
            {
                _dataContext.Remove(dbIngredient);
                await _dataContext.SaveChangesAsync();
            }
        }

        [Fact]
        public async Task Update_ShouldChangeTheNameOfAnIngredient()
        {
            // Arrange
            // ---- Create a new ingredient
            string originalName = $"TO UPDATE {DateTime.Now}";
            Ingredient newIngredient = new() { 
                Name = originalName, 
                IsPublished = false, 
                Description = "This ingredient was created by the test project for the purpose of testing the UPDATE-method of the IngredientService."
            };
            _dataContext.Add(newIngredient);
            await _dataContext.SaveChangesAsync(); // <-- newIngredient.Id får en verdi her

            // ---- Load the new ingredient from DB and set a new name
            string updatedName = $"UPDATED {DateTime.Now}";
            newIngredient.Name = updatedName;

            // Act
            IngredientEditDTO ingredientDto = new() { 
                Id = newIngredient.Id,
                Name = newIngredient.Name,
                IsPublished = false,
            };
            var result = await _ingredientService.Edit(ingredientDto); // Id != null => Update

            // Assert
            Ingredient? dbIngredient = await _dataContext.Ingredients.FindAsync(newIngredient.Id);
            Assert.True(result.Success);
            Assert.NotEqual(dbIngredient.Name, originalName);

            // Clean-up
            if (dbIngredient != null)
            {
                _dataContext.Remove(dbIngredient);
                await _dataContext.SaveChangesAsync();
            }
        }

        [Fact]
        public async Task Delete_ShouldRemoveIngredientFromDatabase()
        {
            // Arrange
            // Create and add an ingredient to the test database
            Ingredient newIngredient = new();
            _dataContext.Ingredients.Add(newIngredient);
            await _dataContext.SaveChangesAsync();

            // Act
            var result = await _ingredientService.Delete(newIngredient!.Id);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Success); // Success = true if the ingredient was removed
        }
    }
}
