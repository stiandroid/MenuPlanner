namespace MenuPlanner.Models.Entities
{
    public class Ingredient : ISearchableEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public LifecycleState State { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Alias { get; set; } = string.Empty; // Eks.: Hvitost kalles ofte også gulost.
        public string Url { get; set; } = string.Empty; // Autogenerert: "Matfløte" => "matflote"
        public string Description { get; set; } = string.Empty;
        public bool HasImage { get; set; } // <img src="@($"{Id}.jpg")"> vises hvis HasImage == true
        public FoodGroup Type { get; set; }

        // Næringsinnhold per 100 gram:

        // Energi
        public double EnergyKcalPer100g { get; set; } // kcal per 100 gram

        // Næringsstoffer
        public List<IngredientNutrient> IngredientNutrients { get; set; } = []; // Mengder per 100 gram

        // Er alle næringsverdiene i denne ingrediensen verifisert av en fagautoritet?
        public bool IsNutritionallyVerified { get; set; }
        // Når ble den verfisert?
        public DateTime? DateVerified { get; set; }
        // Av hvilken organisasjon ble den verifisert?
        public string? VerificationAuthority { get; set; }
        // Hvilken person i organisasjonen foretok verifiseringen?
        public string? VerificationAuthorityPerson { get; set; }

        public List<RecipeIngredient> RecipeIngredients { get; set; } = [];
        public List<IngredientAllergen> IngredientAllergens { get; set; } = [];
    }
}