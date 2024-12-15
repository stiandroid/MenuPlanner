namespace MenuPlanner.Models.DTOs.Manage
{
    public class AllergenEditDTO : IDomainEditDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public LifecycleState State { get; set; }
        public string? UserId { get; set; }

        public string Icon { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
