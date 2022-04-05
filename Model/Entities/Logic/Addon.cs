namespace Model.Entities.Logic; 

public class Addon : Vehicle{
    public Addon(string code, int price, int slotCount, string imageUrl) : base(code, price, slotCount, imageUrl) { }
    public Addon(string code, int price, int slotCount) : base(code, price, slotCount) { }

    public Database.Addon ToEntity() {
        var addon = new Database.Addon();
        addon.Code = Code;
        return addon;
    }
}