namespace MenuPlanner.Models.Entities
{
    public class IngredientAllergen
    {
        public int IngredientId { get; set; }
        public int AllergenId { get; set; }
        public AllergenAmount Amount { get; set; }
        public Ingredient? Ingredient { get; set; }
        public Allergen? Allergen { get; set; }
    }
}
