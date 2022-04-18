using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("SESSIONS")]
public class Session{

    [Column("USER_ID")]
    public int UserId{ get; set; }

    [Column("CONVOY_ID")]
    public int ConvoyId{ get; set; }

    [Column("MONEY")]
    public int Money{ get; set; }
}