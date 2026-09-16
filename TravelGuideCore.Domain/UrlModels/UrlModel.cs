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

    //მისამართის ქროულინგის მდგომარეობა (ჩამოსატვირთი, გაანალიზებული, ...) — სტატუსი მისამართისაა და არა ადგილის:
    //უმისამართო (ხელით შეყვანილ) ადგილს სტატუსი არ აქვს. ბაზაში int-ად ინახება
    public EState State { get; set; }
}
