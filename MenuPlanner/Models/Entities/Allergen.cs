namespace MenuPlanner.Models.Entities
{
    public class Allergen : ISearchableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Auto-generert. "Nøtter" => "notter"
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsPublished { get; set; }
    }
}
