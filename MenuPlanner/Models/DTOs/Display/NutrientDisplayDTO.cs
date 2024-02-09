namespace MenuPlanner.Models.DTOs.Display
{
    public class NutrientDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty; // Autogenerert: "Folat" => "folat"
        public string Description { get; set; } = string.Empty;
        public NutrientType Type { get; set; }
        public NutrientType? SubTypeOf { get; set; }
    }
}
