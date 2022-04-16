using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("KEYWORDS")]
public class Keyword{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("KEYWORD_ID")]
    public int Id{ get; set; }

    [Column("KEYWORD_VALUE")]
    public string Value{ get; set; }
}