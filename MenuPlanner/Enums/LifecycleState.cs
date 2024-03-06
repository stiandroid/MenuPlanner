namespace MenuPlanner.Enums
{
    // Kan brukes på {entity} Recipe, Ingredient, Nutrient og Allergen
    public enum LifecycleState
    {// Status                 Forklaring                                   Hvem kan sette denne statusen?
        Draft,              // Upublisert arbeidsversjon                    SysAdmin, {entity}Editor
        PendingApproval,    // Klar for publisering, venter på godkjenning  SysAdmin, {entity}Editor
        Current,            // Publisert versjon                            SysAdmin, {entity}Publisher
        Archived,           // Arkivert versjon                             SysAdmin, {entity}Publisher
        Withdrawn           // Avpublisert (ingen versjon ligger ute)       SysAdmin, {entity}Publisher
    }
}
