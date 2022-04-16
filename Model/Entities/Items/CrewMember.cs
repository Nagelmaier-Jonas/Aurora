using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Items;

[Table("CREW_MEMBERS")]
public class CrewMember : AItem{
    [Column("HITPOINTS")]
    public int Hitpoints{ get; set; }
}