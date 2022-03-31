namespace Model.Entities.OwnPattern; 

public class VehicleFactory{
    // List of all trucks
    public static List<Truck> Trucks = new List<Truck>(){
        // Todo: add every CreatTruck method here
        // CreateExampleTruck()
        CreateCzolgTesli(),
        CreateTurboCiezarowkaNaBioPaliwo(),
    };
    // List of all wagons
    public static List<Wagon> Wagons = new List<Wagon>(){
        // Todo: add every CreatWagon method here
        // CreateExampleWagon(),
        CreateUzbrojonaCysterna(),
        CreateOpancerzonaPrzyczepa(),
        CreateOpancerzonaPrzyczepa2(),
        CreatePrzyczepa(),
        CreatePrzyczepaSanitarna()
    };
    // <summary>
    // All methods to create trucks
    // </summary>
    public static Truck CreateExampleTruck() {
        return new Truck("Example", 10, 4, 4, 4, "example");
    }
    public static Truck CreateCzolgTesli() {
        // TODO: price and Addons
        return new Truck("Czolg Tesli", 10, 4, 3, 3, "truck1");
    }
    public static Truck CreateTurboCiezarowkaNaBioPaliwo() {
        // TODO: price and Addons
        return new Truck("Turbo Ciezarowka na Bio-Paliwo", 10, 4, 4, 3, "truck2");
    }
    
    public static Truck CreateAPC() {
        // TODO: price and Addons
        return new Truck("APC", 10, 4, 2, 3, "truck3");
    }
    // <summary>
    // All methods to create wagons
    // </summary>
    public static Wagon CreateExampleWagon() => new Wagon("Example", 10, 4, "example");
    public static Wagon CreateUzbrojonaCysterna() => new Wagon("Uzbrojona Cysterna", 10, 4, "cargo1");
    public static Wagon CreateOpancerzonaPrzyczepa() => new Wagon("Opancerzona Przyczepa", 10, 4, "cargo2");
    public static Wagon CreateOpancerzonaPrzyczepa2() => new Wagon("Opancerzona Przyczepa", 10, 4, "cargo3");
    public static Wagon CreatePrzyczepa() => new Wagon("Przyczepa", 10, 3, "cargo4");
    public static Wagon CreatePrzyczepaSanitarna() => new Wagon("Przyczepa Sanitarna", 10, 4, "cargo5");
}