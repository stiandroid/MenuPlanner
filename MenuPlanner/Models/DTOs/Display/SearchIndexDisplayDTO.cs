namespace MenuPlanner.Models.DTOs.Display
{
    public class SearchIndexDisplayDTO
    {
        public string EntityType { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        // Dette er nok informasjon til å vise søkeresultater med navn og bilde,
        // samt konstruere en full url ("/recipe/{Url}", "ingredient/{Url}", etc.).
        // Url tjenestegjør også som filnavnet for bildet.
    }
}
