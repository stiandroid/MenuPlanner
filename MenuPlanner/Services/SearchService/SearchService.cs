using System.Linq.Expressions;

namespace MenuPlanner.Services.SearchService
{
    public class SearchService(DataContext context, IMapper mapper) : ISearchService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<ServiceResponse<(
            List<RecipeSummaryDisplayDTO> recipes,
            List<IngredientDisplayDTO> ingredients,
            List<NutrientDisplayDTO> nutrients)>>
            Search(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    return new ServiceResponse<(
                        List<RecipeSummaryDisplayDTO> recipes,
                        List<IngredientDisplayDTO> ingredients,
                        List<NutrientDisplayDTO> nutrients)>()
                    {
                        Success = false,
                        Message = "No search term provided"
                    };
                }

                var recipesResults = await SearchEntity<Recipe>(searchTerm, entity => entity.Name);
                var ingredientsResults = await SearchEntity<Ingredient>(searchTerm, entity => entity.Name);
                var nutrientsResults = await SearchEntity<Nutrient>(searchTerm, entity => entity.Name);

                var mappedResults =
                (_mapper.Map<List<RecipeSummaryDisplayDTO>>(recipesResults),
                 _mapper.Map<List<IngredientDisplayDTO>>(ingredientsResults),
                 _mapper.Map<List<NutrientDisplayDTO>>(nutrientsResults));

                bool success = (recipesResults != null) || (ingredientsResults != null) || (nutrientsResults != null);

                return new ServiceResponse<(
                    List<RecipeSummaryDisplayDTO> recipes, List<IngredientDisplayDTO> ingredients, List<NutrientDisplayDTO> nutrients)>()
                {
                    Data = mappedResults,
                    Success = success,
                    Message = success
                            ? "Search results were returned"
                            : "No matches found"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<(
                    List<RecipeSummaryDisplayDTO> recipes,
                    List<IngredientDisplayDTO> ingredients,
                    List<NutrientDisplayDTO> nutrients)>()
                {
                    Success = false,
                    Message = $"An error occurred: {ex.Message}"
                };
            }
        }

        private async Task<List<T>> SearchEntity<T>
            (string searchTerm, Expression<Func<T, string>> propertySelector) where T : class
        {
            string[] searchWords = [.. searchTerm.Split('+', StringSplitOptions.RemoveEmptyEntries)];

            List<T> allEntities = await _context.Set<T>().ToListAsync();
            Func<T, bool>? predicate = BuildSearchPredicate(propertySelector, searchWords);

            var filteredEntities = allEntities
                .Where(predicate).ToList();

            return filteredEntities;
        }

        private static Func<T, bool> BuildSearchPredicate<T>
            (Expression<Func<T, string>> propertySelector, string[] searchWords)
        {
            return entity =>
            {
                var stringToSearch = propertySelector.Compile()(entity);

                if (stringToSearch == null) return false;

                bool matchResult = searchWords.Any(searchWord =>
                    stringToSearch.Contains(searchWord, StringComparison.CurrentCultureIgnoreCase));

                return matchResult;
            };
        }
    }
}
