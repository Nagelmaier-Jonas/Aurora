using Model.Entities.Slots;

namespace Model.Entities.Cargo;

public class FuelCargo : ACargo{
    public override bool IsAddable(CrewSlot crewSlot) => false;
    public override bool IsAddable(FuelSlot fuelSlot) => true;
}