using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("WAGGONS")]
public class Wagon : AUpgradableElement {
    [Column("TRUCK_ID")]
    public int? TruckId { get; set; }
    
    public Truck? Truck { get; set; }
}