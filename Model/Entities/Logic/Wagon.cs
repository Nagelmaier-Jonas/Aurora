namespace Model.Entities.Logic;

public class Wagon : Adapter {
    public Wagon(string code, int price, int slotCount) : base(code, price, slotCount) { }
    public Wagon(string code, int price, int slotCount, string imageUrl) : base(code, price, slotCount, imageUrl) { }

    public Database.Wagon ToEntity() {
        var wagon = new Database.Wagon();
        wagon.Code = Code;
        return wagon;
    }
}