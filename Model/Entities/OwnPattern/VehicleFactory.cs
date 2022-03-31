namespace Model.Entities.OwnPattern; 

public class VehicleFactory{
    // List of all trucks
    public static List<Truck> Trucks = new (){
        // Todo: add every CreatTruck method here
        // CreateExampleTruck()
        CreateCzolgTesli(),
        CreateTurboCiezarowkaNaBioPaliwo(),
        CreateAPC(),
        CreateCzolgImpulsowy(),
        CreateCiezarowka(),
        CreateNuklearnaCiezarowka()
    };
    // List of all wagons
    public static List<Wagon> Wagons = new (){
        // Todo: add every CreatWagon method here
        // CreateExampleWagon(),
        CreateUzbrojonaCysterna(),
        CreateOpancerzonaPrzyczepa(),
        CreatePrzyczepa(),
        CreatePrzyczepaSanitarna(),
        CreateOpAncerzonaCysterna()
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
    public static Truck CreateCzolgImpulsowy() {
        // TODO: price and Addons
        return new Truck("Czolg Impulsowy", 10, 4, 4, 3, "truck4");
    }

    public static Truck CreateCiezarowka() {
        // TODO: price and Addons
        return new Truck("Ciezarowka", 10, 4, 2, 2, "truck5");
    }

    public static Truck CreateNuklearnaCiezarowka() {
        // TODO: price and Addons
        return new Truck("Nuklearna Ciezarowka", 10, 4, 4, 3, "truck6");
    }
    // <summary>
    // All methods to create wagons
    // </summary>
    public static Wagon CreateExampleWagon() => new ("Example", 10, 4, "example");
    public static Wagon CreateUzbrojonaCysterna() => new ("Uzbrojona Cysterna", 10, 4, "cargo1");
    public static Wagon CreateOpancerzonaPrzyczepa() => new ("Opancerzona Przyczepa", 10, 4, "cargo2");
    public static Wagon CreatePrzyczepa() => new ("Przyczepa", 10, 3, "cargo4");
    public static Wagon CreatePrzyczepaSanitarna() => new ("Przyczepa Sanitarna", 10, 4, "cargo5");
    public static Wagon CreateOpAncerzonaCysterna() => new("OP Ancerzona Cysterna", 10, 4, "cargo6");
}