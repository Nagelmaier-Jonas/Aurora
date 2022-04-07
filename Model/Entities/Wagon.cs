using System.ComponentModel.DataAnnotations.Schema;
using Model.Enums;

namespace Model.Entities;

[Table("WAGONS")]
public class Wagon : AUpgradeable {
    [Column("TRUCK_ID")]
    public int? TruckId { get; set; }
    
    public Truck? Truck { get; set; }
}