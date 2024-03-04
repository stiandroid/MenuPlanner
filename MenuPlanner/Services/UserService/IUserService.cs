namespace MenuPlanner.Services.UserService
{
    public interface IUserService
    {
        Task<User?> GetByIdAsync(string id);
        Task<bool> UpdateAsync(User user);
    }
}
