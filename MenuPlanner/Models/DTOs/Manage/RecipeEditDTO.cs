namespace MenuPlanner.Models.DTOs.Manage
{
    public class RecipeEditDTO
    {
        public int? Id { get; set; } // == null ? create : update
        public bool IsPublished { get; set; }
        public bool IsDraft { get; set; } // true for upublisert kopi av oppskriften
        public int? ParentRecipeId { get; set; } // En oppskrift kan være hoved- eller underoppskrift.
        public int? ChildRecipeSortOrder { get; set; }

        [StringLength(10, ErrorMessage = "Oppskriftsnavnet må være minst 10 tegn langt.")]
        public string Name { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public string? Description { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }

        [Range(typeof(TimeSpan), "0.0:05:00", "365.00:00:00", ErrorMessage = "Tilberedelsestiden må være mellom 5 minutter og 1 år.")]
        public TimeSpan PrepTime { get; set; }
        public string? CountryCode { get; set; }
        public List<RecipeIngredientEditDTO>? RecipeIngredients { get; set; }
        public List<RecipeStepEditDTO>? Steps { get; set; }
        public List<RecipeNoteEditDTO>? Notes { get; set; }
        public List<RecipeEditDTO>? SubRecipes { get; set; }
    }
}
