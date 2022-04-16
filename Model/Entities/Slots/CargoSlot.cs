using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Slots;

[Table("CARGO_SLOTS")]
public class CargoSlot : ASlot{
    [Column("CARGO_ID")]
    public int CargoId{ get; set; }
    
    public Cargo Cargo{ get; set; }
}