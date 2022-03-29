namespace Model.Entities; 

public class Vehicle {
    private string _code;
    private int _price;
    private ICargo[] _cargoList; // Slots

    protected Vehicle(string code, int price, int slotCount) {
        _code = code;
        _price = price;
        _cargoList = new ICargo[slotCount];
    }
}