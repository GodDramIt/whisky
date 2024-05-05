using BlazorApp.Enums;

namespace BlazorApp.Models;
public class Distillery 
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Region Region { get; set; }
    
    public Distillery(string name, int id, Region region)
    {
        Name = name;
        Id = id;
        Region = region;
    }
}