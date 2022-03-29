namespace Model.Entities.OwnPattern; 

public class Truck : Adapter {
   
    public int Speed { get; set; }
    public int MaxContainer { get; set; } // Zugkraft

    public Truck(string code, int price, int slotCount, int speed, int maxContainer, string imageUrl) : base(code, price, slotCount, imageUrl) {
        Speed = speed;
        MaxContainer = maxContainer;
    }
    public Truck(string code, int price, int slotCount, int speed, int maxContainer) : base(code, price, slotCount) {
        Speed = speed;
        MaxContainer = maxContainer;
    }
}