using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Slots;

[Table("SLOTS")]
public class Slot{
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

    public AItem Item{ get; set; }
    
    [Column("ITEM_ID")]
    public int ItemId{ get; set; }
}