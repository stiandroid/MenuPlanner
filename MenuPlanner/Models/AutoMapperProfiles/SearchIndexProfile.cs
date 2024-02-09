using MenuPlanner.ExtensionMethods;

namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class SearchIndexProfile : Profile
    {
        public SearchIndexProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<SearchIndexEditDTO, SearchIndex>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<SearchIndex, SearchIndexEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<SearchIndex, SearchIndexDisplayDTO>();
        }
    }
}
