namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<IngredientEditDTO, Ingredient>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<Ingredient, IngredientEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<Ingredient, IngredientDisplayDTO>();
        }
    }
}
