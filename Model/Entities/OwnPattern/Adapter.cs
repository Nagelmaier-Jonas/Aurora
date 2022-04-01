namespace Model.Entities.OwnPattern;

public abstract class Adapter : Vehicle {
    public Addon Addon { get; set; }
    protected Adapter(string code, int price, int slotCount) : base(code, price, slotCount) {
    }
    protected Adapter(string code, int price, int slotCount, string imageUrl) : base(code, price, slotCount, imageUrl) {
    }
    protected Adapter(string code, int price, int slotCount, string imageUrl, Addon addon) : base(code, price, slotCount, imageUrl) {
        Addon = addon;
    }
}