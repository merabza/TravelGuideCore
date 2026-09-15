// ReSharper disable CollectionNeverUpdated.Global

using System.Collections.Generic;
using SystemTools.SystemToolsShared;
using TravelGuideCore.Domain.TaskStartPoints;

namespace TravelGuideCore.Domain.TaskModels;

public sealed class TaskModel : ItemData
{
    public int TaskId { get; init; }
    public required string TaskName { get; set; }
    public ICollection<TaskStartPoint> StartPoints { get; init; } = new HashSet<TaskStartPoint>();
}
