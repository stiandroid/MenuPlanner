namespace MenuPlanner.Models.DTOs.Manage
{
    public class UserEditDTO
    {
        public string? Id { get; set; }
        public bool IsProtectedSystemUser { get; set; }


        [StringLength(30, MinimumLength = 2, ErrorMessage = "Fornavn må være minst to og maks 30 tegn langt")]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(30, MinimumLength = 2, ErrorMessage = "Etternavn må være minst to og maks 30 tegn langt")]
        public string LastName { get; set; } = string.Empty;
        
        public List<RoleDisplayDTO>? Roles { get; set; }

        public bool HasProfileImage { get; set; }

        public bool HasBackgropImage { get; set; }

        public string Introduction { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-postadresse er påkrevet")]
        public string Email { get; set; } = string.Empty;

        [StringLength(30, MinimumLength = 10, ErrorMessage = "URL må være fra 10 til 30 tegn (uten \"https://\")")]
        public string? Website { get; set; }

        [StringLength(30, ErrorMessage = "Instagram-brukernavn kan ikke være lenger enn 30 tegn.")]
        public string? Instagram { get; set; }

        [StringLength(15, ErrorMessage = "Twitter/X-brukernavn kan ikke være lenger enn 15 tegn.")]
        public string? TwitterX { get; set; }

        [StringLength(50, ErrorMessage = "Facebook-brukernavn kan ikke være lenger enn 50 tegn.")]
        public string? Facebook { get; set; }
    }
}
