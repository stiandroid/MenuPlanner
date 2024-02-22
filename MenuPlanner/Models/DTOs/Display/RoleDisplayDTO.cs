namespace MenuPlanner.Models.DTOs.Display
{
    public class RoleDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RoleGroup Group { get; set; }
    }
}
