namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<RoleEditDTO, Role>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<Role, RoleEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<Role, RoleDisplayDTO>();
        }
    }
}
