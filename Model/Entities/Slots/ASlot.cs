using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Cargo;

namespace Model.Entities.Slots;

[Table("SLOTS")]
public abstract class ASlot : ISlot{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SLOT_ID")]
    public int Id{ get; set; }
    public AConvoyElement Element{ get; set; }

    [Required]
    [Column("ELEMENT_ID")]
    public int ElementId{ get; set; }

    [Column("DAMAGED_STATE")]
    public bool Damaged{ get; set; }

    [Column("IS_CONSTANT")]
    public bool IsConstant{ get; set; }

    public ACargo? Cargo{ get; set; }
    
    [Column("CARGO_ID")]
    public int CargoId{ get; set; }

    [Column("IMAGE")]
    public string Image{ get; set; }
    
    [Column("NAME")]
    public string Name{ get; set; }

    public abstract bool IsInsertable(ICargo cargo);
}