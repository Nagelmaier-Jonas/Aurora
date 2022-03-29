namespace Model.Entities; 

public class Truck : Vehicle {
   
    private int _speed;
    private int _maxContainer; // Zugkraft

    public Truck(string code, int price, int slotCount, int speed, int maxContainer) : base(code, price, slotCount) {
        _speed = speed;
        _maxContainer = maxContainer;
    }
}