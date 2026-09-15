namespace TravelGuideCore.Domain.MunicipalityModels;

public sealed class MunicipalityModel
{
    public int MunicipalityId { get; init; }
    public required string Name { get; set; }
}
