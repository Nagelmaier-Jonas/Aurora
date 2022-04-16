using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Items;

[Table("WEAPONS")]
public class Weapon : AItem{
    [Column("HIT_VALUE")]
    public int Hit{ get; set; }
    
    [Column("CRIT_VALUE")]
    public int Crit{ get; set; }
}