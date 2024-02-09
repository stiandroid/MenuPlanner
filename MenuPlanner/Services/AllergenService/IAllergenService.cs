namespace MenuPlanner.Services.AllergenService
{
    public interface IAllergenService
    {
        Task<ServiceResponse<List<AllergenDisplayDTO>>> GetAll();
        Task<ServiceResponse<AllergenDisplayDTO>> GetByUrl(string url);
    }
}
