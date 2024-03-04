namespace MenuPlanner.Models.Entities
{
    public class Recipe : ISearchableEntity
    {
        public int Id { get; set; }
        public int ParentRecipeId { get; set; } // For hovedoppskrifter er ParentRecipeId = Id.
        public string? UserId { get; set; } // Id fra IdentityUser er string
        public User? User { get; set; }
        public int? ChildRecipeSortOrder { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public TimeSpan PrepTime { get; set; }
        public bool IsPublished { get; set; }
        public string? CountryCode { get; set; }
        public Country? Country { get; set; }
        public List<RecipeIngredient>? RecipeIngredients { get; set; }
        public List<RecipeStep>? Steps { get; set; }
        public List<RecipeNote>? Notes { get; set; }
        public List<Recipe>? SubRecipes { get; set; }

        // Verdiene i disse feltene settes programmatisk, og er ikke med i RecipeEditDTO:
        public double? RatingAverage { get; set; }
        public string Url { get; set; } = string.Empty; // Autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
