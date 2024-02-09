namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class IngredientAllergenProfile : Profile
    {
        public IngredientAllergenProfile()
        {
            // View (Fra Entity til DisplayDTO)
            CreateMap<IngredientAllergen, IngredientAllergenDisplayDTO>();
        }
    }
}
