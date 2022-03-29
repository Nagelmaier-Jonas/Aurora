namespace Model.Entities.OwnPattern;

public class Wagon : Adapter {
    protected Wagon(string code, int price, int slotCount) : base(code, price, slotCount) { }
}