namespace MenuPlanner.Data
{
    public static class DataSeeding
    {
        public static List<IdentityRole> roles = new() { 
            new IdentityRole{ Name = "SysAdmin",        NormalizedName = "SYSADMIN",        Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "UserAdmin",       NormalizedName = "USERADMIN",       Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "RecipeEditor",    NormalizedName = "RECIPEEDITOR",    Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "RecipeMod",       NormalizedName = "RECIPEMOD",       Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "IngredientEditor",NormalizedName = "INGREDIENTEDITOR",Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "IngredientMod",   NormalizedName = "INGREDIENTMOD",   Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "NutrientAdmin",   NormalizedName = "NUTRIENTADMIN",   Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "AllergenAdmin",   NormalizedName = "ALLERGENADMIN",   Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "ArticleEditor",   NormalizedName = "ARTICLEEDITOR",   Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "ArticleMod",      NormalizedName = "ARTICLEMOD",      Id = Guid.NewGuid().ToString() },
            new IdentityRole{ Name = "CommunityMod",    NormalizedName = "COMMUNITYMOD",    Id = Guid.NewGuid().ToString() }
        };

        private static string? GetRoleId(string roleName)
            => roles.Where(r => r.Name == roleName).Select(i => i.Id).FirstOrDefault();

        private static string adminEmail = "stian.saether@gmail.com";
        private static string adminPhone = "90794163";
        public static List<User> users = new() {
            new User{
                Id = Guid.NewGuid().ToString(),
                FirstName = "Stian",
                LastName = "Sæther",
                Email = adminEmail,
                NormalizedEmail = adminEmail.ToUpper(),
                UserName = adminEmail,
                NormalizedUserName = adminEmail.ToUpper(),
                PhoneNumber = adminPhone,
                LockoutEnabled = false
            }
        };

        private static string? GetUserId(string userName)
            => users.Where(r => r.UserName == userName).Select(i => i.Id).FirstOrDefault();

        public static List<IdentityUserRole<string>> userRoles = new() { 
            new IdentityUserRole<string>{ UserId = GetUserId("stian.saether@gmail.com")!, RoleId = GetRoleId("SysAdmin")! }
        };

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
            new Country { ISO3166_2 = "TH", Name = "Thailand" },
            new Country { ISO3166_2 = "GB", Name = "Storbritannia" },
            new Country { ISO3166_2 = "US", Name = "USA" }
        ];

        private static int intValue = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reset">Hvis True, ressettes tallrekken til 1. Hvis False øker verdien med 1.</param>
        /// <returns>Et heltall 1 høyere enn det forrige.</returns>
        private static int NextInt(bool reset)
        {
            if (reset)
            {
                intValue = 0;
            }
            return ++intValue;
        }

