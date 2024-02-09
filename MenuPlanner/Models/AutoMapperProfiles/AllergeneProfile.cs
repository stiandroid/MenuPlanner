namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class AllergeneProfile : Profile
    {
        public AllergeneProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<AllergenEditDTO, Allergen>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<Allergen, AllergenEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<Allergen, AllergenDisplayDTO>();
        }
    }
}
