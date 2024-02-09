namespace MenuPlanner.Models.Entities
{
    public class SearchIndex : ISearchableEntity
    {
        public int Id { get; set; }
        public string EntityType { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string NormalizedName { get; set; } = string.Empty;

        // Normaliseringsregler:
        // * Alle tegn i små bokstaver
        // * Alle andre tegn enn a-å, 0-9 og mellomrom fjernes
        // (Bruk ExtensionMethods.StringExtensions.SearchIndexNormalize())
        //
        // Eksempel:
        //      Opprinnelig: "Vitamin B7, biotin"
        //      Normalisert: "vitamin b7 biotin"
    }
}
