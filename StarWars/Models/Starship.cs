namespace StarWars.Models
{
  public class Starship
  {
    public int Transport_ptr { get; set; }
    public string Hyperdrive_rating { get; set; }
    public string MGLT { get; set; }
    public string Starship_class { get; set; }
    public People Pilots { get; set; }
  }
}
