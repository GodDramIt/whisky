namespace BlazorApp.Models;
public class Characteristic
{
    public string Note {get; set;}
    public int Id {get; set; }
    public Characteristic(string note, int id)
    {
        Note = note;
        Id = id;
    }
}