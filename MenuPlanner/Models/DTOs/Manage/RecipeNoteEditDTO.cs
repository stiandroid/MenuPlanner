namespace MenuPlanner.Models.DTOs.Manage
{
    public class RecipeNoteEditDTO
    {
        public int? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string? Image { get; set; }
        public int SortOrder { get; set; }
    }
}
