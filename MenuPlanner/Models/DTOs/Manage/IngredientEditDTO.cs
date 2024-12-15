namespace MenuPlanner.Models.DTOs.Manage
{
    public class IngredientEditDTO : IDomainEditDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public LifecycleState State { get; set; }
        public string? UserId { get; set; }

        public bool HasImage { get; set; }
        public FoodGroup Type { get; set; }
    }
}
