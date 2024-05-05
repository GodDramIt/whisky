namespace BlazorApp.Models;
public class Distillery 
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Region { get; set; }
    
    public Distillery(string name, int id, string region)
    {
        Name = name;
        Id = id;
        Region = region;
    }
}