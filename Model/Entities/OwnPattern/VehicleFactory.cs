namespace Model.Entities.OwnPattern; 

public class VehicleFactory{
    // List of all trucks
    public static readonly List<Truck> Trucks = new (){
        CreateHeavyTeslaTank(),
        CreateTurboTruckWithBiofuel(),
        CreateAPC(),
        CreateRailgunTruck(),
        CreateTruck(),
        CreateAtomTruck()
    };
    // List of all wagons
    public static readonly List<Wagon> Wagons = new (){
        CreateReinforcedFuelWagon(),
        CreateReinforcedWagon(),
        CreateWagon(),
        CreateMedicalWagon(),
        CreateDoubleReinforcedFuelWagon()
    };
    //List of all addons
    public static readonly List<Addon> Addons = new() {
        CreateMachineGun(),
        CreateVulcanGun(), 
        CreateSmallStorage(), 
        CreateNuclearReactor(),
        CreateHeavyGun(),
        CreateArmor(),
        CreateLargeStorage(), 
        CreateGreenhouse(),
        CreateHeavyArmor(),
        CreateBioFuelGenerator(),
        CreateHeavyLargeStorage(),
        CreateGaussaGun(),
        CreateSmallNuclearReactor(),
        CreateMaintenanceDrone(),
        CreateZuraw(),
        CreateTurboBagpiper()
};
    // <summary>
    // All methods to create trucks
    // </summary>
    public static Truck CreateExampleTruck() {
        return new Truck("Example", 10, 4, 4, 4, "example");
    }
    public static Truck CreateHeavyTeslaTank() {
        // TODO: price and Addons
        return new Truck("Heavy Tesla Tank", 10, 4, 3, 3, "truck1");
    }
    public static Truck CreateTurboTruckWithBiofuel() {
        // TODO: price and Addons
        return new Truck("Turbo Truck with Biofuel", 10, 4, 4, 3, "truck2");
    }
    
    public static Truck CreateAPC() {
        // TODO: price and Addons
        return new Truck("APC", 10, 4, 2, 3, "truck3");
    }
    
    public static Truck CreateRailgunTruck() {
        // TODO: price and Addons
        return new Truck("Railgun Truck", 10, 4, 4, 3, "truck4");
    }

    public static Truck CreateTruck() {
        // TODO: price and Addons
        return new Truck("Truck", 10, 4, 2, 2, "truck5");
    }

    public static Truck CreateAtomTruck() {
        // TODO: price and Addons
        return new Truck("Atom Truck", 10, 4, 4, 3, "truck6");
    }
    
    // <summary>
    // All methods to create wagons
    // </summary>
    public static Wagon CreateExampleWagon() => new ("Example", 10, 4, "example");
    public static Wagon CreateReinforcedFuelWagon() => new ("Reinforced Fuel Wagon", 10, 4, "cargo1");
    public static Wagon CreateReinforcedWagon() => new ("Reinforced Wagon", 10, 4, "cargo2");
    public static Wagon CreateWagon() => new ("Wagon", 10, 3, "cargo4");
    public static Wagon CreateMedicalWagon() => new ("Medical Wagon", 10, 4, "cargo5");
    public static Wagon CreateDoubleReinforcedFuelWagon() => new("Double Reinforced Fuel Wagon", 10, 4, "cargo6");
    
    // <summary>
    // All methods to create Addons
    // </summary>
    public static Addon CreateMachineGun() => new("Machine Gun", 10, 2, "add1");
    public static Addon CreateVulcanGun() => new("Vulcan Gun", 10, 1, "add2");
    public static Addon CreateSmallStorage() => new("Small Storage", 10, 2, "add3");
    public static Addon CreateNuclearReactor() => new("Nuclear Reactor", 10, 1, "add5");
    public static Addon CreateHeavyGun() => new("Heavy Gun", 10, 1, "add7");
    public static Addon CreateArmor() => new("Armor", 10, 3, "add8");
    public static Addon CreateLargeStorage() => new("Large Storage", 10, 3, "add9");
    public static Addon CreateGreenhouse() => new("Greenhouse", 10, 2, "add10");
    public static Addon CreateHeavyArmor() => new("Heavy Armor", 10, 4, "add11");
    public static Addon CreateBioFuelGenerator() => new("Biofuel Generator", 10, 1, "add12");
    public static Addon CreateHeavyLargeStorage() => new("Heavy Large Storage", 10, 3, "add13");
    public static Addon CreateGaussaGun() => new("Gaussa Gun", 10, 2, "add14"); // Hits every enemy
    public static Addon CreateSmallNuclearReactor() => new("Small Nuclear Reactor", 10, 2, "add15");
    public static Addon CreateMaintenanceDrone() => new("Maintenance Drone", 10, 2, "add16");
    public static Addon CreateZuraw() => new("Zuraw", 10, 3, "add17");
    public static Addon CreateTurboBagpiper() => new("Turbo Bagpiper", 10, 3, "add18");

}