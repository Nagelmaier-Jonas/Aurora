using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("TRUCKS")]
public class Truck : AUpgradeable
{
    public List<Wagon> Wagons { get; set; } = new();

    [Column("PULL_FORCE")] [Required] public int PullForce { get; set; }

    [Column("SPEED")] [Required] public int Speed { get; set; }
}