namespace MenuPlanner.Services.SearchService
{
    public interface ISearchService
    {
        Task<ServiceResponse<(List<RecipeSummaryDisplayDTO> recipes, 
                              List<IngredientDisplayDTO> ingredients, 
                              List<NutrientDisplayDTO> nutrients)>>
            Search(string searchTerm);
    }
}
