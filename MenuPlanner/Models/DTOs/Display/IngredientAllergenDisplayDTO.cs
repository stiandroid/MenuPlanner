namespace MenuPlanner.Models.DTOs.Display
{
    public class IngredientAllergenDisplayDTO
    {
        public AllergenAmount Amount { get; set; }
        public AllergenDisplayDTO? Allergen { get; set; }
    }
}
