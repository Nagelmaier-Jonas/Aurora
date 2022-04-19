using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("SESSIONS_JT")]
public class Session{

    [Column("USER_ID")]
    public int UserId{ get; set; }
    public User User{ get; set; }

    [Column("CONVOY_ID")]
    public int ConvoyId{ get; set; }
    public Convoy Convoy{ get; set; }

    [Column("MONEY")]
    public int Money{ get; set; }
}