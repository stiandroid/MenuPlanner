namespace MenuPlanner.Services.AllergenService
{
    public interface IAllergenService
    {
        Task<int> Count(LifecycleState state);
        Task<ServiceResponse<List<AllergenDisplayDTO>>> GetAll();
        Task<ServiceResponse<AllergenDisplayDTO>> GetByUrl(string url);
    }
}
