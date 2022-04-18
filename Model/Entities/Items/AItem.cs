using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Enums;

namespace Model.Entities.Items;

[Table("ITEMS_BT")]
public abstract class AItem{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ITEM_ID")]
    public int Id{ get; set; }
    
    [Required]
    [Column("NAME",TypeName = "VARCHAR(50)")]
    public string Name{ get; set; }
    
    [Column("IMAGE")]
    public string Image { get; set; }
}