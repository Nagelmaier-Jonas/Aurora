using Model.Entities.Logic;

namespace Domain.LogicHandlers; 

public class ConvoyElementHandler {
    
    public List<Truck> Trucks() => new (){
        VehicleFactory.CreateHeavyTeslaTank(),
        VehicleFactory.CreateTurboTruckWithBiofuel(),
        VehicleFactory.CreateAPC(),
        VehicleFactory.CreateRailgunTruck(),
        VehicleFactory.CreateTruck(),
        VehicleFactory.CreateAtomTruck()
    };
    
    public List<Wagon> Wagons() => new (){
        VehicleFactory.CreateReinforcedFuelWagon(),
        VehicleFactory.CreateReinforcedWagon(),
        VehicleFactory.CreateWagon(),
        VehicleFactory.CreateMedicalWagon(),
        VehicleFactory.CreateDoubleReinforcedFuelWagon()
    };
    
    //List of all addons
    public List<Addon> Addons() => new() {
        VehicleFactory.CreateMachineGun(),
        VehicleFactory.CreateVulcanGun(), 
        VehicleFactory.CreateSmallStorage(), 
        VehicleFactory.CreateNuclearReactor(),
        VehicleFactory.CreateHeavyGun(),
        VehicleFactory.CreateArmor(),
        VehicleFactory.CreateLargeStorage(), 
        VehicleFactory.CreateGreenhouse(),
        VehicleFactory.CreateHeavyArmor(),
        VehicleFactory.CreateBioFuelGenerator(),
        VehicleFactory.CreateHeavyLargeStorage(),
        VehicleFactory.CreateGaussaGun(),
        VehicleFactory.CreateSmallNuclearReactor(),
        VehicleFactory.CreateMaintenanceDrone(),
        VehicleFactory.CreateZuraw(),
        VehicleFactory.CreateTurboBagpiper()
    };
}