namespace MenuPlanner.Models.Entities
{
    public class IngredientNutrient
    {
        public int IngredientId { get; set; }
        public int NutrientId { get; set; }

        [Column(TypeName = "decimal(9,8)")] // Presisjon som passer for mikrogram. 1 mikrogram = 0,000001 gram
        public decimal AmountPer100Grams { get; set; }

        public Ingredient? Ingredient { get; set; }
        public Nutrient? Nutrient { get; set; }
    }
}
