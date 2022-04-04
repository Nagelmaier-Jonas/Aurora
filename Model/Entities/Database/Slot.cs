using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Database;
[Table("SLOTS")]
public class Slot{
    [Column, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SlotId{ get; set; }

    [Column] public bool IsDamaged{ get; set; }
    [Column] public string CurrentItem{ get; set; }
    [Column] public int VehicleId{ get; set; }
    public Vehicle Vehicle{ get; set; }
}