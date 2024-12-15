namespace MenuPlanner.Models.Entities
{
    public class Recipe : IDomainEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty; // Autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"
        public int SortOrder { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public LifecycleState State { get; set; }
        public string? UserId { get; set; } // Id fra IdentityUser er string

        public int? ParentRecipeId { get; set; }
        public User? User { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public TimeSpan PrepTime { get; set; }
        public string? CountryCode { get; set; }
        public double? RatingAverage { get; set; }
        public Country? Country { get; set; }
        public List<RecipeIngredient>? RecipeIngredients { get; set; }
        public List<RecipeStep>? Steps { get; set; }
        public List<RecipeNote>? Notes { get; set; }
        public List<Recipe>? SubRecipes { get; set; }

    }
}
