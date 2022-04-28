using Model.Entities.Cargo;

namespace Model.Entities.Slots;

public class CrewSlot : ASlot{
    
    public override bool IsInsertable(ICargo cargo) => cargo.IsAddable(this);
}