namespace MenuPlanner.Services.IngredientService
{
    public interface IIngredientService
    {
        Task<int> CountTotal();
        Task<int> CountPublished();
        Task<ServiceResponse<List<IngredientDisplayDTO>>> GetAll();
        Task<ServiceResponse<IngredientDisplayDTO>> GetByUrl(string url);
        Task<ServiceResponse<IngredientEditDTO>> Edit(IngredientEditDTO ingredient);
        Task<ServiceResponse<List<IngredientDisplayDTO>>> Delete(int id);
    }
}
