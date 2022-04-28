using Model.Entities.Slots;

namespace Model.Entities.Cargo;

public interface ICargo{

    public bool IsAddable(CrewSlot crewSlot);
    
    public bool IsAddable(FuelSlot fuelSlot);
}