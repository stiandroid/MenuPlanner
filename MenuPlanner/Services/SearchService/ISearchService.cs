namespace MenuPlanner.Services.SearchService
{
    public interface ISearchService
    {
        Task<ServiceResponse<(List<RecipeSummaryDisplayDTO> recipes, 
                              List<IngredientDisplayDTO> ingredients,
                              List<NutrientDisplayDTO> nutrients,
                              List<AllergenDisplayDTO> allergens)>>
            Search(string searchTerm);
    }
}
