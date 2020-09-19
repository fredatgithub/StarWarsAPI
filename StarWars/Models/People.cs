using System;

namespace StarWars.Models
{
  public class People
  {
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Name { get; set; }
    public string Height { get; set; }
    public string Mass { get; set; }
    public string Hair_color { get; set; }
    public string Skin_color { get; set; }
    public string Eye_color { get; set; }
    public byte Birth_year { get; set; }
    public string Gender { get; set; }
    public Planet Homeworld { get; set; }

  }
}
