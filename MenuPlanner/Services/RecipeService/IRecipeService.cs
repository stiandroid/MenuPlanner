using MudBlazor;

namespace MenuPlanner.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<int> Count(LifecycleState state);
        //Task<IQueryable<Recipe>> GetQueryableWithState(LifecycleState state);

        Task<TableData<RecipeSummaryDisplayDTO>> GetPagedWithState(
            LifecycleState state, 
            string searchString, 
            int page, 
            int pageSize, 
            SortDirection sorting);

        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetAllWithState(LifecycleState state);
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetParentsWithState(LifecycleState state);
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> GetTop(int numberOfRecipes);
        Task<ServiceResponse<RecipeDetailsDisplayDTO>> GetBySlug(string slug, LifecycleState state); // Slug er autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"
        Task<ServiceResponse<RecipeEditDTO>> Edit(RecipeEditDTO recipe);
        Task<ServiceResponse<int>> Publish(string url);
        Task<ServiceResponse<List<RecipeSummaryDisplayDTO>>> Delete(int id);
    }
}
