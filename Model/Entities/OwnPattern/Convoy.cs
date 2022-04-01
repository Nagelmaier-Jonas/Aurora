namespace Model.Entities.OwnPattern;

public class Convoy {
    // First and last can be a truck
    public Truck FrontTruck { get; set; }
    public Truck TailTruck { get; set; }
    public List<Wagon> Wagons { get; } = new();
}