namespace MenuPlanner.Services.RecipeService
{
    public class RecipeService(DataContext context, IMapper mapper) : IRecipeService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Count(LifecycleState state)
            => await _context.Recipes.Where(r => r.State == state).CountAsync();

        public async Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetAll() // published/current
        {
            List<Recipe>? recipes = await _context.Recipes
                .Include(c => c.Country)
                .Include(u => u.User)
                .Include(s => s.SubRecipes)
                .Where(p => 
                    p.ParentRecipeId == null &&
                    p.State == LifecycleState.Current)
                .ToListAsync();
            return new ServiceResponse<List<RecipeSummaryDisplayDTO>>
            {
                Data = _mapper.Map<List<RecipeSummaryDisplayDTO>>(recipes),
                Success = recipes != null,
                Message = recipes != null
                    ? "A list of all parent recipes was successfully retrieved."
                    : "No recipes were found."
            };
        }

        public async Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetTop(int numberOfRecipes)
        {
            List<Recipe>? recipes = await _context.Recipes
                .Include(c => c.Country)
                .Include(u => u.User)
                .Include(s => s.SubRecipes)
                .Where(p => p.ParentRecipeId == null)
                .OrderBy(r => r.RatingAverage)
                .Take(numberOfRecipes)
                .ToListAsync();
            return new ServiceResponse<List<RecipeSummaryDisplayDTO>>
            {
                Data = _mapper.Map<List<RecipeSummaryDisplayDTO>>(recipes),
                Success = recipes != null,
                Message = recipes != null
                    ? $"A list of the {numberOfRecipes} highest rated recipes was successfully retrieved."
                    : "No recipes were found."
            };
        }

        public async Task<ServiceResponse<RecipeDetailsDisplayDTO>> GetByUrl(string url)
        {
            Recipe? recipe = await _context.Recipes
                .Include(r => r.User)
                .Include(r => r.Country)
                .Include(r => r.RecipeIngredients.OrderBy(o => o.SortOrder))
                    .ThenInclude(ri => ri.Ingredient)
                .Include(r => r.Steps.OrderBy(o => o.SortOrder))
                .Include(r => r.Notes.OrderBy(o => o.SortOrder))
                .Include(r => r.SubRecipes.OrderBy(o => o.ChildRecipeSortOrder))
                    .ThenInclude(sub => sub.User)
                .Include(r => r.SubRecipes.OrderBy(o => o.ChildRecipeSortOrder))
                    .ThenInclude(sub => sub.Country)
                .Include(r => r.SubRecipes.OrderBy(o => o.ChildRecipeSortOrder))
                    .ThenInclude(sub => sub.RecipeIngredients.OrderBy(o => o.SortOrder))
                        .ThenInclude(ri => ri.Ingredient)
                .Include(r => r.SubRecipes.OrderBy(o => o.ChildRecipeSortOrder))
                    .ThenInclude(sub => sub.Steps.OrderBy(o => o.SortOrder))
                .Include(r => r.SubRecipes.OrderBy(o => o.ChildRecipeSortOrder))
                    .ThenInclude(sub => sub.Notes.OrderBy(o => o.SortOrder))
                .SingleOrDefaultAsync(r => r.Url == url);

            // Hack: Fjerne parent-oppskriften fra sub-oppskriftene.
            //if (recipe != null && recipe.SubRecipes != null)
            //{ 
            //    recipe.SubRecipes = recipe.SubRecipes.Where(r => r.Url != recipe.Url).ToList();
            //}

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

        public async Task<ServiceResponse<int>> Publish(string url)
        {
            Recipe? recipe = await _context.Recipes.FirstOrDefaultAsync(r => r.Url == url);
            if (recipe == null)
            {

            }
            return new ServiceResponse<int>() { 
                Data = 0,
                Success = false,
                Message = "Method not implemented."
            };
        }
    }
}
