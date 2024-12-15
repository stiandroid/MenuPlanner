namespace MenuPlanner.Models.DTOs.Display
{
    public class NutrientDisplayDTO : IDomainDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;

        public NutrientType Type { get; set; }
        public NutrientType? SubTypeOf { get; set; }
    }
}