        public static List<Nutrient> nutrients = new() { 
            // - Protein
            new Nutrient() {
                Id = NextInt(false), Name = "Protein", Url = "protein", Type = NutrientType.Protein,
                Description = "Informasjon."
            },

            // Karbohydrater
            new Nutrient() {
                Id = NextInt(false), Name = "Karbohydrater", Url = "karbohydrater", Type = NutrientType.Carbohydrates,
                Description = "Total mengde karbohydrater, inkludert sukkerarter, polyoler og stivelse."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Sukkerarter", Url = "sukkerarter",
                Type = NutrientType.Sugars, SubTypeOf = NutrientType.Carbohydrates,
                Description = "Informasjon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Polyoler", Url = "polyoler",
                Type = NutrientType.Polyols, SubTypeOf = NutrientType.Carbohydrates,
                Description = "Informasjon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Stivelse", Url = "stivelse",
                Type = NutrientType.Starch, SubTypeOf = NutrientType.Carbohydrates,
                Description = "Informasjon."
            },

            // Fett
            new Nutrient() {
                Id = NextInt(false), Name = "Fett", Url = "fett",
                Type = NutrientType.Fats,
                Description = "Angir total mengde fett i en ingrediens, inkludert mettet, enumettet og flerumettet fett.", SortOrder = 1
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Mettet fett", Url = "mettet-fett",
                Type = NutrientType.SaturatedFats, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 1
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Enumettet fett", Url = "enumettet-fett",
                Type = NutrientType.MonoUnsaturatedFats, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 2
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Flerumettet fett", Url = "flerumettet-fett",
                Type = NutrientType.PolyUnsaturatedFats, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 3
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Transfett", Url = "transfett",
                Type = NutrientType.TransFat, SubTypeOf = NutrientType.Fats,
                Description = "Informasjon", SortOrder = 4
            },

            // Vitaminer
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin A, retinol", Url = "vitamin-a-retinol",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B1, tiamin", Url = "vitamin-b1-tiamin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B2, riboflavin", Url = "vitamin-b2-riboflavin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B3, niacin", Url = "vitamin-b3-niacin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B5, pantotensyre", Url = "vitamin-b5-pantotensyre",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B7, biotin", Url = "vitamin-b7-biotin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B9, folat", Url = "vitamin-b9-folat",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B12, kobalamin", Url = "vitamin-b12-kobalamin",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin C, askorbinsyre", Url = "vitamin-c-askorbinsyre",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin D2, ergokalsiferol", Url = "vitamin-d2-ergokalsiferol",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin D3, kolikalsiferol", Url = "vitamin-d3-kolikalsiferol",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin E, tokoferol (E306)", Url = "vitamin-e-tokoferol-e306",
                Type = NutrientType.Vitamin,
                Description = "Tokoferol (E306) betegner en blanding av de rene stoffene alfa-tokoferol (E307), gamma-tokoferol (E308) og delta-tokoferol (E309)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin K1, fyllokinon", Url = "vitamin-k1-fyllokinon",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin K2, menakinon", Url = "vitamin-k2-menakinon",
                Type = NutrientType.Vitamin,
                Description = "Informasjon"
            },

