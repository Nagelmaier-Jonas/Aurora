namespace Model.Entities.Logic; 

public class Truck : Adapter {
   
    public int Speed { get; set; }
    public int MaxContainer { get; set; } // Zugkraft

    public List<Wagon>? Wagons { get; set; }

    public Truck(string code, int price, int slotCount, int speed, int maxContainer, string imageUrl) : base(code, price, slotCount, imageUrl) {
        Speed = speed;
        MaxContainer = maxContainer;
    }
    public Truck(string code, int price, int slotCount, int speed, int maxContainer) : base(code, price, slotCount) {
        Speed = speed;
        MaxContainer = maxContainer;
    }

    public Database.Truck ToEntity() {
        var truck = new Database.Truck();
        foreach (var wagon in Wagons) {
            truck.AddWagon(wagon.ToEntity());
        }
        
        truck.Code = Code;
        return truck;
    }
}