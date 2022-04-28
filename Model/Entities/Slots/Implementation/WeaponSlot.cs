using Model.Entities.Cargo;

namespace Model.Entities.Slots.Implementation;

public class WeaponSlot : ASlot{
    public override bool IsInsertable(ICargo cargo) => cargo.IsAddable(this);
}