using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Slots;

[Table("SLOTS_BT")]
public abstract class ASlot{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SLOT_ID")]
    public int Id{ get; set; }

    public AConvoyElement Element{ get; set; }

    [Required]
    [Column("ELEMENT_ID")]
    public int ElementId{ get; set; }

    [Column("DAMAGED_STATE")]
    public string Damaged{ get; set; }
}