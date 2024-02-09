namespace MenuPlanner.Models.DTOs.Manage
{
    public class RecipeIngredientEditDTO
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public double Amount { get; set; }
        public MeasurementUnit Unit { get; set; }
        public int SortOrder { get; set; }
        public string? Notes { get; set; }

        // Skal disse to være med?
        public RecipeEditDTO Recipe { get; set; } = new();
        public IngredientEditDTO Ingredient { get; set; } = new();
    }
}
