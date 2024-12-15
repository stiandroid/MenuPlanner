namespace MenuPlanner.Models.DTOs.Display
{
    public class IngredientDisplayDTO : IDomainDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;

        public bool HasImage { get; set; }
        public FoodGroup Type { get; set; }
        public List<IngredientNutrientDisplayDTO> IngredientNutrients { get; set; } = [];
        public List<IngredientAllergenDisplayDTO> IngredientAllergens { get; set; } = [];
    }
}
