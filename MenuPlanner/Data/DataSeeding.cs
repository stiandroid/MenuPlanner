namespace MenuPlanner.Data
{
    public static class DataSeeding
    {
        private static DateTime _now = DateTime.Now;
        public static async Task SeedRolesAndInitialAdminUser(IServiceProvider services)
        { 
            var roleManager = services.GetRequiredService<RoleManager<Role>>();

            // Publiseringsprosessen
            //
            // For allergener, næringsstoffer, ingredienser og oppskrifter
            // følges denne prosedyren for publisering:
            //
            // 1: En "Editor" oppretter og melder innholdet klart for publisering.
            // 2: En "Publisher" godkjenner og publiserer innholdet.

            var roles = new List<Role> {
                // Administrators:
                new() { Group = RoleGroup.Administrators, Name = "SysAdmin", SortOrder = 1,
                    DisplayName = "Systemadministrator", 
                    Description = "Brukeren har alle rettigheter." },
                new() { Group = RoleGroup.Administrators, Name = "UserAdmin", SortOrder = 2,
                    DisplayName = "Brukeradministrator", 
                    Description = "Brukeren kan opprette nye brukere, endre brukeres personopplysninger, administrere brukeres roller, tildele advarsler for dårlig oppførsel, og utestenge brukere." },

                // Publishers:
                new() { Group = RoleGroup.Publishers, Name = "AllergenPublisher", SortOrder = 3,
                    DisplayName = "Innholdsansvarlig for allergener", 
                    Description = "Brukeren kan opprette, redigere og publisere allergener." },
                new() { Group = RoleGroup.Publishers, Name = "NutrientPublisher", SortOrder = 4,
                    DisplayName = "Innholdsansvarlig for næringsstoffer", 
                    Description = "Brukeren kan opprette, redigere og publisere næringsstoffer." },
                new() { Group = RoleGroup.Publishers, Name = "IngredientPublisher", SortOrder = 5,
                    DisplayName = "Innholdsansvarlig for ingredienser", 
                    Description = "Brukeren kan opprette, redigere og publisere ingredienser. Ingrediensmoderator kan ikke selv opprette ingredienser." },
                new() { Group = RoleGroup.Publishers, Name = "RecipePublisher", SortOrder = 6,
                    DisplayName = "Innholdsansvarlig for oppskrifter", 
                    Description = "Brukeren kan publisere oppskrifter skrevet av oppskriftsforfattere. Oppskriftsmoderator kan ikke selv skrive oppskrifter." },
                new() { Group = RoleGroup.Publishers, Name = "ArticlePublisher", SortOrder = 7,
                    DisplayName = "Innholdsansvarlig for fagartikler", 
                    Description = "Brukeren kan publisere artikler skrevet av artikkelforfattere. Artikkelmoderator kan ikke selv skrive artikler." },

                // Editors:
                new() { Group = RoleGroup.Editors, Name = "RecipeEditor", SortOrder = 8,
                    DisplayName = "Oppskriftsforfatter", 
                    Description = "Brukeren kan opprette og redigere egne upubliserte oppskrifter, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "IngredientEditor", SortOrder = 9,
                    DisplayName = "Ingrediensforfatter",
                    Description = "Brukeren kan opprette og redigere egne upubliserte ingredienser, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "NutrientEditor", SortOrder = 10,
                    DisplayName = "Næringsstofforfatter",
                    Description = "Brukeren kan opprette og redigere upubliserte næringsstoffer, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "AllergenEditor", SortOrder = 11,
                    DisplayName = "Allergenforfatter",
                    Description = "Brukeren kan opprette og redigere upubliserte allergener, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "ArticleEditor", SortOrder = 12,
                    DisplayName = "Artikkelforfatter", 
                    Description = "Brukeren kan opprette og redigere egne upubliserte artikler, men ikke publisere." },

                // Moderators:
                new() { Group = RoleGroup.Moderators, Name = "CommunityModerator", SortOrder = 13,
                    DisplayName = "Samfunnsmoderator", 
                    Description = "Brukeren kan endre og slette kommentarer, og gi advarsler til brukere." },
            };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role.Name!))
                {
                    await roleManager.CreateAsync(role);
                }
            }
            var adminId = "28f880e8-7d69-4e0c-91af-0f5b54b633d3";
            SeedUser(id: adminId, isProtected: true, firstName: "Systemadmin", lastName: "MenuPlanner", 
                email: "admin@menuplanner.app", password: "Abcd!234", phone: "00000000",
                roles: ["SysAdmin"], hasPhoto: false, hasBackdrop: false, canBeLockedOut: false, services);
        }

        public static async Task SeedTestUsers(IServiceProvider services)
        {
            // Må ha forhåndsdefinerte id-er, for de samme id-ene
            // brukes som filnavn på profilbilde og backdropbilde.
            var ynId = "c4fe3a8b-2a0e-46b1-9a3c-fc04f04c8a2d";
            var anId = "4370fb76-7b81-46f6-a95b-cd40be024f58";
            var ctId = "9b1f1d9a-4f38-40b3-8dfb-3f1a376a3e3e";
            var msId = "72ed1e85-17c7-42f9-9d1b-218f1689f7cf";
            var hrId = "9a441995-86e5-4da5-8fb3-7549187247ea";
            var jhId = "1e4f5d6e-ad16-47b0-a412-107b48663239";

            SeedUser(id: ynId, isProtected: false, firstName: "Yvonne", lastName: "Vo Nguyen",
                email: "yn@menuplanner.app", password: "Abcd!234", phone: "00000001",
                roles: ["UserAdmin", "ArticlePublisher"], hasPhoto: true, hasBackdrop: false, canBeLockedOut: true, services);

            SeedUser(id: anId, isProtected: false, firstName: "Abid", lastName: "Nazeem",
                email: "an@menuplanner.app", password: "Abcd!234", phone: "00000006", 
                roles: ["IngredientPublisher", "RecipePublisher", "UserAdmin"], hasPhoto: true, hasBackdrop: false, canBeLockedOut: true, services);

            SeedUser(id: ctId, isProtected: false, firstName: "Caroline", lastName: "Tvedt",
                email: "ct@menuplanner.app", password: "Abcd!234", phone: "00000002", 
                roles: ["RecipePublisher", "ArticleEditor"], hasPhoto: true, hasBackdrop: false, canBeLockedOut: true, services);

            SeedUser(id: msId, isProtected: false, firstName: "Martin", lastName: "Sylte",
                email: "ms@menuplanner.app", password: "Abcd!234", phone: "00000003", 
                roles: ["NutrientPublisher", "NutrientEditor", "ArticleEditor"], hasPhoto: true, hasBackdrop: false, canBeLockedOut: true, services);

            SeedUser(id: hrId, isProtected: false, firstName: "Hilde", lastName: "Reiersen",
                email: "hr@menuplanner.app", password: "Abcd!234", phone: "00000004",
                roles: ["AllergenEditor", "AllergenPublisher", "ArticleEditor"], hasPhoto: true, hasBackdrop: false, canBeLockedOut: true, services);

            SeedUser(id: jhId, isProtected: false, firstName: "Jørn", lastName: "Helljesen",
                email: "jh@menuplanner.app", password: "Abcd!234", phone: "00000005", 
                roles: ["CommunityModerator"], hasPhoto: true, hasBackdrop: true, canBeLockedOut: true, services);
        }

        private static void SeedUser(
            string id, 
            bool isProtected,
            string firstName, 
            string lastName, 
            string email, 
            string password, 
            string phone, 
            string[] roles, 
            bool hasPhoto,
            bool hasBackdrop,
            bool canBeLockedOut, 
            IServiceProvider services)
        { 
            var userManager = services.GetRequiredService<UserManager<User>>();
            var existingUser = userManager.FindByEmailAsync(email).Result;
            if (existingUser == null)
            {
                var user = new User
                {
                    Id = Guid.Parse(id).ToString(),
                    IsProtectedSystemUser = isProtected,
                    FirstName = firstName,
                    LastName = lastName,
                    HasProfileImage = hasPhoto,
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    UserName = email,
                    NormalizedUserName = email.ToUpper(),
                    EmailConfirmed = true,
                    PhoneNumber = phone,
                    LockoutEnabled = canBeLockedOut,
                    DateRegistered = _now
                };

                IdentityResult result = userManager.CreateAsync(user, password).Result;
                if (result.Succeeded)
                {
                    foreach (var role in roles)
                    {
                        userManager.AddToRoleAsync(user, role).Wait();
                    }
                }
            }
        }

        public static List<Country> Countries = [
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
        /// Bruk NextInt til å gi verdi til primærnøkler av type int.
        /// </summary>
        /// <param name="reset">Hvis True, ressettes tallrekken til 1. Hvis False øker verdien med 1.</param>
        /// <returns>Et heltall 1 høyere enn det forrige.</returns>
        private static int NextInt(bool reset)
        {
            if (reset) intValue = 0;
            return ++intValue;
        }

        public static List<Nutrient> Nutrients = new() { 
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
                Description = "Engelsk navn: Iodine."
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
            => Nutrients.Where(n => n.Url == url).Select(i => i.Id).FirstOrDefault();

        public static List<Allergen> Allergens = new() { 
            new Allergen() {
                Id = NextInt(true), Name = "Krepsdyr", Url = "krepsdyr", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "crustacean.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sesamfrø", Url = "sesamfro", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "sesame.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Nøtter", Url = "notter", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "nuts.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Gluten", Url = "gluten", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "gluten.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Egg", Url = "egg", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "egg.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Fisk", Url = "fisk", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "fish.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Skalldyr", Url = "skalldyr", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "shellfish.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sennep", Url = "sennep", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "mustard.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Selleri", Url = "selleri", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "celery.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Peanøtter", Url = "peanotter", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "peanuts.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Melk", Url = "melk", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "milk.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sulfitt", Url = "sulfitt", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "sulphite.png", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Soya", Url = "soya", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "", IsPublished = true
            },
            new Allergen() {
                Id = NextInt(false), Name = "Lupin", Url = "lupin", Description = "Informasjon",
                DateCreated = _now, DateUpdated = _now,
                Icon = "", Image = "", IsPublished = true
            }
        };

        private static int GetAllergenId(string url)
            => Allergens.Where(a => a.Url == url).Select(i => i.Id).FirstOrDefault();

        public static List<Ingredient> Ingredients = new(){
            new Ingredient(){
                Id = NextInt(true), DateCreated = _now, DateUpdated = _now,
                Name = "Vann", Url = "vann", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },

            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvetemel", Url = "hvetemel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Pizzamel, tipo-00", Url = "pizzamel-tipo-00", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Brødmel, tipo-0", Url = "brodmel-tipo-0", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now, IsPublished = true,
                Name = "Semulegryn", Alias = "Semolina", Url = "semulegryn", Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sammalt hvete, grovmalt", Url = "sammalt-hvete-grovmalt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sammalt hvete, finmalt", Url = "sammalt-hvete-finmalt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvete helkorn", Url = "hvete-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Havregryn, lettkokt", Url = "havregryn-lettkokt", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Havregryn, store", Url = "havregryn-store", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Havregryn, glutenfri", Url = "havregryn-glutenfri", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Havremel", Url = "havremel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rug, helkorn", Url = "rug-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rugmel", Url = "rugmel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Bygg, helkorn", Url = "bygg-helkorn", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Byggmel", Url = "byggmel", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Gresskarkjerner", Url = "gresskarkjerner", IsPublished = true, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Skummet melk", Url = "skummet-melk", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Lettmelk", Url = "lettmelk", IsPublished = true, Type = FoodGroup.Dairy,
                EnergyKcalPer100g = 41, Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Helmelk", Url = "helmelk", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kremfløte", Url = "kremflote", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Matfløte", Url = "matflote", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Lettrømme", Url = "lettromme", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Seterrømme", Url = "seterromme", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rømmekolle", Url = "rommekolle", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kvarg", Url = "kvarg", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,IsPublished = true,
                Name = "Gulost", Alias = "Hvitost", Url = "gulost", Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Edamer", Url = "edamer", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Gouda", Url = "gouda", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Brie", Url = "brie", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kremost", Url = "kremost", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Cottage cheese", Url = "cottage-cheese", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Ricotta", Url = "ricotta", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Halloumi", Alias = "Grillost", Url = "halloumi", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Mozzarella", Url = "mozzarella", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Cheddar", Url = "cheddar", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Geitost", Url = "geitost", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Fløtemysost", Url = "flotemysost", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Egg", Url = "egg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra høne. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Eggeplomme", Url = "eggeplomme", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Eggeplomme fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggeplommer i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Eggehvite", Url = "eggehvite", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Eggehvite fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggehviter i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Vaktelegg", Url = "vaktelegg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra vaktel."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Måsegg", Url = "masegg", IsPublished = true, Type = FoodGroup.Eggs,
                Description = "Egg fra måke (måse)."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Tortillachips", Url = "tortillachips", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Nachochips", Url = "nachochips", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Salt", Url = "salt", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Tomatketsjup", Url = "tomatketsjup", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Søt sennep", Url = "sot-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sterk sennep", Url = "sterk-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Dijonsennep", Url = "dijonsennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Grov sennep", Url = "grov-sennep", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Soyasaus", Url = "soyasaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Saltredusert soyasaus", Url = "saltredusert-soyasaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Eddikessens", Url = "eddikessens", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "35%"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Klar eddik", Url = "klar-eddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Brun eddik", Url = "brun-eddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Eplecidereddik", Url = "eplecidereddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvitvinseddik", Url = "hvitvinseddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rødvinseddik", Url = "rodvinseddik", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sitrondråper", Url = "sitrondråper", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Smør", Url = "smor", IsPublished = true, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Margarin", Url = "margarin", IsPublished = true, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rapsolje", Url = "rapsolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Maisolje", Url = "maisolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Olivenolje", Url = "Olivenolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sesamolje", Url = "sesamolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kokosolje", Url = "kokosolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Frityrolje", Url = "frityrolje", IsPublished = true, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sukker", Url = "sukker", IsPublished = true, Type = FoodGroup.Sweeteners,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Blåbær", Url = "blabar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Jordbær", Url = "jordbar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Bringebær", Url = "bringebar", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Grønne epler", Url = "gronne-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Røde epler", Url = "rode-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Gule epler", Url = "gule-epler", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Appelsin", Url = "appelsin", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sitron", Url = "sitron", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Økologisk sitron", Url = "okologisk-sitron", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Lime", Url = "lime", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hermetiske mandarinbåter", Url = "hermetiske-mandarinbater", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hermetiske pærer", Url = "hermetiske-parer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hermetiske fersken", Url = "hermetiske-fersken", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Banan", Url = "banan", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Klementin", Url = "klementin", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Blå druer", Url = "bla-druer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Grønne druer", Url = "gronne-druer", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rosiner", Url = "rosiner", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Korinter", Url = "korinter", IsPublished = true, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Fiskesaus", Url = "fiskesaus", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kokosmelk", Url = "kokosmelk", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kokosmelk, lett", Url = "kokosmelk-lett", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kokoskrem", Url = "kokoskrem", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kokosmasse", Url = "kokosmasse", IsPublished = true, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sitrongress", Url = "sitrongress", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rød currypasta", Url = "rod-currypasta", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Grønn currypasta", Url = "gronn-currypasta", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Gul currypasta", Url = "gul-currypasta", IsPublished = true, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Galangal", Url = "galangal", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rød paprika", Url = "rod-paprika", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Gul paprika", Url = "gul-paprika", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Grønn paprika", Url = "gronn-paprika", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Isbergsalat", Url = "isbergsalat", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hjertesalat", Url = "hjertesalat", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Lollosalat", Url = "lollosalat", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Maiskolbe, fersk", Url = "maiskolbe-fersk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hermetisk maiskolbe", Url = "hermetisk-maiskolbe", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hermetiske maiskorn", Url = "hermetiske-maiskorn", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Plommetomat", Url = "plommetomat", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kirsebærtomat", Url = "kirsebartomat", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Tomat", Url = "tomat", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Slangeagurk", Url = "slangeagurk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Gul løk", Url = "gul-lok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rødløk", Url = "rodlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Chalottløk", Url = "chalottlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvitløk", Url = "hvitlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Salatløk", Url = "salatlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Vårløk", Url = "varlok", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Purre", Url = "purre", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllingkraft", Alias = "Kyllingbuljong", Url = "kyllingkraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Storfekraft", Alias = "Storfebuljong", Url = "storfekraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Fiskekraft", Alias = "Fiskebuljong", Url = "fiskekraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Grønnsakskraft", Alias = "Grønnsaksbuljong", Url = "gronnsakskraft", IsPublished = true, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Chili, serrano", Alias = "Rød chili", Url = "chili-serrano", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Den vanlige, røde chilien du kjenner fra dagligvarebutikken."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Chili, habanero", Url = "chili-habanero", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "En sterkere chili."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Chili, birds eye", Url = "chili-birds-eye", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Også kalt thai-chili. Sterkere enn serrano."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Champignon, fersk", Url = "champignon-fersk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Champignon, hermetisk", Url = "champignon-hermetisk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Aromasopp, fersk", Url = "aromasopp-fersk", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Aromasopp, tørket", Url = "aromasopp-torket", IsPublished = true, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Margarin", Url = "margarin", IsPublished = true, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kylling, hel grillet", Url = "kylling-hel-grillet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kylling, hel fersk", Url = "kylling-hel-fersk", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllinglår, grillet", Url = "kyllinglar-grillet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllinglår, fersk", Url = "kyllinglar-fersk", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllinglår, frossen", Url = "kyllinglar-frossen", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllingvinger, grillet", Url = "kyllingvinger-grillet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllingvinger, fersk", Url = "kyllingvinger-fersk", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllingvinger, frossen", Url = "kyllingvinger-frossen", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kylling lårfilet", Url = "kylling-larfilet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kylling brystfilet", Url = "kylling-brystfilet", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kyllingkjøttdeig", Url = "kyllingkjottdeig", IsPublished = true, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kjøttdeig", Url = "kjottdeig", IsPublished = true, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Karbonadedeig", Url = "karbonadedeig", IsPublished = true, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Medisterdeig", Url = "medisterdeig", IsPublished = true, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Medisterfarse", Url = "medisterfarse", IsPublished = true, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Koriander, fersk", Url = "koriander-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Dill, fersk", Url = "dill-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Gressløk, fersk", Url = "gresslok-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Basilikum, fersk", Url = "basilikum-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Thaibasilikum, fersk", Url = "thaibasilikum-fersk", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sort pepper, hel", Url = "sort-pepper-hel", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sort pepper, grovmalt", Url = "sort-pepper-grovmalt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Sort pepper, malt", Url = "sort-pepper-malt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvit pepper, hel", Url = "hvit-pepper-hel", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvit pepper, grovmalt", Url = "hvit-pepper-grovmalt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvit pepper, malt", Url = "hvit-pepper-malt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Karri", Url = "karri", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvitløkspulver", Url = "hvitlokspulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Løkpulver", Url = "lokpulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kanel, hel", Url = "kanel-hel", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kanel, malt", Url = "kanel-malt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Kardemomme", Url = "kardemomme", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Hvitløkspulver", Url = "hvitlokspulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Chilipulver", Url = "chilipulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Chiliflak", Url = "chiliflak", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Paprikapulver", Url = "paprikapulver", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Paprikapulver, røkt", Url = "paprikapulver-rokt", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Rosmarin, tørket", Url = "rosmarin-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Dill, tørket", Url = "dill-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Oregano, tørket", Url = "oregano-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Basilikum, tørket", Url = "basilikum-torket", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Spisskum", Alias = "Spisskummen, spisskarve, cumin, Roman caraway", Url = "spisskum", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Latin: Cuminum cyminum. Engelsk: Cumin eller Roman caraway. Spisskum kan også kalles spisskummen eller spisskarve, og er ikke det samme som karve."
            },
            new Ingredient(){
                Id = NextInt(false), DateCreated = _now, DateUpdated = _now,
                Name = "Karve", Alias = "Caraway", Url = "karve", IsPublished = true, Type = FoodGroup.HerbsAndSpices,
                Description = "Latin: Carum carvi. Engelsk: Caraway. Karve er ikke det samme som spisskum/spisskummen/spisskarve/Roman caraway."
            },
        };

        private static int GetIngredientId(string url)
            => Ingredients.Where(i => i.Url == url).Select(i => i.Id).FirstOrDefault();

        // Tanken her er at hovedoppskrifter har samme ParentRecipeId som Id.
        // Derfor må vi definere Id-ene før vi instansierer listen. I listen med ChildRecipes
        // som følger rett etter ParentRecipes, fortsettes tallrekken ved NextInt(false),
        // slik at det blir en ubrutt tallrekke i databasen.
        static int id_pannek = NextInt(true);
        static int id_tomkha = NextInt(false);
        static int id_cacio = NextInt(false);
        static int id_kjottk = NextInt(false);
        static int id_taco = NextInt(false);
        static int id_ovnorr = NextInt(false);
        public static List<Recipe> ParentRecipes = [
            new Recipe(){ 
                Id = id_pannek, ParentRecipeId = id_pannek, CountryCode = "NO", Name = "Pannekaker",
                IsPublished = true, RatingAverage = 7.4, Url = "pannekaker", DateCreated = _now, DateUpdated = _now,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1,0,0),
                Description = "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy eller sukker og sitrondråper."
            },
            new Recipe() { 
                Id = id_tomkha, ParentRecipeId = id_tomkha, CountryCode = "TH", Name = "Tom Kha Gai",
                IsPublished = true, RatingAverage = 8.1, Url = "tom-kha-gai", DateCreated = _now, DateUpdated = _now,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 0, 0),
                Description = "En fantastisk smakfull kyllingsuppe."
            },
            new Recipe() { 
                Id = id_cacio, ParentRecipeId = id_cacio, CountryCode = "IT", Name = "Cacio e Pepe",
                IsPublished = true, RatingAverage = 8.0, Url = "cacio-e-pepe", DateCreated = _now, DateUpdated = _now,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(0, 20, 0),
                Description = "En enkel men utrolig god, klassisk pastarett."
            },
            new Recipe(){ 
                Id = id_kjottk, ParentRecipeId = id_kjottk, CountryCode = "NO", Name = "Kjøttkaker med kålstuing",
                IsPublished = true, RatingAverage = 7.3, Url = "kjottkaker-med-kalstuing", DateCreated = _now, DateUpdated = _now,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1, 0, 0),
                Description = "Den kjente og kjære norske klassikeren, akkurat som mamma lagde den."
            },
            new Recipe() { 
                Id = id_taco, ParentRecipeId = id_taco, CountryCode = "MX", Name = "Taco",
                IsPublished = true, RatingAverage = 9.5, Url = "taco", DateCreated = _now, DateUpdated = _now,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 30, 0),
                Description = "Taco fra grunnen av! Hjemmelagde hvetetortillas, tacokrydder, guacamole og salsa. Denne oppskriften legger grunnlaget for en god helg!"
            },
            new Recipe() { 
                Id = id_ovnorr, ParentRecipeId = id_ovnorr, CountryCode = "NO", Name = "Ovnsbakt hel ørret",
                IsPublished = true, Url = "ovnsbakt-hel-orret", DateCreated = _now, DateUpdated = _now,
                RatingAverage = 8.0, DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 30, 0),
                Description = "Saftig og smaksrik."
            },
        ];

        public static List<Recipe> ChildRecipes = [
            new Recipe() {
                Id = NextInt(false), 
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Tacokrydder",
                Url = "tacokrydder", 
                CountryCode = "MX", 
                RatingAverage = 8.7, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Smakfullt tex-mex-krydder.",
                ChildRecipeSortOrder = 1,
                IsPublished = true, 
                DateCreated = _now, 
                DateUpdated = _now,
            },
            new Recipe() {
                Id = NextInt(false), 
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Hvetetortillas",
                Url = "hvetetortillas", 
                CountryCode = "MX", 
                RatingAverage = 8.9, 
                DifficultyLevel = DifficultyLevel.Intermediate, 
                PrepTime = new TimeSpan(0, 30, 0),
                Description = "Myke og deilige hvetetortillas! Perfekte til fredagstaco, laksewrap eller kyllingburrito!",
                ChildRecipeSortOrder = 2,
                IsPublished = true, 
                DateCreated = _now, 
                DateUpdated = _now
            },
            new Recipe() {
                Id = NextInt(false), 
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Guacamole",
                Url = "guacamole", 
                CountryCode = "MX", 
                RatingAverage = 9.7, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Frisk og smakfull guacamole som er perfekt tilbehør til fredagstacoen!",
                ChildRecipeSortOrder = 3,
                IsPublished = true, 
                DateCreated = _now, 
                DateUpdated = _now
            },
            new Recipe() {
                Id = NextInt(false), 
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Tomatsalsa",
                Url = "tomat-salsa", 
                CountryCode = "MX", 
                RatingAverage = 9.6, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Nydelig tomatsalsa som er perfekt tilbehør til fredagstacoen! Ha i chili etter smak, eller dropp chili for en mild salsa.",
                ChildRecipeSortOrder = 4,
                IsPublished = true,
                DateCreated = _now, 
                DateUpdated = _now
            },
        ];

        private static int GetRecipeId(string generation, string url) => generation switch { 
            "parent" => ParentRecipes.Where(r => r.Url == url).Select(i => i.Id).FirstOrDefault(),
            "child" => ChildRecipes.Where(r => r.Url == url).Select(i => i.Id).FirstOrDefault(),
            _ => throw new ArgumentException("Argument 1: 'generation' must be either 'parent' or 'child'")};

        // Oppskriftsingredienser
        public static List<RecipeIngredient> RecipeIngredients = new() { 
            // Pannekaker
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "pannekaker"), IngredientId = GetIngredientId("hvetemel"), Amount = 3,
                Unit = MeasurementUnit.Deciliter, SortOrder = 1 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "pannekaker"), IngredientId = GetIngredientId("lettmelk"), Amount = 5,
                Unit = MeasurementUnit.Deciliter, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "pannekaker"), IngredientId = GetIngredientId("egg"), Amount = 4,
                Unit = MeasurementUnit.Piece, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "pannekaker"), IngredientId = GetIngredientId("salt"), Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 4 },

            // Tom kha gai
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("kokoskrem"), Amount = 4,
                Unit = MeasurementUnit.Deciliter, SortOrder = 1 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("rod-currypasta"), Amount = 3,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("sitrongress"), Amount = 2,
                Unit = MeasurementUnit.Piece, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("fiskesaus"), Amount = 1,
                Unit = MeasurementUnit.Tablespoon, SortOrder = 4 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("gul-lok"), Amount = 0.5,
                Unit = MeasurementUnit.Piece, SortOrder = 5 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("hvitlok"), Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 6 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("galangal"), Amount = 50,
                Unit = MeasurementUnit.Gram, SortOrder = 7 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("kyllingkraft"), Amount = 4,
                Unit = MeasurementUnit.Deciliter, SortOrder = 8 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("chili-serrano"), Amount = 1,
                Unit = MeasurementUnit.Piece, SortOrder = 9 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("kylling-larfilet"), Amount = 400,
                Unit = MeasurementUnit.Gram, SortOrder = 10 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("champignon-fersk"), Amount = 3,
                Unit = MeasurementUnit.Piece, SortOrder = 11 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("lime"), Amount = 1,
                Unit = MeasurementUnit.Piece, SortOrder = 12 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("varlok"), Amount = 3,
                Unit = MeasurementUnit.Piece, SortOrder = 13 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "tom-kha-gai"), IngredientId = GetIngredientId("koriander-fersk"), Amount = 2,
                Unit = MeasurementUnit.Tablespoon, SortOrder = 14 },

            // Kjøttkaker

            // Cocio e Pepe

            // Taco - hovedoppskriften
            new RecipeIngredient() { 
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("karbonadedeig"), Amount = 400,
                Unit = MeasurementUnit.Gram, SortOrder = 1 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("rod-paprika"), Amount = 0.5,
                Unit = MeasurementUnit.Piece, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("gul-paprika"), Amount = 0.5,
                Unit = MeasurementUnit.Piece, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("gronn-paprika"), Amount = 0.5,
                Unit = MeasurementUnit.Piece, SortOrder = 4 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("slangeagurk"), Amount = 0.5,
                Unit = MeasurementUnit.Piece, SortOrder = 5 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("plommetomat"), Amount = 3,
                Unit = MeasurementUnit.Piece, SortOrder = 6 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("hermetiske-maiskorn"), Amount = 200,
                Unit = MeasurementUnit.Gram, SortOrder = 7 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("isbergsalat"), Amount = 0.5,
                Unit = MeasurementUnit.Piece, SortOrder = 8 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("gulost"), Amount = 200,
                Unit = MeasurementUnit.Gram, SortOrder = 9 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("parent", "taco"), IngredientId = GetIngredientId("tortillachips"), Amount = 150,
                Unit = MeasurementUnit.Gram, SortOrder = 10 },
            // Tacokrydder - underoppskrift til Taco
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("chilipulver"), Amount = 2,
                Unit = MeasurementUnit.Tablespoon, SortOrder = 1 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("hvitlokspulver"), Amount = 0.5,
                Unit = MeasurementUnit.Tablespoon, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("lokpulver"), Amount = 0.5,
                Unit = MeasurementUnit.Tablespoon, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("salt"), Amount = 1,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 4 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("chiliflak"), Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 5 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("paprikapulver-rokt"), Amount = 1,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 6 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("spisskum"), Amount = 2,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 7 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("oregano-torket"), Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 8 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "tacokrydder"), IngredientId = GetIngredientId("sort-pepper-malt"), Amount = 2,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 9 },

            // Hvetetortillas - underoppskrift til Taco
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "hvetetortillas"), IngredientId = GetIngredientId("hvetemel"), Amount = 225,
                Unit = MeasurementUnit.Gram, SortOrder = 1 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "hvetetortillas"), IngredientId = GetIngredientId("salt"), Amount = 0.5,
                Unit = MeasurementUnit.Teaspoon, SortOrder = 2 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "hvetetortillas"), IngredientId = GetIngredientId("smor"), Amount = 60,
                Unit = MeasurementUnit.Gram, SortOrder = 3 },
            new RecipeIngredient() {
                RecipeId = GetRecipeId("child", "hvetetortillas"), IngredientId = GetIngredientId("vann"), Amount = 1,
                Unit = MeasurementUnit.Deciliter, SortOrder = 4 },
            // Guacamole - underoppskrift til Taco
            
            // Tomatsalsa - underoppskrift til Taco


            // Hel ørret
        };

        public static List<RecipeStep> RecipeSteps = new() {
            // Pannekaker
            new RecipeStep() { Id = NextInt(true), RecipeId = GetRecipeId("parent", "pannekaker"), SortOrder = 1,
                Title = "Bland de tørre ingrediensene", Text = "Bland mel og salt."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("parent", "pannekaker"), SortOrder = 2,
                Title = "Rør ut melken, steg 1/2", Text = "Ha i halvparten av melken og visp sammen til en tykk, klumpefri røre."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("parent", "pannekaker"), SortOrder = 3,
                Title = "Rør ut melken, steg 2/2", Text = "Tilsett resten av melken og visp sammen."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("parent", "pannekaker"), SortOrder = 4,
                Title = "Tilsett egg", Text = "Tilsett eggene og visp sammen til røren blir fin og gul."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("parent", "pannekaker"), SortOrder = 5,
                Title = "Hviletid", Text = "La røren hvile i minst 30 minutter for best resultat."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("parent", "pannekaker"), SortOrder = 6,
                Title = "Stek pannekakene", Text = "Ha smør eller margarin i pannen og stek pannekakene til de er gyldne på begge sider."
            },
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("parent", "pannekaker"), SortOrder = 7,
                Title = "Hold pannekakene varme til servering", Text = "Brett pannekakene og legg dem i en ildfast form med lokk. Slik holder de seg varme til alle er ferdig stekt."
            },

            // Tom kha gai

            // Kjøttkaker

            // Cocio e Pepe

            // Taco
            // Tacokrydder
            new RecipeStep() { Id = NextInt(false), RecipeId = GetRecipeId("child", "tacokrydder"), SortOrder = 1,
                Title = "Bland alt sammen", Text = "Bland alle ingrediensene i en morter og støt dem sammen til alt er godt blandet."
            },

            // Hel ørret

        };

        public static List<RecipeNote> RecipeNotes = new() { 
            new RecipeNote() { Id = NextInt(true), RecipeId = GetRecipeId("child", "tacokrydder"), SortOrder = 1, 
                Title = "Oppbevaring av rester", Text = "Hvis du ikke bruker opp all kryddermiksen, kan resten oppbevares i en lufttett beholder i opp til seks måneder uten å miste smak og aroma. Etter dette er det ikke farlig å bruke det, men smaken kan tape seg noe." },
        };

        // Ingrediensers næringsstoffer
        public static List<IngredientNutrient> IngredientNutrients = [
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
        public static List<IngredientAllergen> IngredientAllergens = [
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
