namespace MenuPlanner.Models.DTOs.Display
{
    public class IngredientNutrientDisplayDTO
    {
        [Column(TypeName = "decimal(7,6)")] // Presisjon som passer for mikrogram. 1 mikrogram = 0,000001 gram
        public decimal AmountPer100Grams { get; set; }
        public NutrientDisplayDTO? Nutrient { get; set; }
    }
}
