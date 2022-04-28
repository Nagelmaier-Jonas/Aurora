using Model.Entities.Cargo;

namespace Model.Entities.Slots;

public interface ISlot{
    public bool IsInsertable(ICargo cargo);
}