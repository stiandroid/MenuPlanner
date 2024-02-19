namespace MenuPlanner.Models.Entities
{
    public class Role : IdentityRole
    {
        public string DisplayName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public Role() : base() { }
        public Role(string name, string displayName, string description) : base(name)
        {
            DisplayName = displayName;
            Description = description;
        }
    }
}
