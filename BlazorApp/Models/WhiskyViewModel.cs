namespace BlazorApp.Models;
public class WhiskyViewModel
{
    public string Nickname { get; set; }
    public int Id { get; set; }
    public int? Age { get; set; }
    public Distillery Distillery { get; set; }
    public List<Characteristic> Characteristics {get; set;}
    public WhiskyViewModel(string nickname, int id, int? age, Distillery distillery, List<Characteristic> characteristics)
    {
        Nickname = nickname;
        Id = id;
        Age = age;
        Distillery = distillery;
        Characteristics = characteristics;
    }
}