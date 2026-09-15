# TravelGuideCore

Domain entities and application abstractions of [TravelGuide](https://github.com/merabza/TravelGuide).

| Project | Purpose |
|---|---|
| `TravelGuideCore.Domain` | EF Core entities of the travel guide database, one folder per entity |
| `TravelGuideCore.Application.Abstractions` | `ITravelGuideApplicationDbContext` — the `DbSet` abstraction consumed by repositories |

The concrete `DbContext` and entity configurations live in [TravelGuideDbPart](https://github.com/merabza/TravelGuideDbPart).

## Repository layout — sibling repos are required

Projects reference sibling clones by relative path (`..\..\SystemTools\...`), so the repositories must be cloned next to each other:

```
<root>\
├── TravelGuideCore\         this repository (TravelGuideCore.slnx lives here)
└── SystemTools\             shared libraries (merabza/SystemTools)
```

## Build

```powershell
dotnet build TravelGuideCore.slnx
```

## License

[MIT](LICENSE)
