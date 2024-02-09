namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class RecipeStepProfile : Profile
    {
        public RecipeStepProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<RecipeStepEditDTO, RecipeStep>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<RecipeStep, RecipeStepEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<RecipeStep, RecipeStepDisplayDTO>();
        }
    }
}
