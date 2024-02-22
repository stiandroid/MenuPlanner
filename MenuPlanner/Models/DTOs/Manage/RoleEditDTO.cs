namespace MenuPlanner.Models.DTOs.Manage
{
    public class RoleEditDTO
    {
        public string? Id { get; set; }
        public int SortOrder { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RoleGroup Group { get; set; }
    }
}
