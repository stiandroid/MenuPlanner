namespace MenuPlanner.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string SearchIndexNormalize(this string input)
        {
            char[] validChars = "abcdefghijklmnopqrstuvwxyzæøå0123456789 ".ToCharArray();
            string output = new(input.ToLower()
                .Where(c => validChars.Contains(c))
                .ToArray());
            return output;
        }

        public static string GenerateVanityUrl(this string input)
            => input.SearchIndexNormalize().Trim().Replace(" ", "-");
    }
}
