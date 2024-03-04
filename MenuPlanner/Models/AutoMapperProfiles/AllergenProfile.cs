namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class AllergenProfile : Profile
    {
        public AllergenProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<AllergenEditDTO, Allergen>()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Updated, opt => opt.Ignore());

            // Edit (Fra Entity til EditDTO)
            CreateMap<Allergen, AllergenEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<Allergen, AllergenDisplayDTO>();
        }
    }
}
