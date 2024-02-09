namespace MenuPlanner.Models.DTOs.Manage
{
    public class AllergenEditDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Auto-generert. "Nøtter" => "notter"
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
    }
}
