namespace MenuPlanner.Models.DTOs.Display
{
    public class AllergenDisplayDTO : IDomainDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;

        public bool HasImage { get; set; }
        public string Icon { get; set; } = string.Empty;
    }
}
