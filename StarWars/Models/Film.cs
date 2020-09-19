using System;

namespace StarWars.Models
{
  public class Film
  {
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public string Title { get; set; }
    public int Episode_id { get; set; }
    public string Opening_crawl { get; set; }
    public string Director { get; set; }
    public string Producer { get; set; }
    public People Characters { get; set; }
    public Planet Planets { get; set; }
    public Species Species { get; set; }
    public Starship Starships { get; set; }
    public Vehicle Vehicles { get; set; }
    public DateTime Release_date { get; set; }
  }
}
