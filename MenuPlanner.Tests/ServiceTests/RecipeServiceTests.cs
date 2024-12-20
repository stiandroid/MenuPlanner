﻿namespace MenuPlanner.Tests.ServiceTests
{
    public class RecipeServiceTests : IClassFixture<TestFixture>
    {
        private readonly TestFixture _testFixture;
        private readonly IMapper _mapper;
        private readonly DataContext? _dataContext;
        private readonly RecipeService _recipeService;

        public RecipeServiceTests(TestFixture fixture)
        {
            _testFixture = fixture;
            _mapper = _testFixture.Mapper;

            // Felles Arrange for alle tester:
            _dataContext = _testFixture.DbContext;
            _recipeService = new RecipeService(_dataContext, _mapper);
        }

        [Fact]
        public async Task GetAllWithState_ShouldReturnListOfCurrentRecipeSummaries()
        {
            // Arrange
            int expectedCount = await _dataContext!.Recipes
                .Where(r => 
                    r.ParentRecipeId == null &&
                    r.State == LifecycleState.Current)
                .CountAsync();

            // Act
            var result = await _recipeService.GetAllWithState(LifecycleState.Current);

            // Ensure result is a list of the correct type
            Assert.IsType<ServiceResponse<List<RecipeSummaryDisplayDTO>>>(result);

            // result.Data contains the correct number of items
            int actualCount = result.Data?.Count ?? 0;
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public async Task GetBySlug_ShouldReturnRequestedIngredient()
        {
            // Arrange
            // Add an ingredient to the test database
            string name = $"GETBYID{Guid.NewGuid()}";
            var newRecipe = new Recipe()
            {
                Name = name,
                Slug = name,
                State = LifecycleState.Draft
            };
            _dataContext!.Recipes.Add(newRecipe);
            await _dataContext.SaveChangesAsync();

            // Act
            var result = await _recipeService.GetBySlug(name);

            // Assert
            Assert.True(result.Success);
            Assert.Equal(newRecipe.Slug, result.Data?.Slug); // result.Data har ikke Id

            // Clean-up
            if (result.Success) // Ingrediensen ble opprettet, så da må vi slette den igjen
            {
                Recipe? dbRecipe = await _dataContext.Recipes.FindAsync(newRecipe.Id);
                if (dbRecipe != null)
                {
                    _dataContext.Remove(dbRecipe);
                    await _dataContext.SaveChangesAsync();
                }
            }
        }

        [Fact]
        public async Task Create_ShouldCreateRecipe()
        {
            // Arrange
            string name = $"CREATED {DateTime.Now}";
            RecipeEditDTO newRecipe = new() { Name = name, State = LifecycleState.Draft };

            // Act
            var result = await _recipeService.Edit(newRecipe); // Id = null => Create new

            // Assert
            Recipe? dbRecipe = await _dataContext!.Recipes
                .Where(i => i.Name == name)
                .FirstOrDefaultAsync();

            Assert.NotNull(dbRecipe);
            Assert.Equal(newRecipe.Name, dbRecipe.Name);

            // Clean-up
            if (dbRecipe != null)
            {
                _dataContext.Remove(dbRecipe);
                await _dataContext.SaveChangesAsync();
            }
        }

        [Fact]
        public async Task Update_ShouldChangeNameOfARecipe()
        {
            // Arrange
            // ---- Create a new recipe
            string originalName = $"TO UPDATE {DateTime.Now}";
            Recipe newRecipe = new()
            {
                Name = originalName,
                State = LifecycleState.Draft,
                Description = "This recipe was created by the test project for the purpose of testing the UPDATE-method of the RecipeService."
            };
            _dataContext!.Add(newRecipe);
            await _dataContext.SaveChangesAsync(); // <-- newRecipe.Id får en verdi her

            // ---- Load the new recipe from DB and set a new name
            string updatedName = $"UPDATED {DateTime.Now}";
            newRecipe.Name = updatedName;

            // Act
            RecipeEditDTO recipeDto = new()
            {
                Id = newRecipe.Id,
                Name = newRecipe.Name,
                State = LifecycleState.Draft
            };
            var result = await _recipeService.Edit(recipeDto); // Id != null => Update

            // Assert
            Recipe? dbRecipe = await _dataContext.Recipes.FindAsync(newRecipe.Id);
            Assert.True(result.Success);
            Assert.NotEqual(dbRecipe!.Name, originalName);

            // Clean-up
            if (dbRecipe != null)
            {
                _dataContext.Remove(dbRecipe);
                await _dataContext.SaveChangesAsync();
            }
        }

        [Fact]
        public async Task Delete_ShouldRemoveRecipeFromDatabase()
        {
            // Arrange
            // Create and add an recipe to the test database
            Recipe newRecipe = new();
            _dataContext!.Recipes.Add(newRecipe);
            await _dataContext.SaveChangesAsync();

            // Act
            var result = await _recipeService.Delete(newRecipe!.Id);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Success); // Success = true if the ingredient was removed
        }
    }
}