            // Mineraler
            new Nutrient() {
                Id = NextInt(false), Name = "Kalium", Url = "kalium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Potassium"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Klorin", Url = "klorin", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Chlorine. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Natrium", Url = "natrium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Sodium. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Kalsium", Url = "kalsium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Calcium. Viktig for skjelettet og tennene."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Fosfor", Url = "fosfor", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Phosphorus."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Magnesium", Url = "magnesium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Magnesium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Jern", Url = "jern", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Iron."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Sink", Url = "sink", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Zinc."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Mangan", Url = "mangan", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Manganese."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Kobber", Url = "kobber", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Copper."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Jod", Url = "jod", Type = NutrientType.Mineral,
                Description = "Engelsk navn: iodine."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Molybden", Url = "molybden", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Molybdenum."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Selen", Url = "selen", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Selenium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Fluor", Url = "fluor", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Fluoride."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Krom", Url = "krom", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Chromium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Nikkel", Url = "nikkel", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Nickel."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Bor", Url = "bor", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Boron."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Silisium", Url = "silisium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Silicon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vanadium", Url = "vanadium", Type = NutrientType.Mineral,
                Description = "Engelsk navn: Vanadium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Salt", Url = "salt", Type = NutrientType.Mineral,
                Description = "Natriumklorid (NaCl). Engelsk navn: Salt, sodium chloride."
            }
        };

        private static int GetNutrientId(string url)
            => nutrients.Where(n => n.Url == url).Select(i => i.Id).FirstOrDefault();

        public static List<Allergen> allergens = new() { 
            new Allergen() {
                Id = NextInt(true), Name = "Krepsdyr", Url = "krepsdyr", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "crustacean.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sesamfrø", Url = "sesamfro", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "sesame.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Nøtter", Url = "notter", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "nuts.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Gluten", Url = "gluten", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "gluten.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Egg", Url = "egg", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "egg.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Fisk", Url = "fisk", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "fish.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Skalldyr", Url = "skalldyr", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "shellfish.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sennep", Url = "sennep", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "mustard.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Selleri", Url = "selleri", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "celery.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Peanøtter", Url = "peanotter", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "peanuts.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Melk", Url = "melk", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "milk.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sulfitt", Url = "sulfitt", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "sulphite.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Soya", Url = "soya", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Lupin", Url = "lupin", Description = "Informasjon",
                DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Icon = "", Image = "", IsPublished = true
            }
        };

        private static int GetAllergenId(string url)
            => allergens.Where(a => a.Url == url).Select(i => i.Id).FirstOrDefault();

        public static List<Ingredient> ingredients = new(){
            new Ingredient(){
                Id = NextInt(true), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvetemel",  Url = "hvetemel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sammalt hvete, grovmalt",  Url = "sammalt-hvete-grovmalt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sammalt hvete, finmalt",  Url = "sammalt-hvete-finmalt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvete helkorn",  Url = "hvete-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havregryn, lettkokt", Url = "havregryn-lettkokt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havregryn, store", Url = "havregryn-store", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havregryn, glutenfri", Url = "havregryn-glutenfri", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Havremel", Url = "havremel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rug, helkorn", Url = "rug-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rugmel", Url = "rugmel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Bygg, helkorn", Url = "bygg-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Byggmel", Url = "byggmel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Gresskarkjerner", Url = "gresskarkjerner", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Skummet melk",  Url = "skummet-melk", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Lettmelk",  Url = "lettmelk", IsPublished = true, Type = FoodGroup.Dairy,
                EnergyKcalPer100g = 41, Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Helmelk",  Url = "helmelk", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kremfløte",  Url = "kremflote", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Matfløte",  Url = "matflote", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Lettrømme",  Url = "lettromme", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Seterrømme",  Url = "seterromme", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rømmekolle",  Url = "rommekolle", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kvarg",  Url = "kvarg", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Egg", Url = "egg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra høne. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eggeplomme", Url = "eggeplomme", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Eggeplomme fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggeplommer i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eggehvite", Url = "eggehvite", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Eggehvite fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggehviter i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Vaktelegg", Url = "vaktelegg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra vaktel."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Måsegg", Url = "masegg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra måke (måse)."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Salt", Url = "salt", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Tomatketsjup", Url = "tomatketsjup", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Søt sennep", Url = "sot-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sterk sennep", Url = "sterk-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Dijonsennep", Url = "dijonsennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grov sennep", Url = "grov-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Soyasaus", Url = "soyasaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Saltredusert soyasaus", Url = "saltredusert-soyasaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eddikessens", Url = "eddikessens", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "35%"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Klar eddik", Url = "klar-eddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Brun eddik", Url = "brun-eddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Eplecidereddik", Url = "eplecidereddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvitvinseddik", Url = "hvitvinseddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rødvinseddik", Url = "rodvinseddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sitrondråper", Url = "sitrondråper", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Smør", Url = "smor", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Margarin", Url = "margarin", IsPublished = true, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rapsolje", Url = "rapsolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Maisolje", Url = "maisolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Olivenolje", Url = "Olivenolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sesamolje", Url = "sesamolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kokosolje", Url = "kokosolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Frityrolje", Url = "frityrolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sukker", Url = "sukker", IsPublished = true, Type = FoodGroup.Sweeteners,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Blåbær", Url = "blabar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Jordbær", Url = "jordbar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Bringebær", Url = "bringebar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grønne epler", Url = "gronne-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Røde epler", Url = "rode-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Gule epler", Url = "gule-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Appelsin", Url = "appelsin", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sitron", Url = "sitron", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Økologisk sitron", Url = "okologisk-sitron", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Lime", Url = "lime", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hermetiske mandarinbåter", Url = "hermetiske-mandarinbater", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hermetiske pærer", Url = "hermetiske-parer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hermetiske fersken", Url = "hermetiske-fersken", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Banan", Url = "banan", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Klementin", Url = "klementin", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Blå druer", Url = "bla-druer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grønne druer", Url = "gronne-druer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rosiner", Url = "rosiner", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Korinter", Url = "korinter", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Fiskesaus", Url = "fiskesaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kokosmelk", Url = "kokosmelk", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kokosmelk, lett", Url = "kokosmelk-lett", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kokoskrem", Url = "kokoskrem", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kokosmasse", Url = "kokosmasse", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sitrongress", Url = "sitrongress", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rød currypasta", Url = "rod-currypasta", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grønn currypasta", Url = "gronn-currypasta", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Gul currypasta", Url = "gul-currypasta", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Galangal", Url = "galangal", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Gul løk", Url = "gul-lok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rødløk", Url = "rodlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Chalottløk", Url = "chalottlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvitløk", Url = "hvitlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Salatløk", Url = "salatlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Vårløk", Url = "varlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Purre", Url = "purre", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kyllingkraft", Url = "kyllingkraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Storfekraft", Url = "storfekraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Fiskekraft", Url = "fiskekraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Grønnsakskraft", Url = "gronnsakskraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Chili, serrano", Url = "chili-serrano", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Den vanlige, røde chilien du kjenner fra dagligvarebutikken din."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Chili, habanero", Url = "chili-habanero", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "En sterkere chili."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Chili, birds eye", Url = "chili-birds-eye", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Også kalt thai-chili. Sterkere enn serrano."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Champignon, fersk", Url = "champignon-fersk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Champignon, hermetisk", Url = "champignon-hermetisk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Aromasopp, fersk", Url = "aromasopp-fersk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Aromasopp, tørket", Url = "aromasopp-torket", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Margarin", Url = "margarin", IsPublished = true, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kylling, hel grillet", Url = "kylling-hel-grillet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kylling, hel fersk", Url = "kylling-hel-fersk", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kyllinglår, grillet", Url = "kyllinglar-grillet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kyllinglår, fersk", Url = "kyllinglar-fersk", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kyllinglår, frossen", Url = "kyllinglar-frossen", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kyllingvinger, grillet", Url = "kyllingvinger-grillet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kyllingvinger, fersk", Url = "kyllingvinger-fersk", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kyllingvinger, frossen", Url = "kyllingvinger-frossen", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kylling lårfilet", Url = "kylling-larfilet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kylling brystfilet", Url = "kylling-brystfilet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Koriander, fersk", Url = "koriander-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Dill, fersk", Url = "dill-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Gressløk, fersk", Url = "gresslok-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Basilikum, fersk", Url = "basilikum-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Thaibasilikum, fersk", Url = "thaibasilikum-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sort pepper, hel", Url = "sort-pepper-hel", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sort pepper, grovmalt", Url = "sort-pepper-grovmalt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Sort pepper, malt", Url = "sort-pepper-malt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvit pepper, hel", Url = "hvit-pepper-hel", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvit pepper, grovmalt", Url = "hvit-pepper-grovmalt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvit pepper, malt", Url = "hvit-pepper-malt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Karri", Url = "karri", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kanel, hel", Url = "kanel-hel", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kanel, malt", Url = "kanel-malt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Kardemomme", Url = "kardemomme", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Hvitløkspulver", Url = "hvitlokspulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Chilipulver", Url = "chilipulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Paprikapulver", Url = "paprikapulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Paprikapulver, røkt", Url = "paprikapulver-rokt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Rosmarin, tørket", Url = "rosmarin-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Dill, tørket", Url = "dill-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Oregano, tørket", Url = "oregano-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Basilikum, tørket", Url = "basilikum-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Spisskum", Url = "spisskum", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Latin: Cuminum cyminum. Engelsk: Cumin eller Roman caraway. Spisskum kan også kalles spisskummen eller spisskarve, og er ikke det samme som karve."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                Name = "Karve", Url = "karve", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Karve er ikke det samme som spisskum/spisskummen/spisskarve."
            },
        };

        private static int GetIngredientId(string url)
            => ingredients.Where(i => i.Url == url).Select(i => i.Id).FirstOrDefault();

        public static List<Recipe> recipes = [
            new Recipe(){ 
                Id = NextInt(true), CountryCode = "NO", Name = "Pannekaker", IsPublished = true, RatingAverage = 7.4,
                Url = "pannekaker", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1,0,0),
                Description = "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy eller sukker og sitrondråper."
            },
            new Recipe() { 
                Id = NextInt(false), CountryCode = "TH", Name = "Tom Kha Gai", IsPublished = true, RatingAverage = 8.1,
                Url = "tom-kha-gai", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 0, 0),
                Description = "En fantastisk smakfull kyllingsuppe."
            },
            new Recipe() { 
                Id = NextInt(false), CountryCode = "IT", Name = "Cacio e Pepe", IsPublished = true, RatingAverage = 8.0,
                Url = "cacio-e-pepe", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(0, 20, 0),
                Description = "En enkel men utrolig god, klassisk pastarett."
            },
            new Recipe(){ 
                Id = NextInt(false), CountryCode = "NO", Name = "Kjøttkaker med kålstuing", IsPublished = true, RatingAverage = 7.3,
                Url = "kjottkaker-med-kalstuing", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1, 0, 0),
                Description = "Den kjente og kjære norske klassikeren, akkurat som mamma lagde den."
            },
            new Recipe() { 
                Id = NextInt(false), CountryCode = "US", Name = "Buffalo kyllingnachos", IsPublished = true, RatingAverage = 7.5,
                Url = "buffalo-kyllingnachos", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(0, 30, 0),
                Description = "Disse buffalo kyllingnachoene er fulle av smak! Du vil elske kombinasjonen av sprø tortillachips, krydret buffalo-kylling og kjølig dressing av blåmuggost."
            },
            new Recipe() { 
                Id = NextInt(false), CountryCode = "NO", Name = "Ovnsbakt hel ørret", IsPublished = true, RatingAverage = 8.0,
                Url = "ovnsbakt-hel-orret", DateCreated = DateTime.Now, DateUpdated = DateTime.Now,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 30, 0),
                Description = "Saftig og smaksrik."
            },
        ];

        private static int GetRecipeId(string url)
            => recipes.Where(r => r.Url == url).Select(i => i.Id).FirstOrDefault();

        // Oppskriftsingredienser
        public static List<RecipeIngredient> recipeIngredients = new() { 
            // Pannekaker
            new RecipeIngredient() {
                RecipeId = GetRecipeId("pannekaker"), IngredientId = GetIngredientId("hvetemel"), Amount = 3,
                Unit = MeasurementUnit.Deciliter, SortOrder = 1 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("pannekaker"), IngredientId = GetIngredientId("lettmelk"), Amount = 5,
                Unit = MeasurementUnit.Deciliter, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("pannekaker"), IngredientId = GetIngredientId("egg"), Amount = 4,
                Unit = MeasurementUnit.Piece, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("pannekaker"), IngredientId = GetIngredientId("salt"), Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 4 },

            // Tom kha gai
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("kokoskrem"), Amount = 4,
                Unit = MeasurementUnit.Deciliter, SortOrder = 1 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("rod-currypasta"), Amount = 3,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("sitrongress"), Amount = 2,
                Unit = MeasurementUnit.Piece, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("fiskesaus"), Amount = 1,
                Unit = MeasurementUnit.Tablespoon, SortOrder = 4 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("gul-lok"), Amount = 0.5,
                Unit = MeasurementUnit.Piece, SortOrder = 5 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("hvitlok"), Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 6 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("galangal"), Amount = 50,
                Unit = MeasurementUnit.Gram, SortOrder = 7 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("kyllingkraft"), Amount = 4,
                Unit = MeasurementUnit.Deciliter, SortOrder = 8 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("chili-serrano"), Amount = 1,
                Unit = MeasurementUnit.Piece, SortOrder = 9 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("kylling-larfilet"), Amount = 400,
                Unit = MeasurementUnit.Gram, SortOrder = 10 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("champignon-fersk"), Amount = 3,
                Unit = MeasurementUnit.Piece, SortOrder = 11 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("lime"), Amount = 1,
                Unit = MeasurementUnit.Piece, SortOrder = 12 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("varlok"), Amount = 3,
                Unit = MeasurementUnit.Piece, SortOrder = 13 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("tom-kha-gai"), IngredientId = GetIngredientId("koriander-fersk"), Amount = 2,
                Unit = MeasurementUnit.Tablespoon, SortOrder = 14 },

            // Kjøttkaker

            // Cocio e Pepe

            // Kyllingnachos

            // Hel ørret
        };

        public static List<RecipeStep> recipeSteps = new() {
            // Pannekaker
            new RecipeStep() { Id = NextInt(true), RecipeId = GetRecipeId("pannekaker"), StepNumber = 1,
                StepText = "Bland mel og salt."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("pannekaker"), StepNumber = 2,
                StepText = "Ha i halvparten av melken og visp sammen til en tykk, klumpefri røre."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("pannekaker"), StepNumber = 3,
                StepText = "Tilsett resten av melken og visp sammen."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("pannekaker"), StepNumber = 4,
                StepText = "Tilsett eggene og visp sammen til røren blir fin og gul."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("pannekaker"), StepNumber = 5,
                StepText = "La røren hvile i minst 30 minutter for best resultat."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("pannekaker"), StepNumber = 6,
                StepText = "Ha smør eller margarin i pannen og stek pannekakene til de er gyldne på begge sider."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("pannekaker"), StepNumber = 7,
                StepText = "Brett pannekakene og legg dem i en ildfast form med lokk. Slik holder de seg varme til alle er ferdig stekt."
            },

            // Tom kha gai

            // Kjøttkaker

            // Cocio e Pepe

            // Kyllingnachos

            // Hel ørret

        };

        // Ingrediensers næringsstoffer
        public static List<IngredientNutrient> ingredientNutrients = [
            // Lettmelk
            // Total fettmengde: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("fett"), AmountPer100Grams = 1m },
            // Herav mettet fett: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("mettet-fett"), AmountPer100Grams = 0.6m },
            // Karbohydrater totalt: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("karbohydrater"), AmountPer100Grams = 4.5m },
            // Sukkerarter: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("sukkerarter"), AmountPer100Grams = 4.5m },
            // Protein: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("protein"), AmountPer100Grams = 3.5m },
            // Salt: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("salt"), AmountPer100Grams = 0.10m },

            // Riboflavin: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("vitamin-b2-riboflavin"), AmountPer100Grams = 0.00015m }, // 0,15 mg
            // Vitamin B12: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("vitamin-b12-kobalamin"), AmountPer100Grams = 0.0000006m }, // 0,6 µg
            // Biotin: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("vitamin-b7-biotin"), AmountPer100Grams = 0.000008m }, // 8 µg
            // Kalium: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("kalium"), AmountPer100Grams = 0.171m }, // 171 mg
            // Kalsium: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("kalsium"), AmountPer100Grams = 0.13m }, // 130 mg
            // Fosfor: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("fosfor"), AmountPer100Grams = 0.115m }, // 115 mg
            // Jod: 
            new IngredientNutrient() {
                IngredientId = GetIngredientId("lettmelk"), NutrientId = GetNutrientId("jod"), AmountPer100Grams = 0.000016m } // 16,0 µg
        ];

        // Ingrediensers allergener
        public static List<IngredientAllergen> ingredientAllergens = [
            // Lettmelk
            new IngredientAllergen() {
                IngredientId = GetIngredientId("lettmelk"), AllergenId = GetAllergenId("melk"), Amount = AllergenAmount.High },
            // Hvetemel
            new IngredientAllergen() {
                IngredientId = GetIngredientId("hvetemel"), AllergenId = GetAllergenId("gluten"), Amount = AllergenAmount.High },
            // Egg
            new IngredientAllergen() {
                IngredientId = GetIngredientId("egg"), AllergenId = GetAllergenId("egg"), Amount = AllergenAmount.High },
        ];
    }
}
