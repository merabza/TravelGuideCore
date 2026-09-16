namespace TravelGuideCore.Domain.UrlGraphNodes;

//გვერდებს შორის ბმულების გრაფის წიბო: FromUrlId მისამართის გვერდზე მოიძებნა GotUrlId მისამართი — ორივე Urls ცხრილის ჩანაწერია
public sealed class UrlGraphNode
{
    public int UgnId { get; init; }
    public int FromUrlId { get; init; }
    public int GotUrlId { get; init; }
}
