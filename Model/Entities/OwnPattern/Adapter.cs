namespace Model.Entities.OwnPattern;

public class Adapter : Vehicle {
    public Addon Addon { get; set; }
    protected Adapter(string code, int price, int slotCount) : base(code, price, slotCount) {
    }
    protected Adapter(string code, int price, int slotCount, Addon addon) : base(code, price, slotCount) {
        Addon = addon;
    }
}