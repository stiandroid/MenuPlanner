namespace MenuPlanner.Models.DTOs.Display
{
    public interface IDomainDisplayDTO
    {
        string Name { get; }
        string Alias { get; }
        string Description { get; }
        string Slug { get; }
    }
}
