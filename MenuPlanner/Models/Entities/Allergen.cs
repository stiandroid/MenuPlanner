namespace MenuPlanner.Models.Entities
{
    public class Allergen : ISearchableEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Auto-generert. "Nøtter" => "notter"
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
    }
}
