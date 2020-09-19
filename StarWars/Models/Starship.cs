using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Models
{
  public class Starship
  {
    [Key]
    public int Id { get; set; }
    public int Transport_ptr { get; set; }
    public string Hyperdrive_rating { get; set; }
    public string MGLT { get; set; }
    public string Starship_class { get; set; }
    public People Pilots { get; set; }

    public virtual ICollection<People> ListOfPilots { get; set; }
  }
}
