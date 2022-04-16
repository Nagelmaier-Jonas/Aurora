using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Slots;

[Table(("WEAPON_SLOTS"))]
public class WeaponSlot : ASlot{
    [Column("WEAPON_ID")]
    public int WeaponId{ get; set; }
    
    public Weapon Weapon{ get; set; }
}