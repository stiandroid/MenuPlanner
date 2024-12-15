namespace MenuPlanner.Models.DTOs.Manage
{
    public interface IDomainEditDTO
    {
        int? Id { get; }
        string Name { get; }
        string Alias { get; }
        string Description { get; }
        string Slug { get; }
        int SortOrder { get; }
        LifecycleState State { get; }
        string? UserId { get; }
    }
}
