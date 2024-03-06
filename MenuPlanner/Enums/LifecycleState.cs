namespace MenuPlanner.Enums
{
    // Kan brukes på Recipe, Ingredient, Nutrient og Allergen
    public enum LifecycleState
    {// Status                 Forklaring                                   Hvem kan sette denne statusen?
        Draft,              // Upublisert arbeidsversjon                    SysAdmin, Editor
        PendingApproval,    // Klar for publisering, venter på godkjenning  SysAdmin, Editor
        Current,            // Publisert versjon                            SysAdmin, Publisher
        Archived,           // Arkivert versjon                             SysAdmin, Publisher
        Withdrawn           // Avpublisert (ingen versjon ligger ute)       SysAdmin, Publisher
    }
}
