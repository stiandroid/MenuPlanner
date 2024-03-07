namespace MenuPlanner.Data
{
    public static class DataSeeding
    {
        private static DateTime _create = new(2024, 3, 6, 10, 30, 0, 0, DateTimeKind.Utc);
        private static DateTime _edit   = new(2024, 3, 7,  0,  9, 0, 0, DateTimeKind.Utc);
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
            // 3: Eventuelle endringer etter publisering gjøres på en kopi (State=LifecycleState.Draft).
            //    Når endringene er godkjent for publisering, så settes kopien som publisert
            //    (IsPublished=true og State=LifecycleState.Current), og den opprinnelige versjonen
            //    arkiveres (IsPublished=false og State=LifecycleState.Archived).

            var roles = new List<Role> {
                // Administrators:
                new() { Group = RoleGroup.Administrators, Name = "SysAdmin", SortOrder = 1,
                    DisplayName = "Systemadministrator", 
                    Description = "Brukeren har alle rettigheter." },
                new() { Group = RoleGroup.Administrators, Name = "UserAdmin", SortOrder = 2,
                    DisplayName = "Brukeradministrator", 
                    Description = "Brukeren kan opprette nye brukere, endre brukeres personopplysninger, administrere brukeres roller, tildele advarsler for dårlig oppførsel, og utestenge brukere." },

                // Publishers:
                new() { Group = RoleGroup.Publishers, Name = "RecipePublisher", SortOrder = 3,
                    DisplayName = "Publisering, oppskrifter", 
                    Description = "Brukeren kan publisere, men ikke opprette eller redigere oppskrifter." },
                new() { Group = RoleGroup.Publishers, Name = "IngredientPublisher", SortOrder = 4,
                    DisplayName = "Publisering, ingredienser", 
                    Description = "Brukeren kan publisere, men ikke opprette eller redigere ingredienser." },
                new() { Group = RoleGroup.Publishers, Name = "NutrientPublisher", SortOrder = 5,
                    DisplayName = "Publisering, næringsstoffer", 
                    Description = "Brukeren kan publisere, men ikke opprette eller redigere næringsstoffer." },
                new() { Group = RoleGroup.Publishers, Name = "AllergenPublisher", SortOrder = 6,
                    DisplayName = "Publisering, allergener", 
                    Description = "Brukeren kan publisere, men ikke opprette eller redigere allergener." },
                new() { Group = RoleGroup.Publishers, Name = "ArticlePublisher", SortOrder = 7,
                    DisplayName = "Publisering, artikler", 
                    Description = "Brukeren kan publisere, men ikke opprette eller redigere artikler." },

                // Editors:
                new() { Group = RoleGroup.Editors, Name = "RecipeEditor", SortOrder = 8,
                    DisplayName = "Innholdsskaper, oppskrifter", 
                    Description = "Brukeren kan opprette og redigere egne, upubliserte oppskrifter, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "IngredientEditor", SortOrder = 9,
                    DisplayName = "Innholdsskaper, ingredienser",
                    Description = "Brukeren kan opprette og redigere egne, upubliserte ingredienser, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "NutrientEditor", SortOrder = 10,
                    DisplayName = "Innholdsskaper, næringsstoffer",
                    Description = "Brukeren kan opprette og redigere egne, upubliserte næringsstoffer, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "AllergenEditor", SortOrder = 11,
                    DisplayName = "Innholdsskaper, allergener",
                    Description = "Brukeren kan opprette og redigere egne, upubliserte allergener, men ikke publisere." },
                new() { Group = RoleGroup.Editors, Name = "ArticleEditor", SortOrder = 12,
                    DisplayName = "Innholdsskaper, artikler", 
                    Description = "Brukeren kan opprette og redigere egne, upubliserte artikler, men ikke publisere." },

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
                    DateRegistered = _create
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
                State = LifecycleState.Current, Created = _create, Description = "Informasjon."
            },

            // Karbohydrater
            new Nutrient() {
                Id = NextInt(false), Name = "Karbohydrater", Url = "karbohydrater", Type = NutrientType.Carbohydrates,
                State = LifecycleState.Current, Created = _create,
                Description = "Total mengde karbohydrater, inkludert sukkerarter, polyoler og stivelse."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Sukkerarter", Url = "sukkerarter",
                Type = NutrientType.Sugars, SubTypeOf = NutrientType.Carbohydrates, Created = _create,
                State = LifecycleState.Current, Description = "Informasjon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Polyoler", Url = "polyoler",
                Type = NutrientType.Polyols, SubTypeOf = NutrientType.Carbohydrates, Created = _create,
                State = LifecycleState.Current, Description = "Informasjon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Stivelse", Url = "stivelse",
                Type = NutrientType.Starch, SubTypeOf = NutrientType.Carbohydrates, Created = _create,
                State = LifecycleState.Current, Description = "Informasjon."
            },

            // Fett
            new Nutrient() {
                Id = NextInt(false), Name = "Fett", Url = "fett",
                Type = NutrientType.Fats, State = LifecycleState.Current, Created = _create,
                Description = "Angir total mengde fett i en ingrediens, inkludert mettet, enumettet og flerumettet fett.", SortOrder = 1
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Mettet fett", Url = "mettet-fett",
                Type = NutrientType.SaturatedFats, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 1
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Enumettet fett", Url = "enumettet-fett",
                Type = NutrientType.MonoUnsaturatedFats, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 2
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Flerumettet fett", Url = "flerumettet-fett",
                Type = NutrientType.PolyUnsaturatedFats, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 3
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Transfett", Url = "transfett",
                Type = NutrientType.TransFat, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 4
            },

            // Vitaminer
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin A, retinol", Url = "vitamin-a-retinol",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B1, tiamin", Url = "vitamin-b1-tiamin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B2, riboflavin", Url = "vitamin-b2-riboflavin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B3, niacin", Url = "vitamin-b3-niacin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B5, pantotensyre", Url = "vitamin-b5-pantotensyre",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B7, biotin", Url = "vitamin-b7-biotin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B9, folat", Url = "vitamin-b9-folat",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B12, kobalamin", Url = "vitamin-b12-kobalamin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin C, askorbinsyre", Url = "vitamin-c-askorbinsyre",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin D2, ergokalsiferol", Url = "vitamin-d2-ergokalsiferol",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin D3, kolikalsiferol", Url = "vitamin-d3-kolikalsiferol",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin E, tokoferol (E306)", Url = "vitamin-e-tokoferol-e306",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Tokoferol (E306) betegner en blanding av de rene stoffene alfa-tokoferol (E307), gamma-tokoferol (E308) og delta-tokoferol (E309)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin K1, fyllokinon", Url = "vitamin-k1-fyllokinon",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin K2, menakinon", Url = "vitamin-k2-menakinon",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },

            // Mineraler
            new Nutrient() {
                Id = NextInt(false), Name = "Kalium", Url = "kalium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Potassium"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Klorin", Url = "klorin", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Chlorine. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Natrium", Url = "natrium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Sodium. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Kalsium", Url = "kalsium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Calcium. Viktig for skjelettet og tennene."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Fosfor", Url = "fosfor", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Phosphorus."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Magnesium", Url = "magnesium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Magnesium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Jern", Url = "jern", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Iron."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Sink", Url = "sink", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Zinc."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Mangan", Url = "mangan", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Manganese."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Kobber", Url = "kobber", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Copper."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Jod", Url = "jod", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Iodine."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Molybden", Url = "molybden", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Molybdenum."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Selen", Url = "selen", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Selenium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Fluor", Url = "fluor", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Fluoride."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Krom", Url = "krom", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Chromium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Nikkel", Url = "nikkel", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Nickel."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Bor", Url = "bor", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Boron."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Silisium", Url = "silisium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Silicon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vanadium", Url = "vanadium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Vanadium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Salt", Url = "salt", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Natriumklorid (NaCl). Engelsk navn: Salt, sodium chloride."
            }
        };

        private static int GetNutrientId(string url)
            => Nutrients.Where(n => n.Url == url).Select(i => i.Id).FirstOrDefault();

        public static List<Allergen> Allergens = new() { 
            new Allergen() {
                Id = NextInt(true), Name = "Krepsdyr", Url = "krepsdyr", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "crustacean.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sesamfrø", Url = "sesamfro", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "sesame.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Nøtter", Url = "notter", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "nuts.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Gluten", Url = "gluten", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "gluten.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Egg", Url = "egg", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "egg.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Fisk", Url = "fisk", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "fish.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Skalldyr", Url = "skalldyr", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "shellfish.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sennep", Url = "sennep", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "mustard.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Selleri", Url = "selleri", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "celery.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Peanøtter", Url = "peanotter", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "peanuts.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Melk", Url = "melk", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "milk.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sulfitt", Url = "sulfitt", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "sulphite.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Soya", Url = "soya", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Lupin", Url = "lupin", Description = "Informasjon",
                Created = _create,
                Icon = "", Image = "", State = LifecycleState.Current
            }
        };

        private static int GetAllergenId(string url)
            => Allergens.Where(a => a.Url == url).Select(i => i.Id).FirstOrDefault();

        public static List<Ingredient> Ingredients = new(){
            new Ingredient(){
                Id = NextInt(true), Created = _create,
                Name = "Vann", Url = "vann", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },

            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvetemel", Url = "hvetemel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Pizzamel, tipo-00", Url = "pizzamel-tipo-00", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Brødmel, tipo-0", Url = "brodmel-tipo-0", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create, State = LifecycleState.Current,
                Name = "Semulegryn", Alias = "Semolina", Url = "semulegryn", Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sammalt hvete, grovmalt", Url = "sammalt-hvete-grovmalt", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sammalt hvete, finmalt", Url = "sammalt-hvete-finmalt", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvete helkorn", Url = "hvete-helkorn", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havregryn, lettkokt", Url = "havregryn-lettkokt", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havregryn, store", Url = "havregryn-store", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havregryn, glutenfri", Url = "havregryn-glutenfri", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havremel", Url = "havremel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rug, helkorn", Url = "rug-helkorn", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rugmel", Url = "rugmel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Bygg, helkorn", Url = "bygg-helkorn", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Byggmel", Url = "byggmel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gresskarkjerner", Url = "gresskarkjerner", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Skummet melk", Url = "skummet-melk", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lettmelk", Url = "lettmelk", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                EnergyKcalPer100g = 41, Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Helmelk", Url = "helmelk", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kremfløte", Url = "kremflote", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Matfløte", Url = "matflote", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lettrømme", Url = "lettromme", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Seterrømme", Url = "seterromme", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rømmekolle", Url = "rommekolle", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kvarg", Url = "kvarg", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,State = LifecycleState.Current,
                Name = "Gulost", Alias = "Hvitost", Url = "gulost", Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Edamer", Url = "edamer", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gouda", Url = "gouda", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Brie", Url = "brie", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kremost", Url = "kremost", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Cottage cheese", Url = "cottage-cheese", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Ricotta", Url = "ricotta", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Halloumi", Alias = "Grillost", Url = "halloumi", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Mozzarella", Url = "mozzarella", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Cheddar", Url = "cheddar", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Geitost", Url = "geitost", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Fløtemysost", Url = "flotemysost", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Egg", Url = "egg", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Egg fra høne. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eggeplomme", Url = "eggeplomme", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Eggeplomme fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggeplommer i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eggehvite", Url = "eggehvite", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Eggehvite fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggehviter i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Vaktelegg", Url = "vaktelegg", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Egg fra vaktel."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Måsegg", Url = "masegg", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Egg fra måke (måse)."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Tortillachips", Url = "tortillachips", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Nachochips", Url = "nachochips", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Salt", Url = "salt", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Tomatketsjup", Url = "tomatketsjup", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Søt sennep", Url = "sot-sennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sterk sennep", Url = "sterk-sennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Dijonsennep", Url = "dijonsennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grov sennep", Url = "grov-sennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Soyasaus", Url = "soyasaus", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Saltredusert soyasaus", Url = "saltredusert-soyasaus", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eddikessens", Url = "eddikessens", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "35%"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Klar eddik", Url = "klar-eddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Brun eddik", Url = "brun-eddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eplecidereddik", Url = "eplecidereddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitvinseddik", Url = "hvitvinseddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rødvinseddik", Url = "rodvinseddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sitrondråper", Url = "sitrondråper", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Smør", Url = "smor", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Margarin", Url = "margarin", State = LifecycleState.Current, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rapsolje", Url = "rapsolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Maisolje", Url = "maisolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Olivenolje", Url = "Olivenolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sesamolje", Url = "sesamolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosolje", Url = "kokosolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Frityrolje", Url = "frityrolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sukker", Url = "sukker", State = LifecycleState.Current, Type = FoodGroup.Sweeteners,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Blåbær", Url = "blabar", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Jordbær", Url = "jordbar", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Bringebær", Url = "bringebar", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønne epler", Url = "gronne-epler", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Røde epler", Url = "rode-epler", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gule epler", Url = "gule-epler", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Appelsin", Url = "appelsin", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sitron", Url = "sitron", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Økologisk sitron", Url = "okologisk-sitron", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lime", Url = "lime", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske mandarinbåter", Url = "hermetiske-mandarinbater", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske pærer", Url = "hermetiske-parer", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske fersken", Url = "hermetiske-fersken", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Banan", Url = "banan", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Klementin", Url = "klementin", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Blå druer", Url = "bla-druer", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønne druer", Url = "gronne-druer", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rosiner", Url = "rosiner", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Korinter", Url = "korinter", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Fiskesaus", Url = "fiskesaus", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosmelk", Url = "kokosmelk", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosmelk, lett", Url = "kokosmelk-lett", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokoskrem", Url = "kokoskrem", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosmasse", Url = "kokosmasse", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sitrongress", Url = "sitrongress", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rød currypasta", Url = "rod-currypasta", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønn currypasta", Url = "gronn-currypasta", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gul currypasta", Url = "gul-currypasta", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Galangal", Url = "galangal", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rød paprika", Url = "rod-paprika", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gul paprika", Url = "gul-paprika", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønn paprika", Url = "gronn-paprika", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Isbergsalat", Url = "isbergsalat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hjertesalat", Url = "hjertesalat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lollosalat", Url = "lollosalat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Maiskolbe, fersk", Url = "maiskolbe-fersk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetisk maiskolbe", Url = "hermetisk-maiskolbe", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske maiskorn", Url = "hermetiske-maiskorn", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Plommetomat", Url = "plommetomat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kirsebærtomat", Url = "kirsebartomat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Tomat", Url = "tomat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Slangeagurk", Url = "slangeagurk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gul løk", Url = "gul-lok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rødløk", Url = "rodlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chalottløk", Url = "chalottlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitløk", Url = "hvitlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Salatløk", Url = "salatlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Vårløk", Url = "varlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Purre", Url = "purre", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingkraft", Alias = "Kyllingbuljong", Url = "kyllingkraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Storfekraft", Alias = "Storfebuljong", Url = "storfekraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Fiskekraft", Alias = "Fiskebuljong", Url = "fiskekraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønnsakskraft", Alias = "Grønnsaksbuljong", Url = "gronnsakskraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chili, serrano", Alias = "Rød chili", Url = "chili-serrano", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Den vanlige, røde chilien du kjenner fra dagligvarebutikken."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chili, habanero", Url = "chili-habanero", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "En sterkere chili."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chili, birds eye", Url = "chili-birds-eye", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Også kalt thai-chili. Sterkere enn serrano."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Champignon, fersk", Url = "champignon-fersk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Champignon, hermetisk", Url = "champignon-hermetisk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Aromasopp, fersk", Url = "aromasopp-fersk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Aromasopp, tørket", Url = "aromasopp-torket", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Margarin", Url = "margarin", State = LifecycleState.Current, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling, hel grillet", Url = "kylling-hel-grillet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling, hel fersk", Url = "kylling-hel-fersk", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllinglår, grillet", Url = "kyllinglar-grillet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllinglår, fersk", Url = "kyllinglar-fersk", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllinglår, frossen", Url = "kyllinglar-frossen", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingvinger, grillet", Url = "kyllingvinger-grillet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingvinger, fersk", Url = "kyllingvinger-fersk", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingvinger, frossen", Url = "kyllingvinger-frossen", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling lårfilet", Url = "kylling-larfilet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling brystfilet", Url = "kylling-brystfilet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingkjøttdeig", Url = "kyllingkjottdeig", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kjøttdeig", Url = "kjottdeig", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Karbonadedeig", Url = "karbonadedeig", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Medisterdeig", Url = "medisterdeig", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Medisterfarse", Url = "medisterfarse", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Koriander, fersk", Url = "koriander-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Dill, fersk", Url = "dill-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gressløk, fersk", Url = "gresslok-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Basilikum, fersk", Url = "basilikum-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Thaibasilikum, fersk", Url = "thaibasilikum-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sort pepper, hel", Url = "sort-pepper-hel", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sort pepper, grovmalt", Url = "sort-pepper-grovmalt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sort pepper, malt", Url = "sort-pepper-malt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvit pepper, hel", Url = "hvit-pepper-hel", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvit pepper, grovmalt", Url = "hvit-pepper-grovmalt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvit pepper, malt", Url = "hvit-pepper-malt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Karri", Url = "karri", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitløkspulver", Url = "hvitlokspulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Løkpulver", Url = "lokpulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kanel, hel", Url = "kanel-hel", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kanel, malt", Url = "kanel-malt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kardemomme", Url = "kardemomme", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitløkspulver", Url = "hvitlokspulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chilipulver", Url = "chilipulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chiliflak", Url = "chiliflak", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Paprikapulver", Url = "paprikapulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Paprikapulver, røkt", Url = "paprikapulver-rokt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rosmarin, tørket", Url = "rosmarin-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Dill, tørket", Url = "dill-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Oregano, tørket", Url = "oregano-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Basilikum, tørket", Url = "basilikum-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Spisskum", Alias = "Spisskummen, spisskarve, cumin, Roman caraway", Url = "spisskum", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Latin: Cuminum cyminum. Engelsk: Cumin eller Roman caraway. Spisskum kan også kalles spisskummen eller spisskarve, og er ikke det samme som karve."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Karve", Alias = "Caraway", Url = "karve", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
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
        static int id_pannekDraft = NextInt(false);
        static int id_tomkha = NextInt(false);
        static int id_cacio = NextInt(false);
        static int id_kjottk = NextInt(false);
        static int id_taco = NextInt(false);
        static int id_ovnorr = NextInt(false);
        public static List<Recipe> ParentRecipes = [
            new Recipe(){
                Id = id_pannek, CountryCode = "NO", Name = "Pannekaker", State = LifecycleState.Current,
                RatingAverage = 7.4, Url = "pannekaker", Created = _create,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1,0,0),
                UserId = "c4fe3a8b-2a0e-46b1-9a3c-fc04f04c8a2d",
                Description = "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy eller sukker og sitrondråper."
            },
            new Recipe(){
                Id = id_pannekDraft, CountryCode = "NO", Name = "Pannekaker", State = LifecycleState.Draft,
                RatingAverage = 7.4, Url = "pannekaker", Created = _edit,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1,0,0),
                UserId = "c4fe3a8b-2a0e-46b1-9a3c-fc04f04c8a2d",
                Description = "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy, bananskiver og kondensert melk, eller sukker og sitrondråper."
            },
            new Recipe() { 
                Id = id_tomkha, CountryCode = "TH", Name = "Tom Kha Gai", State = LifecycleState.Current,
                RatingAverage = 8.1, Url = "tom-kha-gai", Created = _create,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 0, 0),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                Description = "En fantastisk smakfull kyllingsuppe."
            },
            new Recipe() { 
                Id = id_cacio, CountryCode = "IT", Name = "Cacio e Pepe", State = LifecycleState.Current,
                RatingAverage = 8.0, Url = "cacio-e-pepe", Created = _create,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(0, 20, 0),
                UserId = "9a441995-86e5-4da5-8fb3-7549187247ea",
                Description = "En enkel men utrolig god, klassisk pastarett."
            },
            new Recipe(){ 
                Id = id_kjottk, CountryCode = "NO", Name = "Kjøttkaker med kålstuing", State = LifecycleState.Current,
                RatingAverage = 7.3, Url = "kjottkaker-med-kalstuing", Created = _create,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1, 0, 0),
                UserId = "9a441995-86e5-4da5-8fb3-7549187247ea",
                Description = "Den kjente og kjære norske klassikeren, akkurat som mamma lagde den."
            },
            new Recipe() { 
                Id = id_taco, CountryCode = "MX", Name = "Taco", State = LifecycleState.Current,
                RatingAverage = 9.5, Url = "taco", Created = _create,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 30, 0),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                Description = "Taco fra grunnen av! Hjemmelagde hvetetortillas, tacokrydder, guacamole og salsa. Denne oppskriften legger grunnlaget for en god helg!"
            },
            new Recipe() { 
                Id = id_ovnorr, CountryCode = "NO", Name = "Ovnsbakt hel ørret", State = LifecycleState.Current,
                Url = "ovnsbakt-hel-orret", Created = _create,
                RatingAverage = 8.0, DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 30, 0),
                UserId = "1e4f5d6e-ad16-47b0-a412-107b48663239",
                Description = "Saftig og smaksrik søndagsmiddag."
            },
        ];

        public static List<Recipe> ChildRecipes = [
            new Recipe() {
                Id = NextInt(false),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Tacokrydder",
                Url = "tacokrydder", 
                CountryCode = "MX", 
                RatingAverage = 8.7, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Smakfullt tex-mex-krydder.",
                ChildRecipeSortOrder = 1,
                State = LifecycleState.Current,
                Created = _create
            },
            new Recipe() {
                Id = NextInt(false),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Hvetetortillas",
                Url = "hvetetortillas", 
                CountryCode = "MX", 
                RatingAverage = 8.9, 
                DifficultyLevel = DifficultyLevel.Intermediate, 
                PrepTime = new TimeSpan(0, 30, 0),
                Description = "Myke og deilige hvetetortillas! Perfekte til fredagstaco, laksewrap eller kyllingburrito!",
                ChildRecipeSortOrder = 2,
                State = LifecycleState.Current,
                Created = _create
            },
            new Recipe() {
                Id = NextInt(false),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Guacamole",
                Url = "guacamole", 
                CountryCode = "MX", 
                RatingAverage = 9.7, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Frisk og smakfull guacamole som er perfekt tilbehør til fredagstacoen!",
                ChildRecipeSortOrder = 3,
                State = LifecycleState.Current,
                Created = _create
            },
            new Recipe() {
                Id = NextInt(false),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Tomatsalsa",
                Url = "tomat-salsa", 
                CountryCode = "MX", 
                RatingAverage = 9.6, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Nydelig tomatsalsa som er perfekt tilbehør til fredagstacoen! Ha i chili etter smak, eller dropp chili for en mild salsa.",
                ChildRecipeSortOrder = 4,
                State = LifecycleState.Current,
                Created = _create
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
