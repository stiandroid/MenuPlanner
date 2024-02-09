using Microsoft.CodeAnalysis.CSharp;

namespace MenuPlanner.Data
{
    public static class DataSeeding
    {
        public static List<Country> countries = [
            new Country { ISO3166_2 = "DE", Name = "Tyskland" },
            new Country { ISO3166_2 = "DK", Name = "Danmark" },
            new Country { ISO3166_2 = "ES", Name = "Spania" },
            new Country { ISO3166_2 = "FR", Name = "Frankrike" },
            new Country { ISO3166_2 = "GR", Name = "Hellas" },
            new Country { ISO3166_2 = "IT", Name = "Italia" },
            new Country { ISO3166_2 = "JP", Name = "Japan" },
            new Country { ISO3166_2 = "MX", Name = "Mexico" },
            new Country { ISO3166_2 = "NO", Name = "Norge" },
            new Country { ISO3166_2 = "PT", Name = "Portugal" },
            new Country { ISO3166_2 = "SE", Name = "Sverige" },
            new Country { ISO3166_2 = "TH", Name = "Thailand" }
        ];

        private static int _nutrientId = 0;
        private static int NextNutrientId() => ++_nutrientId;

        public static List<Nutrient> nutrients = [
            // - Protein
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Protein", Url = "protein", Type = NutrientType.Protein,
                Description = "Informasjon."
            },

            // Karbohydrater
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Karbohydrater", Url = "karbohydrater", Type = NutrientType.Carbohydrates,
                Description = "Total mengde karbohydrater, inkludert sukkerarter, polyoler og stivelse."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Sukkerarter", Url = "sukkerarter",
                Type = NutrientType.Sugars, SubTypeOf = NutrientType.Carbohydrates,
                Description = "Informasjon."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Polyoler", Url = "polyoler",
                Type = NutrientType.Polyols, SubTypeOf = NutrientType.Carbohydrates,
                Description = "Informasjon."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Stivelse", Url = "stivelse",
                Type = NutrientType.Starch, SubTypeOf = NutrientType.Carbohydrates,
                Description = "Informasjon."
            },

