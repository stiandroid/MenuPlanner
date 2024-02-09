namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class IngredientNutrientProfile : Profile
    {
        public IngredientNutrientProfile()
        {
            // View (Fra Entity til DisplayDTO)
            CreateMap<IngredientNutrient, IngredientNutrientDisplayDTO>();
        }
    }
}
