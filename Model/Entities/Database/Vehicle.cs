using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Database;

[Table("VEHICLES")]
public class Vehicle {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column]
    public int VehicleId { get; set; }
    
    [Column]
    public string Code { get; set; }
}