            // Fett
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Fett", Url = "fett",
                Type = NutrientType.Fats,
                Description = "Angir total mengde fett i en ingrediens, inkludert mettet, enumettet og flerumettet fett.", SortOrder = 1
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Mettet fett", Url = "mettet-fett",
                Type = NutrientType.SaturatedFats, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 1
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Enumettet fett", Url = "enumettet-fett",
                Type = NutrientType.MonounsaturatedFats, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 2
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Flerumettet fett", Url = "flerumettet-fett",
                Type = NutrientType.PolyunsaturatedFats, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 3
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Transfett", Url = "transfett",
                Type = NutrientType.TransFat, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 4
            },

            // Vitaminer
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin A, retinol", Url = "vitamin-a-retinol",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin B1, tiamin", Url = "vitamin-b1-tiamin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin B2, riboflavin", Url = "vitamin-b2-riboflavin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin B3, niacin", Url = "vitamin-b3-niacin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin B5, pantotensyre", Url = "vitamin-b5-pantotensyre",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin B7, biotin", Url = "vitamin-b7-biotin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin B9, folat", Url = "vitamin-b9-folat",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin B12, kobalamin", Url = "vitamin-b12-kobalamin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin C, askorbinsyre", Url = "vitamin-c-askorbinsyre",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin D2, ergokalsiferol", Url = "vitamin-d2-ergokalsiferol",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin D3, kolikalsiferol", Url = "vitamin-d3-kolikalsiferol",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin E, tokoferol (E306)", Url = "vitamin-e-tokoferol-e306",
                Type = NutrientType.Vitamin,
                Description = "Tokoferol (E306) betegner en blanding av de rene stoffene alfa-tokoferol (E307), gamma-tokoferol (E308) og delta-tokoferol (E309)."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin K1, fyllokinon", Url = "vitamin-k1-fyllokinon",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vitamin K2, menakinon", Url = "vitamin-k2-menakinon",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },

            // Mineraler
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Kalium", Url = "kalium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Potassium"
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Klorin", Url = "klorin", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Chlorine. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Natrium", Url = "natrium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Sodium. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Kalsium", Url = "kalsium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Calcium. Viktig for skjelettet og tennene."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Fosfor", Url = "fosfor", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Phosphorus."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Magnesium", Url = "magnesium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Magnesium."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Jern", Url = "jern", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Iron."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Sink", Url = "sink", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Zinc."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Mangan", Url = "mangan", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Manganese."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Kobber", Url = "kobber", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Copper."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Jod", Url = "jod", Type = NutrientType.Mineral,
                Description = "Engelsk navn: iodine."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Molybden", Url = "molybden", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Molybdenum."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Selen", Url = "selen", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Selenium."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Fluor", Url = "fluor", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Fluoride."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Krom", Url = "krom", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Chromium."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Nikkel", Url = "nikkel", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Nickel."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Bor", Url = "bor", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Boron."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Silisium", Url = "silisium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Silicon."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Vanadium", Url = "vanadium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Vanadium."
            },
            new Nutrient() { 
                Id = NextNutrientId(), Name = "Salt", Url = "salt", Type = NutrientType.Mineral,
                Description = "Natriumklorid (NaCl). Engelsk navn: Salt, sodium chloride."
            }
        ];

        public static List<Allergen> allergens = [
            new Allergen() {
                Id = 1, Name = "Krepsdyr", Url = "krepsdyr", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "crustacean.png", IsPublished = true
            },
            new Allergen() {
                Id = 2, Name = "Sesamfrø", Url = "sesamfro", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "sesame.png", IsPublished = true
            },
            new Allergen() {
                Id = 3, Name = "Nøtter", Url = "notter", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "nuts.png", IsPublished = true
            },
            new Allergen() {
                Id = 4, Name = "Gluten", Url = "gluten", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "gluten.png", IsPublished = true
            },
            new Allergen() {
                Id = 5, Name = "Egg", Url = "egg", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "egg.png", IsPublished = true
            },
            new Allergen() {
                Id = 6, Name = "Fisk", Url = "fisk", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "fish.png", IsPublished = true
            },
            new Allergen() {
                Id = 7, Name = "Skalldyr", Url = "skalldyr", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "shellfish.png", IsPublished = true
            },
            new Allergen() {
                Id = 8, Name = "Sennep", Url = "sennep", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "mustard.png", IsPublished = true
            },
            new Allergen() {
                Id = 9, Name = "Selleri", Url = "selleri", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "celery.png", IsPublished = true
            },
            new Allergen() {
                Id = 10, Name = "Peanøtter", Url = "peanotter", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "peanuts.png", IsPublished = true
            },
            new Allergen() {
                Id = 11, Name = "Melk", Url = "melk", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "milk.png", IsPublished = true
            },
            new Allergen() {
                Id = 12, Name = "Sulfitt", Url = "sulfitt", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "sulphite.png", IsPublished = true
            },
            new Allergen() {
                Id = 13, Name = "Soya", Url = "soya", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "", IsPublished = true
            },
            new Allergen() {
                Id = 14, Name = "Lupin", Url = "lupin", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "", IsPublished = true
            }
        ];

        private static int _ingredientId = 0;
        private static int NextIngredientId() => ++_ingredientId;

        public static List<Ingredient> ingredients = [
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvetemel",  Url = "hvetemel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sammalt hvete, grovmalt",  Url = "sammalt-hvete-grovmalt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sammalt hvete, finmalt",  Url = "sammalt-hvete-finmalt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvete helkorn",  Url = "hvete-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havregryn, lettkokt", Url = "havregryn-lettkokt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havregryn, store", Url = "havregryn-store", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havregryn, glutenfri", Url = "havregryn-glutenfri", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havremel", Url = "havremel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rug, helkorn", Url = "rug-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rugmel", Url = "rugmel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Bygg, helkorn", Url = "bygg-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Byggmel", Url = "byggmel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Gresskarkjerner", Url = "gresskarkjerner", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Skummet melk",  Url = "skummet-melk", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Lettmelk",  Url = "lettmelk", IsPublished = true, Type = FoodGroup.Dairy,
                EnergyKcalPer100g = 41, Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Helmelk",  Url = "helmelk", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kremfløte",  Url = "kremflote", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Matfløte",  Url = "matflote", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Lettrømme",  Url = "lettromme", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Seterrømme",  Url = "seterromme", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rømmekolle",  Url = "rommekolle", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kvarg",  Url = "kvarg", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Egg", Url = "egg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra høne. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eggeplomme", Url = "eggeplomme", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Eggeplomme fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggeplommer i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eggehvite", Url = "eggehvite", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Eggehvite fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggehviter i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Vaktelegg", Url = "vaktelegg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra vaktel."
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Måsegg", Url = "masegg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra måke (måse)."
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Salt", Url = "salt", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Tomatketsjup", Url = "tomatketsjup", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Søt sennep", Url = "sot-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sterk sennep", Url = "sterk-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Dijonsennep", Url = "dijonsennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grov sennep", Url = "grov-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Soyasaus", Url = "soyasaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Saltredusert soyasaus", Url = "saltredusert-soyasaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eddikessens", Url = "eddikessens", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "35%"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Klar eddik", Url = "klar-eddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Brun eddik", Url = "brun-eddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eplecidereddik", Url = "eplecidereddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvitvinseddik", Url = "hvitvinseddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rødvinseddik", Url = "rodvinseddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sitrondråper", Url = "sitrondråper", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Smør", Url = "smor", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Margarin", Url = "margarin", IsPublished = true, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sukker", Url = "sukker", IsPublished = true, Type = FoodGroup.Sweeteners,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Blåbær", Url = "blabar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Jordbær", Url = "jordbar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Bringebær", Url = "bringebar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grønne epler", Url = "gronne-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Røde epler", Url = "rode-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Gule epler", Url = "gule-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Appelsin", Url = "appelsin", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sitron", Url = "sitron", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Økologisk sitron", Url = "okologisk-sitron", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Lime", Url = "lime", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hermetiske mandarinbåter", Url = "hermetiske-mandarinbater", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hermetiske pærer", Url = "hermetiske-parer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hermetiske fersken", Url = "hermetiske-fersken", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Banan", Url = "banan", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Klementin", Url = "klementin", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Blå druer", Url = "bla-druer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grønne druer", Url = "gronne-druer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rosiner", Url = "rosiner", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextIngredientId(), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Korinter", Url = "korinter", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            }
        ];

        public static List<Recipe> recipes = [
            new Recipe(){ 
                Id = 1, CountryCode = "NO", Name = "Pannekaker", IsPublished = true, RatingAverage = 7.4,
                Url = "pannekaker", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1,0,0),
                Description = "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy eller sukker og sitrondråper."
            }
        ];

        public static List<RecipeStep> recipeSteps = [
            new RecipeStep() { Id = 1, RecipeId = 1, StepNumber = 1, 
                StepText = "Bland mel og salt."
            },
            new RecipeStep() { Id = 2, RecipeId = 1, StepNumber = 2, 
                StepText = "Ha i halvparten av melken og visp sammen til en tykk, klumpefri røre."
            },
            new RecipeStep() { Id = 3, RecipeId = 1, StepNumber = 3, 
                StepText = "Tilsett resten av melken og visp sammen."
            },
            new RecipeStep() { Id = 4, RecipeId = 1, StepNumber = 4, 
                StepText = "Tilsett eggene og visp sammen til røren blir fin og gul."
            },
            new RecipeStep() { Id = 5, RecipeId = 1, StepNumber = 5, 
                StepText = "La røren hvile i minst 30 minutter for best resultat."
            },
            new RecipeStep() { Id = 6, RecipeId = 1, StepNumber = 6, 
                StepText = "Ha smør eller margarin i pannen og stek pannekakene til de er gyldne på begge sider."
            },
            new RecipeStep() { Id = 7, RecipeId = 1, StepNumber = 7, 
                StepText = "Brett pannekakene og legg dem i en ildfast form med lokk. Slik holder de seg varme til alle er ferdig stekt."
            }
        ];

        private static int pannekakerId = recipes
            .Where(r => r.Name == "Pannekaker").Select(i => i.Id).FirstOrDefault();

        private static int hvetemelId = ingredients
            .Where(i => i.Name == "Hvetemel").Select(i => i.Id).FirstOrDefault();

        private static int lettmelkId = ingredients
            .Where(i => i.Name == "Lettmelk").Select(i => i.Id).FirstOrDefault();

        private static int totaltFettId = nutrients
            .Where(t => t.Type == NutrientType.Fats).Select(i => i.Id).FirstOrDefault();

        private static int mettetfettId = nutrients
            .Where(t => t.Type == NutrientType.SaturatedFats).Select(i => i.Id).FirstOrDefault();

        private static int karbohydraterTotaltId = nutrients
            .Where(t => t.Type == NutrientType.Carbohydrates).Select(i => i.Id).FirstOrDefault();

        private static int sukkerarterId = nutrients
            .Where(t => t.Type == NutrientType.Sugars).Select(i => i.Id).FirstOrDefault();

        private static int proteinId = nutrients
            .Where(t => t.Type == NutrientType.Protein).Select(i => i.Id).FirstOrDefault();

        private static int nutrientSaltId = nutrients
            .Where(t => t.Name == "Salt").Select(i => i.Id).FirstOrDefault();

        private static int riboflavinId = nutrients
            .Where(t => t.Name.Contains("riboflavin")).Select(i => i.Id).FirstOrDefault();

        private static int b12Id = nutrients
            .Where(t => t.Name.Contains("B12")).Select(i => i.Id).FirstOrDefault();

        private static int biotinId = nutrients
            .Where(t => t.Name.Contains("biotin")).Select(i => i.Id).FirstOrDefault();

        private static int kaliumId = nutrients
            .Where(t => t.Name.Contains("Kalium")).Select(i => i.Id).FirstOrDefault();

        private static int kalsiumId = nutrients
            .Where(t => t.Name.Contains("Kalsium")).Select(i => i.Id).FirstOrDefault();

        private static int fosforId = nutrients
            .Where(t => t.Name.Contains("Fosfor")).Select(i => i.Id).FirstOrDefault();

        private static int jodId = nutrients
            .Where(t => t.Name.Contains("Jod")).Select(i => i.Id).FirstOrDefault();

        private static int eggId = ingredients
            .Where(i => i.Name == "Egg").Select(i => i.Id).FirstOrDefault();

        private static int ingredientSaltId = ingredients
            .Where(i => i.Name == "Salt").Select(i => i.Id).FirstOrDefault();

        // Oppskrifter
        public static List<RecipeIngredient> recipeIngredients = [
            // Pannekaker
            new RecipeIngredient() {
                RecipeId = pannekakerId, IngredientId = hvetemelId, Amount = 3,
                Unit = MeasurementUnit.Deciliter, SortOrder = 1 },
            new RecipeIngredient() { 
                RecipeId = pannekakerId, IngredientId = lettmelkId, Amount = 5,
                Unit = MeasurementUnit.Deciliter, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = pannekakerId, IngredientId = eggId, Amount = 4,
                Unit = MeasurementUnit.Piece, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = pannekakerId, IngredientId = ingredientSaltId, Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 4 },
        ];

        // Ingrediensers næringsstoffer
        public static List<IngredientNutrient> ingredientNutrients = [
            // Lettmelk
            // Total fettmengde: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = totaltFettId, AmountPer100Grams = 1m },
            // Herav mettet fett: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = mettetfettId, AmountPer100Grams = 0.6m },
            // Karbohydrater totalt: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = karbohydraterTotaltId, AmountPer100Grams = 4.5m },
            // Sukkerarter: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = sukkerarterId, AmountPer100Grams = 4.5m },
            // Protein: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = proteinId, AmountPer100Grams = 3.5m },
            // Salt: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = nutrientSaltId, AmountPer100Grams = 0.10m },

            // Riboflavin: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = riboflavinId, AmountPer100Grams = 0.00015m }, // 0,15 mg
            // Vitamin B12: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = b12Id, AmountPer100Grams = 0.0000006m }, // 0,6 µg
            // Biotin: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = biotinId, AmountPer100Grams = 0.000008m }, // 8 µg
            // Kalium: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = kaliumId, AmountPer100Grams = 0.171m }, // 171 mg
            // Kalsium: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = kalsiumId, AmountPer100Grams = 0.13m }, // 130 mg
            // Fosfor: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = fosforId, AmountPer100Grams = 0.115m }, // 115 mg
            // Jod: 
            new IngredientNutrient() {
                IngredientId = lettmelkId, NutrientId = jodId, AmountPer100Grams = 0.000016m } // 16,0 µg
        ];

        // Ingrediensers allergener
        public static List<IngredientAllergen> ingredientAllergens = [
            // Lettmelk (AllergenId for melk = 11)
            new IngredientAllergen() {
                IngredientId = lettmelkId, AllergenId = 11, Amount = AllergenAmount.High },
            // Hvetemel (AllergenId for gluten = 4)
            new IngredientAllergen() {
                IngredientId = hvetemelId, AllergenId = 4, Amount = AllergenAmount.High },
            // Egg (AllergenId for egg = 5)
            new IngredientAllergen() {
                IngredientId = eggId, AllergenId = 5, Amount = AllergenAmount.High },
        ];
    }
}
