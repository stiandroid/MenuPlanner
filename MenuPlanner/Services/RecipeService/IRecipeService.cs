namespace MenuPlanner.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<int> Count(LifecycleState state);
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetAll();
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetTop(int numberOfRecipes);
        Task<ServiceResponse<RecipeDetailsDisplayDTO>> GetByUrl(string url); // Url er autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"
        Task<ServiceResponse<RecipeEditDTO>> Edit(RecipeEditDTO recipe);
        Task<ServiceResponse<int>> Publish(string url);
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> Delete(int id);
    }
}
