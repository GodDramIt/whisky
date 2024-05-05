using BlazorApp.Enums;
using BlazorApp.Models;
namespace BlazorApp.Data;

public static class Data 
{
    public static List<WhiskyViewModel> GetWhiskies()
    {
        // this cannot be on a bottle  by bottle basis
        // it needs to be organized by region, then distillery
        // these characteristics are brutal... need to figure out some db control soon
        // the characteristics are how we're going to do our recs
        // we should also just have a button for give me something smoky, something sweet, something sherry-like
        // ex bourbon etc
        // give me something different
        List<WhiskyViewModel> output = new();
        WhiskyViewModel lag16 = new("Lagavulin 16", 1, 16, .43, DISTILLERIES[0], CHARACTERISTICS.GetRange(0, 5));
        WhiskyViewModel mac12 = new("Macallan 12 Sherry Oak", 2, 12, .43, DISTILLERIES[1], CHARACTERISTICS.GetRange(4,8));
        output.Add(lag16);
        output.Add(mac12);
        return output;
    }
    public static List<Distillery> DISTILLERIES =
    [
        new ("Lagavulin", 1, Region.Islay),
        new ("Macallan", 2, Region.Speyside),
        new ("Raasay", 3, Region.Islands),
        new ("Ardbeg", 4, Region.Islay),
        new ("Springbank", 5, Region.Campbeltown),
        new ("Glenglassaugh", 6, Region.Highland)
    ];
    public static List<Characteristic> CHARACTERISTICS =
    [
        new ("Peat", 1),
        new ("Iodine", 2),
        new ("Seaweed", 3),
        new ("Salt", 4),
        new ("Oak", 5),
        new ("Dried Fruit", 6),
        new ("Citrus", 7),
        new ("Ginger", 8),
        new ("Nutmeg", 9),
        new ("Raisins", 10),
        new ("Vanilla", 11),
        new ("Cinnamon", 12),
    ];
}