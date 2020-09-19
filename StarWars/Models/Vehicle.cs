namespace StarWars.Models
{
  public class Vehicle
  {
    public int Transport_ptr { get; set; }
    public string Vehicle_class { get; set; }
    public People Pilots { get; set; }

  }
}
