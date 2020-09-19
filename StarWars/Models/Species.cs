using System;

namespace StarWars.Models
{
  public class Species
  {
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Name { get; set; }
    public string Classification { get; set; }
    public string Designation { get; set; }
    public string Average_height { get; set; }
    public string Skin_colors { get; set; }
    public string Hair_colors { get; set; }
    public string Eye_colors { get; set; }
    public string Average_lifespan { get; set; }
    public string Language { get; set; }
    public Planet Homeworld { get; set; }
    public string People { get; set; }
  }
}
