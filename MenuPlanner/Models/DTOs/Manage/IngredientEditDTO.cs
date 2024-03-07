namespace MenuPlanner.Models.DTOs.Manage
{
    public class IngredientEditDTO
    {
        public int? Id { get; set; }
        public LifecycleState State { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Alias { get; set; } = string.Empty; // Gulost <=> Hvitost
        public bool HasImage { get; set; }
        public string Description { get; set; } = string.Empty;
        public FoodGroup Type { get; set; }
    }
}
