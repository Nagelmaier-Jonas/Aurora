namespace Model.Entities.OwnPattern; 

public class VehicleFactory {
    public static Truck CreateCzolgTesli() {
        // TODO: price
        return new Truck("Czolg Tesli", 10, 4, 3, 3);
    }
    public static Truck CreateTurboCiezarowkaNaBioPaliwo() {
        // TODO: price
        return new Truck("Turbo Ciezarowka na Bio-Paliwo", 10, 4, 4, 3);
    }
}