﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Models
{
  public class Planet
  {
    [Key]
    public int PlanetId { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Name { get; set; }
    public string Rotation_period { get; set; }
    public string Orbital_period { get; set; }
    public string Diameter { get; set; }
    public string Climate { get; set; }
    public string Gravity { get; set; }
    public string Terrain { get; set; }
    public string Surface_water { get; set; }
    public string Population { get; set; }
  }
}
