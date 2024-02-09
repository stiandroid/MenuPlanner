namespace MenuPlanner.Services.RecipeService
{
    public class RecipeService(DataContext context, IMapper mapper) : IRecipeService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetAll()
        {
            List<Recipe>? recipes = await _context.Recipes
                .Include(c => c.Country)
                .ToListAsync();
            return new ServiceResponse<List<RecipeSummaryDisplayDTO>>
            {
                Data = _mapper.Map<List<RecipeSummaryDisplayDTO>>(recipes),
                Success = recipes != null,
                Message = recipes != null
                    ? "A list of all ingredients was successfully retrieved."
                    : "No ingredients were found."
            };
        }

        public async Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetTop(int numberOfRecipes)
        {
            List<Recipe>? recipes = await _context.Recipes
                .Include(c => c.Country)
                .OrderBy(r => r.RatingAverage)
                .Take(numberOfRecipes)
                .ToListAsync();
            return new ServiceResponse<List<RecipeSummaryDisplayDTO>>
            {
                Data = _mapper.Map<List<RecipeSummaryDisplayDTO>>(recipes),
                Success = recipes != null,
                Message = recipes != null
                    ? "A list of all ingredients was successfully retrieved."
                    : "No ingredients were found."
            };
        }

        public async Task<ServiceResponse<RecipeDetailsDisplayDTO>> GetByUrl(string url)
        {
            Recipe? recipe = await _context.Recipes
                .Include(ri => ri.RecipeIngredients)
                    .ThenInclude(i => i.Ingredient)
                        .ThenInclude(ia => ia.IngredientAllergens)
                            .ThenInclude(a => a.Allergen)
                .Include(s => s.Steps)
                .Include(c => c.Country)
                .Include(u => u.User)
                .FirstOrDefaultAsync(r => r.Url == url);
            if (recipe != null)
            { 
                if (recipe.Steps != null)
                { 
                    recipe.Steps = recipe.Steps.OrderBy(s => s.StepNumber).ToList();
                }
            }
            return new ServiceResponse<RecipeDetailsDisplayDTO>
            {
                Data = _mapper.Map<RecipeDetailsDisplayDTO>(recipe),
                Success = recipe != null,
                Message = recipe != null
                    ? "The recipe was successfully retrieved."
                    : "Recipe not found."
            };
        }

        public async Task<ServiceResponse<RecipeEditDTO>> Edit(RecipeEditDTO recipe)
        {
            Recipe? dbRecipe;
            if (recipe.Id == null) // => CREATE
            {
                dbRecipe = await Create(recipe);
            }
            else // => UPDATE
            {
                dbRecipe = await Update(recipe);
            }
            return new ServiceResponse<RecipeEditDTO>
            {
                Data = _mapper.Map<RecipeEditDTO>(dbRecipe),
                Success = dbRecipe != null,
                Message = dbRecipe != null
                    ? $"The recipe was successfully {(recipe.Id == null ? "created" : "updated")}."
                    : recipe.Id == null
                        ? "Recipe could not be created."
                        : "Recipe not found."
            };
        }

        public async Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> Delete(int id)
        {
            try
            {
                Recipe? dbRecipe = await _context.Recipes.FindAsync(id);
                if (dbRecipe != null)
                {
                    _context.Remove(dbRecipe);
                    await _context.SaveChangesAsync();
                }
                return new ServiceResponse<List<RecipeSummaryDisplayDTO>>()
                {
                    Data = _mapper.Map<List<RecipeSummaryDisplayDTO>>
                            (await _context.Recipes.ToListAsync()),
                    Success = dbRecipe != null,
                    Message = dbRecipe != null
                        ? "Recipe was deleted."
                        : "Recipe not found."
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<RecipeSummaryDisplayDTO>>()
                {
                    Data = _mapper.Map<List<RecipeSummaryDisplayDTO>>
                            (await _context.Recipes.ToListAsync()),
                    Success = false,
                    Message = $"An error occured: {ex.Message}"
                };
            }
        }

        private async Task<Recipe?> Create(RecipeEditDTO recipe)
        {
            Recipe newRecipe = _mapper!.Map<Recipe>(recipe);
            _context.Add(newRecipe);
            await _context.SaveChangesAsync();
            return newRecipe;
        }

        private async Task<Recipe?> Update(RecipeEditDTO recipe)
        {
            Recipe? dbRecipe = await _context.Recipes.FindAsync(recipe.Id);
            _mapper.Map(source: recipe, destination: dbRecipe);
            await _context.SaveChangesAsync();
            return dbRecipe;
        }
    }
}
