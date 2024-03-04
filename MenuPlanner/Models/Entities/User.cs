namespace MenuPlanner.Models.Entities
{
    public class User : IdentityUser // : ISearchableEntity - kanskje i versjon 2?
    {
        public bool IsProtectedSystemUser { get; set; } // Hvis true => Kan ikke slettes av andre admins eller seg selv, og kan ikke endres av andre enn seg selv.
        public DateTime DateRegistered { get; set; }
        public DateTime? EmailConfirmationExpiryDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool HasProfileImage { get; set; } // Bruke user-id som filnavn
        public bool HasBackgropImage { get; set; } // Bruke user-id som filnavn
        public string? Introduction { get; set; }
        public string? Website { get; set; }
        public string? Instagram { get; set; }
        public string? TwitterX { get; set; }
        public string? Facebook { get; set; }
        public List<Recipe> Recipes { get; set; } = [];
    }
}
