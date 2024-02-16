namespace MenuPlanner.Utilities
{
    public static class VisualUtilities
    {
        public static string GetLoginProviderIcon(string name) => name switch
        {
            "Google" => "google",
            "Facebook" => "facebook",
            "Instagram" => "instagram",
            "Microsoft" => "microsoft",
            "X" => "twitter-x",
            _ => "patch-question"
        };
    }
}
