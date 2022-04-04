using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Database; 
[Table("WAGONS")]
public class Wagon : Vehicle {
    [Column]
    public int TruckId { get; set; }

    public Truck Truck { get; set; }
}