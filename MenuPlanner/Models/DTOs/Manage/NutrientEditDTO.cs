namespace MenuPlanner.Models.DTOs.Manage
{
    public class NutrientEditDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
        public int SortOrder { get; set; }
        public bool AlwaysDisplay { get; set; } // F.eks. Salt bør kanskje alltid vises, selv om verdien er 0.
        public bool Emphasized { get; set; } // Vises i uthevet tekst.
        public NutrientType Type { get; set; }
        public NutrientType? SubTypeOf { get; set; }
    }
}
