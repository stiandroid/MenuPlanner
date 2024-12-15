namespace MenuPlanner.Models.Entities
{
    public interface IDomainEntity
    {
        int Id { get; }
        string Name { get; }
        string Alias { get; }
        string Description { get; }
        string Slug { get; }
        int SortOrder { get; }
        DateTime Created { get; }
        DateTime? Updated { get; }
        LifecycleState State { get; }
        string? UserId { get; }
    }
}
