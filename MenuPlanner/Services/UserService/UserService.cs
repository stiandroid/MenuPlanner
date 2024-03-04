namespace MenuPlanner.Services.UserService
{
    public class UserService(DataContext context) : IUserService
    {
        private readonly DataContext _context = context;

        public async Task<User?> GetByIdAsync(string id)
            => await _context.Users.FindAsync(id);

        public async Task<bool> UpdateAsync(User user)
        { 
            User? dbUser = await GetByIdAsync(user.Id);
            if (dbUser == null)
            {
                return false;
            }
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.Introduction = user.Introduction;
            dbUser.Website = user.Website;
            dbUser.Instagram = user.Instagram;
            dbUser.TwitterX = user.TwitterX;
            dbUser.Facebook = user.Facebook;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
