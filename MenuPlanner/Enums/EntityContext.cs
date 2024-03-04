namespace MenuPlanner.Enums
{
    /// <summary>
    /// PageContext brukes for å angi om admin-komponentene UserHeader,
    /// RecipeHeader, IngredientHeader, NutrientHeader og AllergenHeader
    /// skal vise edit- (View), lagre- (Edit) eller sletteknapp (Delete).
    /// </summary>
    public enum EntityContext
    {
        Unset_do_not_use, // Hvis man utelater å sette parameteren PageContext når
                          // man kaller en av admin-komponentene nevnt over, så vil
                          // denne verdien settes som default i komponentet.
                          // Dette fører da til en InvalidOperationException, og sikrer
                          // at parameteren settes enten med verdien View eller Edit.
        View,   // => Komponentet skal vise edit-knapp
        Edit,   // => Komponentet skal vise lagreknapp
        Delete  // => Komponentet skal vise sletteknapp
    }
}
