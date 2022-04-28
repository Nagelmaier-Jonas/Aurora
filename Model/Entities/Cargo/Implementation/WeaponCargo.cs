using Model.Entities.Slots.Implementation;

namespace Model.Entities.Cargo.Implementation;

public class WeaponCargo : ACargo{
    public override bool IsAddable(CrewSlot crewSlot) => false;
    public override bool IsAddable(FuelSlot fuelSlot) => false;
    public override bool IsAddable(ArmorSlot armorSlot) => false;
    public override bool IsAddable(StandardSlot standardSlot) => false;
    public override bool IsAddable(WeaponSlot weaponSlot) => true;
}