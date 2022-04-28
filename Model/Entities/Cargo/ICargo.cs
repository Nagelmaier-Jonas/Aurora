using Model.Entities.Slots;
using Model.Entities.Slots.Implementation;

namespace Model.Entities.Cargo;

public interface ICargo{

    public bool IsAddable(CrewSlot crewSlot);
    public bool IsAddable(FuelSlot fuelSlot);
    public bool IsAddable(ArmorSlot armorSlot);
    public bool IsAddable(StandardSlot standardSlot);
    public bool IsAddable(WeaponSlot weaponSlot);
}