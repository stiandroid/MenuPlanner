namespace MenuPlanner.Models.DTOs.Display
{
    public class SearchIndexDisplayDTO : IDomainDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;

        public string EntityType { get; set; } = string.Empty;

        // Dette er nok informasjon til å vise søkeresultater med navn og bilde,
        // samt konstruere en full url ("/recipe/{Url}", "ingredient/{Url}", etc.).
        // Url tjenestegjør også som filnavnet for bildet.
    }
}
