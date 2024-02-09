namespace MenuPlanner.Models.Entities
{
    public class Ingredient : ISearchableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Autogenerert: "Matfløte" => "matflote"
        public string Description { get; set; } = string.Empty;
        public bool HasImage { get; set; } // <img src="@($"{Id}.jpg")"> vises hvis HasImage == true
        public bool IsPublished { get; set; }
        public FoodGroup Type { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

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