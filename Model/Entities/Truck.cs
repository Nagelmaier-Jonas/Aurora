using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("TRUCKS")]
public class Truck : AUpgradableElement{
    public List<Wagon> Wagons{ get; set; } = new();
    
    [Column("CAPACITY"), Required]
    public int Capacity { get; set; }

    [Column("SPEED"), Required]
    public int Speed{ get; set; }
}