namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class RecipeIngredientProfile : Profile
    {
        public RecipeIngredientProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<RecipeIngredientEditDTO, RecipeIngredient>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<RecipeIngredient, RecipeIngredientEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<RecipeIngredient, RecipeIngredientDisplayDTO>();
        }
    }
}
