using System;

namespace StarWars.Models
{
  public class Transport
  {
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public string Cost_in_credits { get; set; }
    public string Length { get; set; }
    public string Max_atmosphering_speed { get; set; }
    public string Crew { get; set; }
    public string Passengers { get; set; }
    public string Cargo_capacity { get; set; }
    public string Consumables { get; set; }
    public People Pilots { get; set; }
  }
}
