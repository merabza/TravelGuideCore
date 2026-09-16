// ReSharper disable CollectionNeverUpdated.Global

using System.Collections.Generic;
using SystemTools.SystemToolsShared;
using TravelGuideCore.Domain.DistancesByPlaces;
using TravelGuideCore.Domain.MunicipalityModels;
using TravelGuideCore.Domain.PlacesByBestSeasons;
using TravelGuideCore.Domain.PlacesByCategories;
using TravelGuideCore.Domain.PlacesByLocations;
using TravelGuideCore.Domain.PlacesByTags;
using TravelGuideCore.Domain.RegionModels;

namespace TravelGuideCore.Domain.PlaceModels;

//ItemData საჭიროა PlaceCruder-ისთვის — ჩანაწერი ველების რედაქტორებით იმართება
public sealed class PlaceModel : ItemData
{
    public int PlaceId { get; init; }

    //მისამართი არასავალდებულოა: საიტიდან ჩამოტვირთულ ადგილს აქვს, ხელით შეყვანილს (საიტზე არარსებულს) — არა;
    //უმისამართო ჩანაწერს ქროულერი არ ეხება
    public string? Url { get; init; }

    //Url-ის დეტერმინისტული ხეშ-კოდი (StringExtension.GetDeterministicHashCode) — Url აღარ ინდექსირდება
    //და ჩანაწერი ბაზაში ამ ველით იძებნება; უმისამართო ჩანაწერს ხეშ-კოდიც არ აქვს
    public int? UrlHashCode { get; init; }

    public string? Name { get; set; }

    public int? RegionId { get; set; }
    public int? MunicipalityId { get; set; }
    public string? Description { get; set; }
    public EState State { get; set; }

    public RegionModel? RegionNavigation { get; set; }
    public MunicipalityModel? MunicipalityNavigation { get; set; }

    public ICollection<PlaceByBestSeason> BestSeasons { get; init; } = new HashSet<PlaceByBestSeason>();
    public ICollection<PlaceByCategory> Categories { get; init; } = new HashSet<PlaceByCategory>();
    public ICollection<PlaceByTag> Tags { get; init; } = new HashSet<PlaceByTag>();
    public ICollection<DistanceByPlace> Distances { get; init; } = new HashSet<DistanceByPlace>();
    public ICollection<PlaceByLocation> Locations { get; init; } = new HashSet<PlaceByLocation>();
}
