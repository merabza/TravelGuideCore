using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using TravelGuideCore.Domain.CategoryModels;
using TravelGuideCore.Domain.DistancesByPlaces;
using TravelGuideCore.Domain.FromPointModels;
using TravelGuideCore.Domain.LocationModels;
using TravelGuideCore.Domain.MonthModels;
using TravelGuideCore.Domain.MotorcycleModels;
using TravelGuideCore.Domain.MunicipalityModels;
using TravelGuideCore.Domain.PlaceModels;
using TravelGuideCore.Domain.PlacesByBestSeasons;
using TravelGuideCore.Domain.PlacesByCategories;
using TravelGuideCore.Domain.PlacesByLocations;
using TravelGuideCore.Domain.PlacesByTags;
using TravelGuideCore.Domain.RegionModels;
using TravelGuideCore.Domain.RouteDistanceModels;
using TravelGuideCore.Domain.TagModels;
using TravelGuideCore.Domain.TaskModels;
using TravelGuideCore.Domain.TaskStartPoints;
using TravelGuideCore.Domain.UrlGraphNodes;
using TravelGuideCore.Domain.VisitImages;
using TravelGuideCore.Domain.VisitModels;

namespace TravelGuideCore.Application.Abstractions;

//ბაზაში არსებული ცხრილები წარმოდგენილი DbSet-ების სახით და ის ოპერაციები,
//რომლებსაც რეპოზიტორიები კონტექსტისგან ითხოვენ
public interface ITravelGuideApplicationDbContext
{
    DbSet<TaskModel> Tasks { get; }
    DbSet<TaskStartPoint> TaskStartPoints { get; }
    DbSet<PlaceModel> Places { get; }
    DbSet<MonthModel> Months { get; }
    DbSet<CategoryModel> Categories { get; }
    DbSet<TagModel> Tags { get; }
    DbSet<PlaceByBestSeason> PlacesByBestSeasons { get; }
    DbSet<PlaceByCategory> PlacesByCategories { get; }
    DbSet<PlaceByTag> PlacesByTags { get; }
    DbSet<LocationModel> Locations { get; }
    DbSet<PlaceByLocation> PlacesByLocations { get; }
    DbSet<FromPointModel> FromPoints { get; }
    DbSet<DistanceByPlace> DistanceByPlaces { get; }
    DbSet<RegionModel> Regions { get; }
    DbSet<MunicipalityModel> Municipalities { get; }
    DbSet<MotorcycleModel> Motorcycles { get; }
    DbSet<UrlGraphNode> UrlGraphNodes { get; }
    DbSet<VisitModel> Visits { get; }
    DbSet<VisitImage> VisitImages { get; }
    DbSet<RouteDistanceModel> RouteDistances { get; }

    int SaveChanges();
    IDbContextTransaction BeginTransaction();
    EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;
}
