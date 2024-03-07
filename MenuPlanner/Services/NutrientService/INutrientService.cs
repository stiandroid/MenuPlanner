namespace MenuPlanner.Services.NutrientService
{
    public interface INutrientService
    {
        Task<int> Count(LifecycleState state);
        Task<ServiceResponse<List<NutrientDisplayDTO>>> GetAll();
        Task<ServiceResponse<NutrientDisplayDTO>> GetByUrl(string url);
        Task<ServiceResponse<NutrientEditDTO>> Edit(NutrientEditDTO nutrient);
        Task<ServiceResponse<List<NutrientDisplayDTO>>> Delete(int id);
    }
}
