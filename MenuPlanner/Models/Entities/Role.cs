namespace MenuPlanner.Models.Entities
{
    public class Role : IdentityRole
    {
        public int SortOrder { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RoleGroup Group { get; set; }

        public Role() : base() { }
        public Role(int sortOrder, string name, string displayName, string description, RoleGroup group) : base(name)
        {
            SortOrder = sortOrder;
            DisplayName = displayName;
            Description = description;
            Group = group;
        }
    }
}
