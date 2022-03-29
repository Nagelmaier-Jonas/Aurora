namespace Model.Entities.OwnPattern; 

public class Vehicle {
    public string Code { get; set; }
    public  int Price { get; set; }
    public ACargo[] CargoList { get; set; } // Slots

    protected Vehicle(string code, int price, int slotCount) {
        Code = code;
        Price = price;
        CargoList = new ACargo[slotCount];
    }
}