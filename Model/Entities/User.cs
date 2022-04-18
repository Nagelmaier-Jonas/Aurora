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

    [Required]
    [Column("USER_NAME", TypeName = "VARCHAR(8)")]
    [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
    public string Name{ get; set; }
    
    [Required]
    [Column("USER_PASSWORD", TypeName = "VARCHAR(30)")]
    [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
    public string Password{ get; set; }
}