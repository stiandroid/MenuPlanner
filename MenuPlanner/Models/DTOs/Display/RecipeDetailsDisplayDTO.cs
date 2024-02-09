namespace MenuPlanner.Models.DTOs.Display
{
    public class RecipeDetailsDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"
        public string Description { get; set; } = string.Empty;
        public DifficultyLevel DifficultyLevel { get; set; }
        public double? RatingAverage { get; set; }
        public TimeSpan PrepTime { get; set; }
        public CountryDisplayDTO? Country { get; set; }

        // SubRecipes vises under hovedoppskriften. Legg til sortering av disse etterhvert.
        public List<RecipeDetailsDisplayDTO> SubRecipes { get; set; } = [];
        public List<RecipeStepDisplayDTO> Steps { get; set; } = [];
        public List<RecipeIngredientDisplayDTO> RecipeIngredients { get; set; } = [];
        public UserDisplayDTO? User { get; set; }
    }
}
