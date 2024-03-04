namespace MenuPlanner.Services.AllergenService
{
    public interface IAllergenService
    {
        Task<int> CountTotal();
        Task<int> CountPublished();
        Task<ServiceResponse<List<AllergenDisplayDTO>>> GetAll();
        Task<ServiceResponse<AllergenDisplayDTO>> GetByUrl(string url);
    }
}
