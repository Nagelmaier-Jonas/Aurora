using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Database; 
[Table("TRUCKS")]
public class Truck : Vehicle {
    [Column]
    public int ConvoyId { get; set; }

    public Convoy Convoy { get; set; }

    public List<Wagon> Wagons { get; set; }
}