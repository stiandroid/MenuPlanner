namespace MenuPlanner.Enums
{
    /// <summary>
    /// PageContext brukes for å angi om admin-komponentene UserHeader,
    /// RecipeHeader, IngredientHeader, NutrientHeader og AllergenHeader
    /// skal vise edit- (View), lagre- (Edit) eller sletteknapp (Delete).
    /// </summary>
    public enum EntityContext
    {
        Unset,      // Hvis man utelater å sette parameteren PageContext når man
                    // kaller en av admin-komponentene nevnt over, så vil denne
                    // verdien settes som default i komponentet.
                    // Dette fører da til en InvalidOperationException, og sikrer at
                    // parameteren settes enten med verdien View, Edit eller Publish.

        View,       // => Komponentet skal vise edit-knapp

        Edit,       // => Komponentet skal vise lagreknapp

        Publish,    // => Komponentet skal vise publiseringsknapp

        Delete      // => Komponentet skal vise sletteknapp
    }
}
