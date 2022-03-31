namespace Model.Entities.OwnPattern;

public class Convoy {
    // First and last can be a truck
    public Truck[] Trucks { get; } = new Truck[2];
    private readonly List<Wagon> _wagons = new();
}