namespace MenuPlanner.Models.Entities
{
    public class Recipe : ISearchableEntity
    {
        public int Id { get; set; }
        public int? ParentRecipeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"
        public string Description { get; set; } = string.Empty;
        public List<RecipeStep>? Steps { get; set; }
        public List<Recipe> SubRecipes { get; set; } = [];
        public string? MainImage { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public TimeSpan PrepTime { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public double? RatingAverage { get; set; }
        public string? UserId { get; set; } // Id fra IdentityUser er string
        public bool IsPublished { get; set; }
        public string? CountryCode { get; set; }
        public Country? Country { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; } = [];
        public User? User { get; set; }
    }
}
