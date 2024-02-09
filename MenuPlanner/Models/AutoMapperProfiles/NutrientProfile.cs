namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class NutrientProfile : Profile
    {
        public NutrientProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<NutrientEditDTO, Nutrient>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<Nutrient, NutrientEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<Nutrient, NutrientDisplayDTO>();
        }
    }
}
