namespace MenuPlanner.Models.Entities
{
    public class User : IdentityUser // : ISearchableEntity - kanskje i versjon 2?
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool HasProfileImage { get; set; } // Bruke user-id som filnavn?
        public bool HasBackgropImage { get; set; } // Bruke user-id som filnavn?
        public string Introduction { get; set; } = string.Empty;
        public string? Website { get; set; }
        public string? Instagram { get; set; }
        public string? TwitterX { get; set; }
        public string? Facebook { get; set; }
        public List<Recipe> Recipes { get; set; } = [];
    }
}
