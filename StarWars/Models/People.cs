using System;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Models
{
  public class People
  {
    [Key]
    public int PeopleId { get; set; }
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

    public People()
    {
      Created = DateTime.Now;
      Edited = DateTime.Now;
      Name = "no name";
      Homeworld = new Planet();
    }

    public People(string name)
    {
      Name = name;
    }

    public People(string name, DateTime created, DateTime edited)
    {
      Name = name;
      Created = created;
      Edited = edited;
    }
  }
}
