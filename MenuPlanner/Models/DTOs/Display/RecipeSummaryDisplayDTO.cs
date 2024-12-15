namespace MenuPlanner.Models.DTOs.Display
{
    // Denne modellen brukes bl.a. i søkeresultatet. Her hadde det muligens vært nyttig
    // å kunne linke til hovedoppskriften dersom dette er en underoppskrift. Hvordan skal
    // de i så fall vises i komponentet, og skal vi bruke ParentRecipeId eller Url?
    public class RecipeSummaryDisplayDTO : IDomainDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty; // Autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"

        public LifecycleState State { get; set; } // Nyttig for å vise status i admin
        public DifficultyLevel? DifficultyLevel { get; set; }
        public double? RatingAverage { get; set; }
        public TimeSpan? PrepTime { get; set; }
        public CountryDisplayDTO? Country { get; set; }
        public UserDisplayDTO? User { get; set; }
    }
}
