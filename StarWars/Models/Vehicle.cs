using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarWars.Models
{
  public class Vehicle
  {
    [Key]
    public int Id { get; set; }
    public int Transport_ptr { get; set; }
    public string Vehicle_class { get; set; }
    public People Pilots { get; set; }

    public virtual ICollection<People> ListOfPilots { get; set; }
  }
}
