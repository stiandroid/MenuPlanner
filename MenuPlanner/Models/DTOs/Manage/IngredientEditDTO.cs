namespace MenuPlanner.Models.DTOs.Manage
{
    public class IngredientEditDTO
    {
        public int? Id { get; set; }
        public bool HasImage { get; set; }
        public bool IsPublished { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public FoodGroup Type { get; set; }
    }
}
