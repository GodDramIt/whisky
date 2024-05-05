using BlazorApp.Components;
using BlazorApp.Models;
namespace BlazorApp.Data;

public static class Data 
{
    public static List<WhiskyViewModel> GetWhiskies()
    {
        List<WhiskyViewModel> output = new();
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
}