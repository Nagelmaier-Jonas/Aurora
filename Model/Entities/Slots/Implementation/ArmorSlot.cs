using Model.Entities.Cargo;

namespace Model.Entities.Slots.Implementation;

public class ArmorSlot : ASlot{
    public override bool IsInsertable(ICargo cargo) => cargo.IsAddable(this);
}