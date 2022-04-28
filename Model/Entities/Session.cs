using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("SESSIONS")]
public class Session{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SESSION_ID")]
    public int Id{ get; set; }

    [Column("USER_ID")]
    public int UserId{ get; set; }
    public User User{ get; set; }

    [Column("CONVOY_ID")]
    public int ConvoyId{ get; set; }
    public Convoy Convoy{ get; set; }

    [Column("MONEY")] public int Money{ get; set; } = 10000;
}