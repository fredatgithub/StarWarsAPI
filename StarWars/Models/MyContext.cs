using System.Data.Entity;

namespace StarWars.Models
{
  public class MyContext : DbContext
  {
    public virtual DbSet<Film> Films { get; set; }
    public virtual DbSet<People> Persons { get; set; }
    public virtual DbSet<Planet> Planets { get; set; }
    public virtual DbSet<Species> Species { get; set; }
    public virtual DbSet<Starship> Starships { get; set; }
    public virtual DbSet<Transport> Transports { get; set; }
    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public MyContext() : base("name = StarWars") { }
  }
}
