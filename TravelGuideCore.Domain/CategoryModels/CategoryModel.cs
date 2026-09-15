namespace TravelGuideCore.Domain.CategoryModels;

public sealed class CategoryModel
{
    public int CategoryId { get; init; }
    public required string Name { get; set; }
}
