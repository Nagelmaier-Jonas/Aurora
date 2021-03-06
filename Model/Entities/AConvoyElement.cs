using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Slots;

namespace Model.Entities;

[Table("CONVOY_ELEMENTS")]
public abstract class AConvoyElement{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ELEMENT_ID")]
    public int ElementId{ get; set; }
    
    [Required]
    [StringLength(100)]
    [Column("CODE")]
    public string Code { get; set; }

    [Column("PRICE")]
    [Range(0, int.MaxValue)]
    public int Price { get; set; }

    [Column("IMAGE")] public string? Image { get; set; } = "card/empty.png";

    public List<ASlot> Slots{ get; set; }
}