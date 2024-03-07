namespace MenuPlanner.Models.Entities
{
    public class Nutrient : ISearchableEntity
    {
        public int Id { get; set; }
        public LifecycleState State { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Autogenerert: "Folat" => "folat"
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool AlwaysDisplay { get; set; } // F.eks. Salt bør kanskje alltid vises, selv om verdien er 0.
        public bool Emphasized { get; set; } // Vises i uthevet tekst.
        public NutrientType Type { get; set; }
        public NutrientType? SubTypeOf { get; set; }
    }
}
