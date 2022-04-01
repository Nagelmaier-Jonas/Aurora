namespace Model.Entities.OwnPattern; 

public class Addon : Vehicle{
    public Addon(string code, int price, int slotCount, string imageUrl) : base(code, price, slotCount, imageUrl) { }
    public Addon(string code, int price, int slotCount) : base(code, price, slotCount) { }
}