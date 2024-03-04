namespace MenuPlanner.Services.IngredientService
{
    public class IngredientService(DataContext context, IMapper mapper) : IIngredientService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<int> CountTotal()
            => await _context.Ingredients.CountAsync();

        public async Task<int> CountPublished()
            => await _context.Ingredients.Where(i => i.IsPublished).CountAsync();

        public async Task<ServiceResponse<List<IngredientDisplayDTO>>> GetAll()
        {
            List<Ingredient>? ingredients = await _context.Ingredients.ToListAsync();
            return new ServiceResponse<List<IngredientDisplayDTO>>
            {
                Data = _mapper.Map<List<IngredientDisplayDTO>>(ingredients),
                Success = ingredients != null,
                Message = ingredients != null
                    ? "A list of all ingredients was successfully retrieved."
                    : "No ingredients were found."
            };
        }

        public async Task<ServiceResponse<IngredientDisplayDTO>> GetByUrl(string url)
        {
            Ingredient? ingredient = await _context.Ingredients
                .Include(i => i.IngredientNutrients)
                    .ThenInclude(n => n.Nutrient)
                .Include(i => i.IngredientAllergens)
                    .ThenInclude(a => a.Allergen)
                .FirstOrDefaultAsync(r => r.Url == url);
            if (ingredient != null && ingredient.IngredientNutrients != null)
            {
                ingredient.IngredientNutrients = ingredient.IngredientNutrients
                    .OrderBy(t => t.Ingredient.Type).ToList();
            }
            return new ServiceResponse<IngredientDisplayDTO>
            {
                Data = _mapper.Map<IngredientDisplayDTO>(ingredient),
                Success = ingredient != null,
                Message = ingredient != null
                    ? "The ingredient was successfully retrieved."
                    : "Ingredient not found."
            };
        }

        public async Task<ServiceResponse<IngredientEditDTO>> Edit(IngredientEditDTO ingredient)
        {
            Ingredient? dbIngredient;
            if (ingredient.Id == null) // => CREATE
            {
                dbIngredient = await Create(ingredient);
            }
            else // => UPDATE
            {
                dbIngredient = await Update(ingredient);
            }
            return new ServiceResponse<IngredientEditDTO>
            {
                Data = _mapper.Map<IngredientEditDTO>(dbIngredient),
                Success = dbIngredient != null,
                Message = dbIngredient != null
                    ? $"The ingredient was successfully {(ingredient.Id == null ? "created" : "updated")}."
                    : ingredient.Id == null
                        ? "Ingredient could not be created."
                        : "Ingredient not found."
            };
        }

        public async Task<ServiceResponse<List<IngredientDisplayDTO>>> Delete(int id)
        {
            try
            {
                Ingredient? dbIngredient = await _context.Ingredients.FindAsync(id);
                if (dbIngredient != null)
                {
                    _context.Remove(dbIngredient);
                    await _context.SaveChangesAsync();
                }
                return new ServiceResponse<List<IngredientDisplayDTO>>()
                {
                    Data = _mapper.Map<List<IngredientDisplayDTO>>
                            (await _context.Ingredients.ToListAsync()),
                    Success = dbIngredient != null,
                    Message = dbIngredient != null
                        ? "Ingredient was deleted."
                        : "Ingredient not found."
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<IngredientDisplayDTO>>()
                {
                    Data = _mapper.Map<List<IngredientDisplayDTO>>
                            (await _context.Ingredients.ToListAsync()),
                    Success = false,
                    Message = $"An error occured: {ex.Message}"
                };
            }
        }

        private async Task<Ingredient?> Create(IngredientEditDTO ingredient)
        {
            Ingredient newIngredient = _mapper!.Map<Ingredient>(ingredient);
            _context.Add(newIngredient);
            await _context.SaveChangesAsync();
            return newIngredient;
        }

        private async Task<Ingredient?> Update(IngredientEditDTO ingredient)
        {
            Ingredient? dbIngredient = await _context.Ingredients.FindAsync(ingredient.Id);
            _mapper.Map(source: ingredient, destination: dbIngredient);
            await _context.SaveChangesAsync();
            return dbIngredient;
        }
    }
}
