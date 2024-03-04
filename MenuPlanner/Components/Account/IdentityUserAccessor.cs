namespace MenuPlanner.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager
                    .RedirectToWithStatus(
                        "Account/InvalidUser", 
                        $"Finner ikke bruker med ID '{userManager.GetUserId(context.User)}'.", 
                        context, 
                        MessageType.Danger);
            }

            return user;
        }
    }
}
