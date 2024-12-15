namespace MenuPlanner.Services.IngredientService
{
    public interface IIngredientService
    {
        Task<int> Count(LifecycleState state);
        Task<ServiceResponse<List<IngredientDisplayDTO>>> GetAll();
        Task<ServiceResponse<IngredientDisplayDTO>> GetBySlug(string url);
        Task<ServiceResponse<IngredientEditDTO>> Edit(IngredientEditDTO ingredient);
        Task<ServiceResponse<List<IngredientDisplayDTO>>> Delete(int id);
    }
}
