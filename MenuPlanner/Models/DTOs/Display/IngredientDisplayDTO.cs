namespace MenuPlanner.Models.DTOs.Display
{
    public class IngredientDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Autogenerert: "Matfløte" => "matflote"
        public bool HasImage { get; set; }
        public string Description { get; set; } = string.Empty;
        public FoodGroup Type { get; set; }
        public List<IngredientNutrientDisplayDTO> IngredientNutrients { get; set; } = [];
        public List<IngredientAllergenDisplayDTO> IngredientAllergens { get; set; } = [];
    }
}
