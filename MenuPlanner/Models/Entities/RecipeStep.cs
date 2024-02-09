namespace MenuPlanner.Models.Entities
{
    public class RecipeStep
    {
        public int Id { get; set; }
        public int StepNumber { get; set; }
        public string StepText { get; set; } = string.Empty;
        public string? Image { get; set; }
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
