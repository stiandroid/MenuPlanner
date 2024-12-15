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
                Id = NextInt(false), Name = "Protein", Slug = "protein", Type = NutrientType.Protein,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon."
            },

            // Karbohydrater
            new Nutrient() {
                Id = NextInt(false), Name = "Karbohydrater", Slug = "karbohydrater", Type = NutrientType.Carbohydrates,
                State = LifecycleState.Current, Created = _create,
                Description = "Total mengde karbohydrater, inkludert sukkerarter, polyoler og stivelse."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Sukkerarter", Slug = "sukkerarter",
                Type = NutrientType.Sugars, SubTypeOf = NutrientType.Carbohydrates, Created = _create,
                State = LifecycleState.Current, Description = "Informasjon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Polyoler", Slug = "polyoler",
                Type = NutrientType.Polyols, SubTypeOf = NutrientType.Carbohydrates, Created = _create,
                State = LifecycleState.Current, Description = "Informasjon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Stivelse", Slug = "stivelse",
                Type = NutrientType.Starch, SubTypeOf = NutrientType.Carbohydrates, Created = _create,
                State = LifecycleState.Current, Description = "Informasjon."
            },

            // Fett
            new Nutrient() {
                Id = NextInt(false), Name = "Fett", Slug = "fett",
                Type = NutrientType.Fats, State = LifecycleState.Current, Created = _create,
                Description = "Angir total mengde fett i en ingrediens, inkludert mettet, enumettet og flerumettet fett.", SortOrder = 1
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Mettet fett", Slug = "mettet-fett",
                Type = NutrientType.SaturatedFats, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 1
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Enumettet fett", Slug = "enumettet-fett",
                Type = NutrientType.MonoUnsaturatedFats, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 2
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Flerumettet fett", Slug = "flerumettet-fett",
                Type = NutrientType.PolyUnsaturatedFats, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 3
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Transfett", Slug = "transfett",
                Type = NutrientType.TransFat, SubTypeOf = NutrientType.Fats,
                State = LifecycleState.Current, Created = _create, Description = "Informasjon", SortOrder = 4
            },

            // Vitaminer
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin A, retinol", Slug = "vitamin-a-retinol",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B1, tiamin", Slug = "vitamin-b1-tiamin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B2, riboflavin", Slug = "vitamin-b2-riboflavin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B3, niacin", Slug = "vitamin-b3-niacin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B5, pantotensyre", Slug = "vitamin-b5-pantotensyre",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B7, biotin", Slug = "vitamin-b7-biotin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B9, folat", Slug = "vitamin-b9-folat",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin B12, kobalamin", Slug = "vitamin-b12-kobalamin",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin C, askorbinsyre", Slug = "vitamin-c-askorbinsyre",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin D2, ergokalsiferol", Slug = "vitamin-d2-ergokalsiferol",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin D3, kolikalsiferol", Slug = "vitamin-d3-kolikalsiferol",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin E, tokoferol (E306)", Slug = "vitamin-e-tokoferol-e306",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Tokoferol (E306) betegner en blanding av de rene stoffene alfa-tokoferol (E307), gamma-tokoferol (E308) og delta-tokoferol (E309)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin K1, fyllokinon", Slug = "vitamin-k1-fyllokinon",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vitamin K2, menakinon", Slug = "vitamin-k2-menakinon",
                Type = NutrientType.Vitamin, State = LifecycleState.Current, Created = _create,
                Description = "Informasjon"
            },

            // Mineraler
            new Nutrient() {
                Id = NextInt(false), Name = "Kalium", Slug = "kalium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Potassium"
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Klorin", Slug = "klorin", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Chlorine. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Natrium", Slug = "natrium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Sodium. Komponent i vanlig bordsalt (natriumklorid)."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Kalsium", Slug = "kalsium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Calcium. Viktig for skjelettet og tennene."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Fosfor", Slug = "fosfor", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Phosphorus."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Magnesium", Slug = "magnesium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Magnesium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Jern", Slug = "jern", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Iron."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Sink", Slug = "sink", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Zinc."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Mangan", Slug = "mangan", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Manganese."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Kobber", Slug = "kobber", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Copper."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Jod", Slug = "jod", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Iodine."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Molybden", Slug = "molybden", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Molybdenum."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Selen", Slug = "selen", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Selenium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Fluor", Slug = "fluor", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Fluoride."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Krom", Slug = "krom", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Chromium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Nikkel", Slug = "nikkel", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Nickel."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Bor", Slug = "bor", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Boron."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Silisium", Slug = "silisium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Silicon."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Vanadium", Slug = "vanadium", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Engelsk navn: Vanadium."
            },
            new Nutrient() {
                Id = NextInt(false), Name = "Salt", Slug = "salt", Type = NutrientType.Mineral,
                State = LifecycleState.Current, Created = _create, Description = "Natriumklorid (NaCl). Engelsk navn: Salt, sodium chloride."
            }
        };

        private static int GetNutrientId(string url)
            => Nutrients.Where(n => n.Slug == url).Select(i => i.Id).FirstOrDefault();

        public static List<Allergen> Allergens = new() { 
            new Allergen() {
                Id = NextInt(true), Name = "Krepsdyr", Slug = "krepsdyr", Description = "Informasjon",
                Created = _create,
                Icon = "crustacean.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sesamfrø", Slug = "sesamfro", Description = "Informasjon",
                Created = _create,
                Icon = "sesame.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Nøtter", Slug = "notter", Description = "Informasjon",
                Created = _create,
                Icon = "nuts.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Gluten", Slug = "gluten", Description = "Informasjon",
                Created = _create,
                Icon = "gluten.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Egg", Slug = "egg", Description = "Informasjon",
                Created = _create,
                Icon = "egg.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Fisk", Slug = "fisk", Description = "Informasjon",
                Created = _create,
                Icon = "fish.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Skalldyr", Slug = "skalldyr", Description = "Informasjon",
                Created = _create,
                Icon = "shellfish.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sennep", Slug = "sennep", Description = "Informasjon",
                Created = _create,
                Icon = "mustard.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Selleri", Slug = "selleri", Description = "Informasjon",
                Created = _create,
                Icon = "celery.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Peanøtter", Slug = "peanotter", Description = "Informasjon",
                Created = _create,
                Icon = "peanuts.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Melk", Slug = "melk", Description = "Informasjon",
                Created = _create,
                Icon = "milk.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Sulfitt", Slug = "sulfitt", Description = "Informasjon",
                Created = _create,
                Icon = "sulphite.png", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Soya", Slug = "soya", Description = "Informasjon",
                Created = _create,
                Icon = "", State = LifecycleState.Current
            },
            new Allergen() {
                Id = NextInt(false), Name = "Lupin", Slug = "lupin", Description = "Informasjon",
                Created = _create,
                Icon = "", State = LifecycleState.Current
            }
        };

        private static int GetAllergenId(string url)
            => Allergens.Where(a => a.Slug == url).Select(i => i.Id).FirstOrDefault();

        public static List<Ingredient> Ingredients = new(){
            new Ingredient(){
                Id = NextInt(true), Created = _create,
                Name = "Vann", Slug = "vann", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },

            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvetemel", Slug = "hvetemel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Pizzamel, tipo-00", Slug = "pizzamel-tipo-00", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Brødmel, tipo-0", Slug = "brodmel-tipo-0", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create, State = LifecycleState.Current,
                Name = "Semulegryn", Alias = "Semolina", Slug = "semulegryn", Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sammalt hvete, grovmalt", Slug = "sammalt-hvete-grovmalt", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sammalt hvete, finmalt", Slug = "sammalt-hvete-finmalt", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvete helkorn", Slug = "hvete-helkorn", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havregryn, lettkokt", Slug = "havregryn-lettkokt", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havregryn, store", Slug = "havregryn-store", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havregryn, glutenfri", Slug = "havregryn-glutenfri", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Havremel", Slug = "havremel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rug, helkorn", Slug = "rug-helkorn", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rugmel", Slug = "rugmel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Bygg, helkorn", Slug = "bygg-helkorn", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Byggmel", Slug = "byggmel", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gresskarkjerner", Slug = "gresskarkjerner", State = LifecycleState.Current, Type = FoodGroup.Grains,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Skummet melk", Slug = "skummet-melk", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lettmelk", Slug = "lettmelk", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                EnergyKcalPer100g = 41, Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Helmelk", Slug = "helmelk", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kremfløte", Slug = "kremflote", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Matfløte", Slug = "matflote", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lettrømme", Slug = "lettromme", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Seterrømme", Slug = "seterromme", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rømmekolle", Slug = "rommekolle", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kvarg", Slug = "kvarg", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,State = LifecycleState.Current,
                Name = "Gulost", Alias = "Hvitost", Slug = "gulost", Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Edamer", Slug = "edamer", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gouda", Slug = "gouda", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Brie", Slug = "brie", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kremost", Slug = "kremost", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Cottage cheese", Slug = "cottage-cheese", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Ricotta", Slug = "ricotta", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Halloumi", Alias = "Grillost", Slug = "halloumi", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Mozzarella", Slug = "mozzarella", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Cheddar", Slug = "cheddar", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Geitost", Slug = "geitost", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Fløtemysost", Slug = "flotemysost", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Egg", Slug = "egg", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Egg fra høne. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eggeplomme", Slug = "eggeplomme", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Eggeplomme fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggeplommer i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eggehvite", Slug = "eggehvite", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Eggehvite fra hønseegg. Oppskrifter tar som regel utgangspunkt i middels store egg. Dersom oppskriften oppgir eggehviter i antall, og eggene du har er spesielt små eller store kan du måtte justere antallet."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Vaktelegg", Slug = "vaktelegg", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Egg fra vaktel."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Måsegg", Slug = "masegg", State = LifecycleState.Current, Type = FoodGroup.Eggs,
                Description = "Egg fra måke (måse)."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Tortillachips", Slug = "tortillachips", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Nachochips", Slug = "nachochips", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Salt", Slug = "salt", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Tomatketsjup", Slug = "tomatketsjup", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Søt sennep", Slug = "sot-sennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sterk sennep", Slug = "sterk-sennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Dijonsennep", Slug = "dijonsennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grov sennep", Slug = "grov-sennep", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Soyasaus", Slug = "soyasaus", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Saltredusert soyasaus", Slug = "saltredusert-soyasaus", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eddikessens", Slug = "eddikessens", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "35%"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Klar eddik", Slug = "klar-eddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Brun eddik", Slug = "brun-eddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "7%"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Eplecidereddik", Slug = "eplecidereddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitvinseddik", Slug = "hvitvinseddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rødvinseddik", Slug = "rodvinseddik", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sitrondråper", Slug = "sitrondråper", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Smør", Slug = "smor", State = LifecycleState.Current, Type = FoodGroup.Dairy,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Margarin", Slug = "margarin", State = LifecycleState.Current, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rapsolje", Slug = "rapsolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Maisolje", Slug = "maisolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Olivenolje", Slug = "Olivenolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sesamolje", Slug = "sesamolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosolje", Slug = "kokosolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Frityrolje", Slug = "frityrolje", State = LifecycleState.Current, Type = FoodGroup.Oils,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sukker", Slug = "sukker", State = LifecycleState.Current, Type = FoodGroup.Sweeteners,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Blåbær", Slug = "blabar", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Jordbær", Slug = "jordbar", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Bringebær", Slug = "bringebar", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønne epler", Slug = "gronne-epler", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Røde epler", Slug = "rode-epler", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gule epler", Slug = "gule-epler", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Appelsin", Slug = "appelsin", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sitron", Slug = "sitron", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Økologisk sitron", Slug = "okologisk-sitron", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lime", Slug = "lime", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske mandarinbåter", Slug = "hermetiske-mandarinbater", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske pærer", Slug = "hermetiske-parer", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske fersken", Slug = "hermetiske-fersken", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Banan", Slug = "banan", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Klementin", Slug = "klementin", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Blå druer", Slug = "bla-druer", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønne druer", Slug = "gronne-druer", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rosiner", Slug = "rosiner", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Korinter", Slug = "korinter", State = LifecycleState.Current, Type = FoodGroup.Fruits,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Fiskesaus", Slug = "fiskesaus", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosmelk", Slug = "kokosmelk", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosmelk, lett", Slug = "kokosmelk-lett", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokoskrem", Slug = "kokoskrem", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kokosmasse", Slug = "kokosmasse", State = LifecycleState.Current, Type = FoodGroup.CoconutProducts,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sitrongress", Slug = "sitrongress", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rød currypasta", Slug = "rod-currypasta", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønn currypasta", Slug = "gronn-currypasta", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gul currypasta", Slug = "gul-currypasta", State = LifecycleState.Current, Type = FoodGroup.Condiments,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Galangal", Slug = "galangal", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rød paprika", Slug = "rod-paprika", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gul paprika", Slug = "gul-paprika", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønn paprika", Slug = "gronn-paprika", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Isbergsalat", Slug = "isbergsalat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hjertesalat", Slug = "hjertesalat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Lollosalat", Slug = "lollosalat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Maiskolbe, fersk", Slug = "maiskolbe-fersk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetisk maiskolbe", Slug = "hermetisk-maiskolbe", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hermetiske maiskorn", Slug = "hermetiske-maiskorn", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Plommetomat", Slug = "plommetomat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kirsebærtomat", Slug = "kirsebartomat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Tomat", Slug = "tomat", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Slangeagurk", Slug = "slangeagurk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gul løk", Slug = "gul-lok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rødløk", Slug = "rodlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chalottløk", Slug = "chalottlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitløk", Slug = "hvitlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Salatløk", Slug = "salatlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Vårløk", Slug = "varlok", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Purre", Slug = "purre", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingkraft", Alias = "Kyllingbuljong", Slug = "kyllingkraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Storfekraft", Alias = "Storfebuljong", Slug = "storfekraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Fiskekraft", Alias = "Fiskebuljong", Slug = "fiskekraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Grønnsakskraft", Alias = "Grønnsaksbuljong", Slug = "gronnsakskraft", State = LifecycleState.Current, Type = FoodGroup.Other,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chili, serrano", Alias = "Rød chili", Slug = "chili-serrano", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Den vanlige, røde chilien du kjenner fra dagligvarebutikken."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chili, habanero", Slug = "chili-habanero", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "En sterkere chili."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chili, birds eye", Slug = "chili-birds-eye", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Også kalt thai-chili. Sterkere enn serrano."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Champignon, fersk", Slug = "champignon-fersk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Champignon, hermetisk", Slug = "champignon-hermetisk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Aromasopp, fersk", Slug = "aromasopp-fersk", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Aromasopp, tørket", Slug = "aromasopp-torket", State = LifecycleState.Current, Type = FoodGroup.Vegetables,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Margarin", Slug = "margarin", State = LifecycleState.Current, Type = FoodGroup.DairySubstitutes,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling, hel grillet", Slug = "kylling-hel-grillet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling, hel fersk", Slug = "kylling-hel-fersk", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllinglår, grillet", Slug = "kyllinglar-grillet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllinglår, fersk", Slug = "kyllinglar-fersk", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllinglår, frossen", Slug = "kyllinglar-frossen", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingvinger, grillet", Slug = "kyllingvinger-grillet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingvinger, fersk", Slug = "kyllingvinger-fersk", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingvinger, frossen", Slug = "kyllingvinger-frossen", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling lårfilet", Slug = "kylling-larfilet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kylling brystfilet", Slug = "kylling-brystfilet", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kyllingkjøttdeig", Slug = "kyllingkjottdeig", State = LifecycleState.Current, Type = FoodGroup.Poultry,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kjøttdeig", Slug = "kjottdeig", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Karbonadedeig", Slug = "karbonadedeig", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Medisterdeig", Slug = "medisterdeig", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Medisterfarse", Slug = "medisterfarse", State = LifecycleState.Current, Type = FoodGroup.Meats,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Koriander, fersk", Slug = "koriander-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Dill, fersk", Slug = "dill-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Gressløk, fersk", Slug = "gresslok-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Basilikum, fersk", Slug = "basilikum-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Thaibasilikum, fersk", Slug = "thaibasilikum-fersk", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sort pepper, hel", Slug = "sort-pepper-hel", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sort pepper, grovmalt", Slug = "sort-pepper-grovmalt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Sort pepper, malt", Slug = "sort-pepper-malt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvit pepper, hel", Slug = "hvit-pepper-hel", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvit pepper, grovmalt", Slug = "hvit-pepper-grovmalt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvit pepper, malt", Slug = "hvit-pepper-malt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Karri", Slug = "karri", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitløkspulver", Slug = "hvitlokspulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Løkpulver", Slug = "lokpulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kanel, hel", Slug = "kanel-hel", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kanel, malt", Slug = "kanel-malt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Kardemomme", Slug = "kardemomme", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Hvitløkspulver", Slug = "hvitlokspulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chilipulver", Slug = "chilipulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Chiliflak", Slug = "chiliflak", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Paprikapulver", Slug = "paprikapulver", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Paprikapulver, røkt", Slug = "paprikapulver-rokt", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Rosmarin, tørket", Slug = "rosmarin-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Dill, tørket", Slug = "dill-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Oregano, tørket", Slug = "oregano-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Basilikum, tørket", Slug = "basilikum-torket", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Informasjon"
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Spisskum", Alias = "Spisskummen, spisskarve, cumin, Roman caraway", Slug = "spisskum", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Latin: Cuminum cyminum. Engelsk: Cumin eller Roman caraway. Spisskum kan også kalles spisskummen eller spisskarve, og er ikke det samme som karve."
            },
            new Ingredient(){
                Id = NextInt(false), Created = _create,
                Name = "Karve", Alias = "Caraway", Slug = "karve", State = LifecycleState.Current, Type = FoodGroup.HerbsAndSpices,
                Description = "Latin: Carum carvi. Engelsk: Caraway. Karve er ikke det samme som spisskum/spisskummen/spisskarve/Roman caraway."
            },
        };

        private static int GetIngredientId(string url)
            => Ingredients.Where(i => i.Slug == url).Select(i => i.Id).FirstOrDefault();

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
                RatingAverage = 7.4, Slug = "pannekaker", Created = _create,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1,0,0),
                UserId = "c4fe3a8b-2a0e-46b1-9a3c-fc04f04c8a2d",
                Description = "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy eller sukker og sitrondråper."
            },
            new Recipe(){
                Id = id_pannekDraft, CountryCode = "NO", Name = "Pannekaker", State = LifecycleState.Draft,
                RatingAverage = 7.4, Slug = "pannekaker", Created = _edit,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1,0,0),
                UserId = "c4fe3a8b-2a0e-46b1-9a3c-fc04f04c8a2d",
                Description = "Deilige, tynne pannekaker er hele familiens favoritt. Server gjerne med blåbærsyltetøy, bananskiver og kondensert melk, eller sukker og sitrondråper."
            },
            new Recipe() { 
                Id = id_tomkha, CountryCode = "TH", Name = "Tom Kha Gai", State = LifecycleState.Current,
                RatingAverage = 8.1, Slug = "tom-kha-gai", Created = _create,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 0, 0),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                Description = "En fantastisk smakfull kyllingsuppe."
            },
            new Recipe() { 
                Id = id_cacio, CountryCode = "IT", Name = "Cacio e Pepe", State = LifecycleState.Current,
                RatingAverage = 8.0, Slug = "cacio-e-pepe", Created = _create,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(0, 20, 0),
                UserId = "9a441995-86e5-4da5-8fb3-7549187247ea",
                Description = "En enkel men utrolig god, klassisk pastarett."
            },
            new Recipe(){ 
                Id = id_kjottk, CountryCode = "NO", Name = "Kjøttkaker med kålstuing", State = LifecycleState.Current,
                RatingAverage = 7.3, Slug = "kjottkaker-med-kalstuing", Created = _create,
                DifficultyLevel = DifficultyLevel.Easy, PrepTime = new TimeSpan(1, 0, 0),
                UserId = "9a441995-86e5-4da5-8fb3-7549187247ea",
                Description = "Den kjente og kjære norske klassikeren, akkurat som mamma lagde den."
            },
            new Recipe() { 
                Id = id_taco, CountryCode = "MX", Name = "Taco", State = LifecycleState.Current,
                RatingAverage = 9.5, Slug = "taco", Created = _create,
                DifficultyLevel = DifficultyLevel.Intermediate, PrepTime = new TimeSpan(1, 30, 0),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                Description = "Taco fra grunnen av! Hjemmelagde hvetetortillas, tacokrydder, guacamole og salsa. Denne oppskriften legger grunnlaget for en god helg!"
            },
            new Recipe() { 
                Id = id_ovnorr, CountryCode = "NO", Name = "Ovnsbakt hel ørret", State = LifecycleState.Current,
                Slug = "ovnsbakt-hel-orret", Created = _create,
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
                Slug = "tacokrydder", 
                CountryCode = "MX", 
                RatingAverage = 8.7, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Smakfullt tex-mex-krydder.",
                SortOrder = 1,
                State = LifecycleState.Current,
                Created = _create
            },
            new Recipe() {
                Id = NextInt(false),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Hvetetortillas",
                Slug = "hvetetortillas", 
                CountryCode = "MX", 
                RatingAverage = 8.9, 
                DifficultyLevel = DifficultyLevel.Intermediate, 
                PrepTime = new TimeSpan(0, 30, 0),
                Description = "Myke og deilige hvetetortillas! Perfekte til fredagstaco, laksewrap eller kyllingburrito!",
                SortOrder = 2,
                State = LifecycleState.Current,
                Created = _create
            },
            new Recipe() {
                Id = NextInt(false),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Guacamole",
                Slug = "guacamole", 
                CountryCode = "MX", 
                RatingAverage = 9.7, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Frisk og smakfull guacamole som er perfekt tilbehør til fredagstacoen!",
                SortOrder = 3,
                State = LifecycleState.Current,
                Created = _create
            },
            new Recipe() {
                Id = NextInt(false),
                UserId = "4370fb76-7b81-46f6-a95b-cd40be024f58",
                ParentRecipeId = GetRecipeId("parent", "taco"), 
                Name = "Tomatsalsa",
                Slug = "tomat-salsa", 
                CountryCode = "MX", 
                RatingAverage = 9.6, 
                DifficultyLevel = DifficultyLevel.Easy, 
                PrepTime = new TimeSpan(0, 0, 10),
                Description = "Nydelig tomatsalsa som er perfekt tilbehør til fredagstacoen! Ha i chili etter smak, eller dropp chili for en mild salsa.",
                SortOrder = 4,
                State = LifecycleState.Current,
                Created = _create
            },
        ];

        private static int GetRecipeId(string generation, string url) => generation switch { 
            "parent" => ParentRecipes.Where(r => r.Slug == url).Select(i => i.Id).FirstOrDefault(),
            "child" => ChildRecipes.Where(r => r.Slug == url).Select(i => i.Id).FirstOrDefault(),
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
