using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Slots;

[Table("CREW_SLOTS")]
public class CrewSlot : ASlot{
    [Column("CREW_MEMBER_ID")]
    public int CrewMemberId{ get; set; }
    
    public CrewMember CrewMember{ get; set; }
}