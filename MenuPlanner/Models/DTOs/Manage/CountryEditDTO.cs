using System.ComponentModel.DataAnnotations;

namespace MenuPlanner.Models.DTOs.Manage
{
    public class CountryEditDTO
    {
        [Required]
        [StringLength(2)]
        public string ISO3166_2 { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
