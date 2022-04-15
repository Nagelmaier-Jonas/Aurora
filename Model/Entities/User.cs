using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("USERS")]
public class User{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("USER_ID")]
    public int Id{ get; set; }

    public List<Convoy> Convoys{ get; set; }

    [Column("USER_NAME", TypeName = "VARCHAR(50)")]
    public string Name{ get; set; }
    
    [Column("USER_PASSWORD", TypeName = "VARCHAR(50)")]
    public string Password{ get; set; }
}