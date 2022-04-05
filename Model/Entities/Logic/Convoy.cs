namespace Model.Entities.Logic;

public class Convoy {
    // First and last can be a truck
    public Truck FrontTruck { get; set; }
    public Truck TailTruck { get; set; }

    public Database.Convoy ToEntity() {
        var convoy = new Database.Convoy();
        convoy.FrontTruck = FrontTruck.ToEntity();
        convoy.BackTruck = TailTruck.ToEntity();
        return convoy;
    }
}