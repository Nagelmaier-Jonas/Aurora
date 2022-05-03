using Domain.LogicHandlers.Exceptions;
using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Slots;

namespace Domain.LogicHandlers;

public static class SlotExtension{
    public static void AddCargo(this ASlot slot, Session session, ACargo element) {
        if (!session.CanBuy(element.Price)) throw new ConvoyManagementException("Not enough money!");
        if (!slot.CanAddCargo(session, element)) return;
        slot.Cargo = element;
        session.Money -= element.Price;
    }
    
    public static void RemoveCargo(this ASlot aSlot, Session session) {
        if (!aSlot.CanRemove(session.Convoy)) return;
        session.Money += aSlot.Cargo!.Price;
        aSlot.Cargo = null!;
    }
    
    public static List<EKeyword> GetKeywords(this ASlot aSlot) =>
        aSlot.HasCargo() ? aSlot.Cargo!.GetKeywords() : new List<EKeyword>();
    
    public static bool CanRemove(this ASlot aSlot, Convoy convoy) {
        if (!aSlot.HasCargo()) return false;
        if (aSlot.Damaged || aSlot.IsConstant) return false;

        return true;
    }
    public static bool CanAdd(this ASlot aSlot, Convoy convoy) =>
        !aSlot.HasCargo();

    public static bool CanAddCargo(this ASlot aSlot, Session session, ACargo Cargo) {
        if (!aSlot.CanAdd(session.Convoy)) return false;
        if (aSlot.Damaged || aSlot.IsConstant) return false;
        if (!aSlot.IsInsertable(Cargo)) return false;
        if (!session.CanBuy(Cargo.Price)) return false;

        return true;
    }

    public static bool HasCargo(this ASlot aSlot) => aSlot.Cargo is not null;
}