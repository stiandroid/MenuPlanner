namespace MenuPlanner.Services.UserService
{
    public interface IUserService
    {
        Task<int> CountTotal();
        Task<User?> GetByIdAsync(string id);
        Task<bool> UpdateAsync(User user);
    }
}
