namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            // Create/Edit (EditDTO til Entity)
            CreateMap<CountryEditDTO, Country>();

            // View (Entity til DisplayDTO)
            CreateMap<Country, CountryDisplayDTO>();
        }
    }
}
