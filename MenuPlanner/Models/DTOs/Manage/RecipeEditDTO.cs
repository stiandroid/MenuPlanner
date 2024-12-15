namespace MenuPlanner.Models.DTOs.Manage
{
    public class RecipeEditDTO : IDomainEditDTO
    {
        public int? Id { get; set; } // == null ? create : update
        [StringLength(10, ErrorMessage = "Oppskriftsnavnet må være minst 10 tegn langt.")]
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public LifecycleState State { get; set; }
        public string? UserId { get; set; }

        public int? ParentRecipeId { get; set; } // En oppskrift kan være hoved- eller underoppskrift.

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
