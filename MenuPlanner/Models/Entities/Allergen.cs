namespace MenuPlanner.Models.Entities
{
    public class Allergen : IDomainEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty; // Auto-generert. "Nøtter" => "notter"
        public int SortOrder { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public LifecycleState State { get; set; }
        public string? UserId { get; set; }

        public bool HasImage { get; set; }
        public string Icon { get; set; } = string.Empty;
    }
}
