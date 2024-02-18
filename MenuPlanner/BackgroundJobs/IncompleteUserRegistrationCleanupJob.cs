namespace MenuPlanner.BackgroundJobs
{
    public class IncompleteUserRegistrationCleanupJob(
        IServiceProvider serviceProvider, 
        ILogger<IncompleteUserRegistrationCleanupJob> logger) : IJob
    {
        private readonly UserManager<User> _userManager = serviceProvider.GetRequiredService<UserManager<User>>();
        private readonly ILogger<IncompleteUserRegistrationCleanupJob> _logger = logger;

        public async Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("User cleanup job is running.");

            var expiredUserRegistrations = _userManager.Users
                .Where(u =>
                    u.EmailConfirmed == false &&
                    u.EmailConfirmationExpiryDate < DateTime.Now)
                .ToList();

            foreach (var user in expiredUserRegistrations)
            {
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"User '{user.UserName}' with unconfirmed email has been deleted.");
                }
                else
                {
                    _logger.LogError($"Error deleting user '{user.UserName}': {string.Join(", ", result.Errors)}");
                }
            }
        }
    }
}
