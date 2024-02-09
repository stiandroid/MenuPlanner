using System.ComponentModel.DataAnnotations;

namespace MenuPlanner.Models.DTOs.Manage
{
    public class UserEditDTO
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(3, ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; } = string.Empty;

        public bool HasProfileImage { get; set; }

        public bool HasBackgropImage { get; set; }

        public string Introduction { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;

        [StringLength(30, MinimumLength = 10, ErrorMessage = "URL must be between 10 and 30 characters long (excluding \"https://\")")]
        public string? Website { get; set; }

        [StringLength(30, ErrorMessage = "Instagram username must be no longer than 30 characters.")]
        public string? Instagram { get; set; }

        [StringLength(15, ErrorMessage = "Twitter/X username must be no longer than 15 characters.")]
        public string? TwitterX { get; set; }

        [StringLength(50, ErrorMessage = "Facebook username must be no longer than 50 characters.")]
        public string? Facebook { get; set; }
    }
}
