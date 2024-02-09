namespace MenuPlanner.Enums
{
    public static class EnumExtensionMethods
    {
        // Vise tilpassede etiketter for enum-verdier.
        // Dekorer enum-verdiene slik:
        // [Display(Name = "Min enumetikett")]
        // og vis dem i komponentet slik:
        // string displayName = MyEnum.GetDisplayName();
        public static string GetDisplayName(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            if (field is null)
                return value.ToString();

            var attribute = (DisplayAttribute)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));

            return attribute?.Name ?? value.ToString();
        }
    }
}
