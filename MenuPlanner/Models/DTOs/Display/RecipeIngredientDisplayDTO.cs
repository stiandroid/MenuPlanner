namespace MenuPlanner.Models.DTOs.Display
{
    public class RecipeIngredientDisplayDTO
    {
        public string? Notes { get; set; }
        public double Amount { get; set; }
        public MeasurementUnit Unit { get; set; }
        //public RecipeDTO Recipe { get; set; } = new();
        public IngredientDisplayDTO Ingredient { get; set; } = new();
    }
}
