using Domain.LogicHandlers.Exceptions;
using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;
using Model.Entities.Slots;
using Model.Entities.Slots.Implementation;

namespace Domain.LogicHandlers;

public static class SlotExtension{
    //buy Cargo
    public static void BuyCargo(this ASlot slot, Session session, ACargo element) {
        if (!session.CanBuy(element.Price)) throw new ConvoyManagementException("Not enough money!");
        if (!slot.CanHaveCargo(session, element)) return;
        slot.Cargo = element;
        session.Money -= element.Price;
    }
    
    public static void SellCargo(this ASlot aSlot, Session session) {
        if (!aSlot.CanSellCargo(session.Convoy)) return;
        session.Money += aSlot.Cargo!.Price;
        aSlot.Cargo = null!;
    }
    
    
    
    // Holt sich das Keyword des CargoElements
    public static List<EKeyword> GetKeywords(this ASlot aSlot) =>
        aSlot.HasCargoElement() ? aSlot.Cargo!.GetKeywords() : new List<EKeyword>();
    
    // Holt sich den ImgPath für Slots
    public static string EvaluateSlotOrCargoImageUrl(this ASlot aSlot) =>
        // wenn a item drin is hod des a ImageUrl
        aSlot.Cargo is not null ?
            aSlot.Cargo.Image :
            aSlot.EvaluateImageUrl();
    // für alle andreen types dien leeren pfad zurück geben
    

    public static string EvaluateImageUrl(this ASlot aSlot) {
        // ignore armorslot because der is imma fixed (kaun ned lear sei)
        //if (aSlot.GetType() == typeof(WeaponSlot)) return "cards/StandardSlot.png";
        
        // ignore armorslot because der is imma fixed (kaun ned lear sei)
        //if (aSlot.GetType() == typeof(ArmorSlot)) return "cards/Armor.png";
        
        if (aSlot.Damaged) return "cards/DamagedSlot.png";
        
        if (aSlot.GetType() == typeof(FuelCargo)) return "cards/ChemicalSlot.png";
        return aSlot.GetType()== typeof(CrewSlot) ?
            "cards/CrewSlot.png" :
            "cards/StandardSlot.png";
    }

    public static string ToTypeString(this ASlot slot) =>
        slot.GetType().ToString().Split(".")[^1];

    // Kann der Cargo verkauft werden
    public static bool CanSellCargo(this ASlot aSlot, Convoy convoy) {
        // if (convoy.Location is not EConvoyLocation.City) return false;
        if (!aSlot.HasCargoElement()) return false;
        if (aSlot.Damaged || aSlot.IsConstant) return false;

        return true;
    }
    public static bool CanBuy(this ASlot aSlot, Convoy convoy) =>
        /* convoy.Location is EConvoyLocation.City && */ !aSlot.HasCargoElement();
    
    // Kann der Cargo gekauft werden
    public static bool CanHaveCargo(this ASlot aSlot, Session session, ACargo Cargo) {
        if (!aSlot.CanBuy(session.Convoy)) return false;
        if (aSlot.Damaged || aSlot.IsConstant) return false;
        if (!aSlot.IsInsertable(Cargo)) return false;
        if (!session.CanBuy(Cargo.Price)) return false;

        return true;
    }
    
    // hat der Slot ein Cargo
    public static bool HasCargoElement(this ASlot aSlot) => aSlot.Cargo is not null;
}