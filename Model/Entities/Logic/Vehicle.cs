namespace Model.Entities.Logic; 

public class Vehicle {
    public string Code { get; set; }
    public  int Price { get; set; }
    public ACargo[] CargoList { get; set; } // Slots
    
    public string ImageUrl{ get; }

    protected Vehicle(string code, int price, int slotCount, string imageUrl) {
        Code = code;
        Price = price;
        ImageUrl = imageUrl;
        CargoList = new ACargo[slotCount];
    }
    protected Vehicle(string code, int price, int slotCount) {
        Code = code;
        Price = price;
        CargoList = new ACargo[slotCount];
    }
}