namespace MenuPlanner.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<int> CountTotal();
        Task<int> CountPublished();
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetAll();
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetTop(int numberOfRecipes);
        Task<ServiceResponse<RecipeDetailsDisplayDTO>> GetByUrl(string url); // Url er autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"
        Task<ServiceResponse<RecipeEditDTO>> Edit(RecipeEditDTO recipe);
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> Delete(int id);
    }
}
