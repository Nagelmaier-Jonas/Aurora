using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Cargo;

namespace Model.Entities;

[Table("KEYWORDS")]
public class Keyword{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id{ get; set; }
    
    [Column("CARGO_ID")]
    public int CargoId{ get; set; }

    public ACargo Cargo{ get; set; }

    [Column("KEYWORD")]
    public EKeyword Value{ get; set; }
}