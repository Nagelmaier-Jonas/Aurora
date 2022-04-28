using Model.Entities.Slots;

namespace Model.Entities.Cargo;

public class CrewCargo : ACargo{
    public override bool IsAddable(CrewSlot crewSlot) => true;
    public override bool IsAddable(FuelSlot fuelSlot) => false;
}