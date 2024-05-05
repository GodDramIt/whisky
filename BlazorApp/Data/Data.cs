using BlazorApp.Enums;
using BlazorApp.Models;
namespace BlazorApp.Data;

public static class Data 
{
    public static List<WhiskyViewModel> GetWhiskies()
    {
        List<WhiskyViewModel> output = new();
        WhiskyViewModel mac12 = new("Macallan 12 Sherry Oak", 1, 12, .43, DISTILLERIES[1], CHARACTERISTICS.GetRange(3,8));
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
        new ("Sherry", 2),
        new ("Malt", 3),
        new ("Dried Fruit", 4),
        new ("Citrus", 5),
        new ("Ginger", 6),
        new ("Nutmeg", 7),
        new ("Raisins", 8),
        new ("Vanilla", 9),
        new ("Cinnamon", 10),
        new ("Oak", 11)
    ];
}