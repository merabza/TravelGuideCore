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
using TravelGuideCore.Domain.UrlModels;

namespace TravelGuideCore.Domain.PlaceModels;

//ItemData საჭიროა PlaceCruder-ისთვის — ჩანაწერი ველების რედაქტორებით იმართება
public sealed class PlaceModel : ItemData
{
    public int PlaceId { get; init; }

    //მისამართი არასავალდებულოა: საიტიდან ჩამოტვირთულ ადგილს აქვს, ხელით შეყვანილს (საიტზე არარსებულს) — არა;
    //უმისამართო ჩანაწერს ქროულერი არ ეხება. თავად მისამართი, მისი ხეშ-კოდი და ქროულინგის სტატუსი (EState) Urls
    //ცხრილის ჩანაწერია (UrlModel), რომელზეც ბმულების გრაფიც (UrlGraphNodes) მიუთითებს — ადგილს ერთხელ ებმება
    //(ქროულერისგან შექმნისას, ხელით შეყვანილს — მოგვიანებით, რედაქტორის Url ველით, ამიტომ UrlNavigation-ს set
    //აქვს; UrlId-ს ნავიგაციიდან EF ავსებს) და მერე აღარ იცვლება
    public int? UrlId { get; init; }

    public string? Name { get; set; }

    public int? RegionId { get; set; }
    public int? MunicipalityId { get; set; }
    public string? Description { get; set; }

    public RegionModel? RegionNavigation { get; set; }
    public MunicipalityModel? MunicipalityNavigation { get; set; }
    public UrlModel? UrlNavigation { get; set; }

    public ICollection<PlaceByBestSeason> BestSeasons { get; init; } = new HashSet<PlaceByBestSeason>();
    public ICollection<PlaceByCategory> Categories { get; init; } = new HashSet<PlaceByCategory>();
    public ICollection<PlaceByTag> Tags { get; init; } = new HashSet<PlaceByTag>();
    public ICollection<DistanceByPlace> Distances { get; init; } = new HashSet<DistanceByPlace>();
    public ICollection<PlaceByLocation> Locations { get; init; } = new HashSet<PlaceByLocation>();
}
