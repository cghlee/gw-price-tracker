namespace PriceTracker.Models;

internal class TrackedItem
{
    internal required string Name { get; set; }
    internal required string Url { get; set; }
    internal int BuyPriceCurrent { get; set; }
    internal int BuyPriceTarget { get; set; }
    internal int SellPriceCurrent { get; set; }
    internal int SellPriceTarget { get; set; }
}
