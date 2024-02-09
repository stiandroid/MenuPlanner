namespace MenuPlanner.Models.DTOs.Manage
{
    public class RecipeStepEditDTO
    {
        public int? Id { get; set; }
        public int StepNumber { get; set; }
        public string StepText { get; set; } = string.Empty;
        public string? Image { get; set; }
        public int RecipeId { get; set; }
    }
}
