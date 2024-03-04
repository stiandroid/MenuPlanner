namespace MenuPlanner.Models.Entities
{
    public class RecipeStep
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string? Image { get; set; }
        public int SortOrder { get; set; }
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
