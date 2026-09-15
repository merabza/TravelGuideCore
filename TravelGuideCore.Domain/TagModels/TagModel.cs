namespace TravelGuideCore.Domain.TagModels;

public sealed class TagModel
{
    public int TagId { get; init; }
    public required string Name { get; set; }
}
