namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class RecipeNoteProfile : Profile
    {
        public RecipeNoteProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<RecipeNoteEditDTO, RecipeNote>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<RecipeNote, RecipeNoteEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<RecipeNote, RecipeNoteDisplayDTO>();
        }
    }
}
