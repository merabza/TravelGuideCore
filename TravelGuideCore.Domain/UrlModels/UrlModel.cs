namespace TravelGuideCore.Domain.UrlModels;

//საიტიდან შეგროვებული მისამართი. ცალკე ცხრილია (Urls), რადგან ადგილს მისამართი შეიძლება არ ჰქონდეს (ხელით
//შეყვანილი), ბმულების გრაფი (UrlGraphNodes) კი მისამართებს შორის კავშირებს ინახავს და არა ადგილებს შორის;
//ადგილი მისამართს UrlId-ით ებმება
public sealed class UrlModel
{
    public int UrlId { get; init; }
    public required string Url { get; init; }

    //Url-ის დეტერმინისტული ხეშ-კოდი (StringExtension.GetDeterministicHashCode) — Url არ ინდექსირდება
    //და ჩანაწერი ბაზაში ამ ველით იძებნება
    public int UrlHashCode { get; init; }
}
