namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class AllergenProfile : Profile
    {
        public AllergenProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<AllergenEditDTO, Allergen>()
                .ForMember(dest => dest.DateCreated, opt => opt.Ignore())
                .ForMember(dest => dest.DateUpdated, opt => opt.Ignore());

            // Edit (Fra Entity til EditDTO)
            CreateMap<Allergen, AllergenEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<Allergen, AllergenDisplayDTO>();
        }
    }
}
