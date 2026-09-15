using System;
using TravelGuideCore.Domain.LocationModels;
using TravelGuideCore.Domain.PlaceModels;

namespace TravelGuideCore.Domain.PlacesByLocations;

public sealed class PlaceByLocation
{
    public int PlaceId { get; init; }
    public int LocationId { get; init; }

    public PlaceModel PlaceNavigation
    {
        get => field ?? throw new InvalidOperationException("Uninitialized property: " + nameof(PlaceNavigation));
        init;
    }

    public LocationModel LocationNavigation
    {
        get => field ?? throw new InvalidOperationException("Uninitialized property: " + nameof(LocationNavigation));
        init;
    }
}
