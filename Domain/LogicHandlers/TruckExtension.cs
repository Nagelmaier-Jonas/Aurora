using Model.Entities.Logic;
using Model.Entities;

namespace Domain.LogicHandlers; 

public static class TruckExtension {
    public static Truck ToDto(this Database.Truck truck) {
        var convelement = new ConvoyElementHandler();
        var truck1 = convelement.Trucks().FirstOrDefault(e => e.Code == truck.Code);
        return truck1;
    }
}