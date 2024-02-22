namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<UserEditDTO, User>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<User, UserEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<User, UserDisplayDTO>();
        }
    }
}
