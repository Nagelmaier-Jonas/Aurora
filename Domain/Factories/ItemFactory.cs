using Model.Entities.Items;

namespace Domain.Factories;

public static class ItemFactory{
    
    public static AItem CreateCargo1()
    {
        return new Cargo()
        {
            Name = "Cargo1",
            BuyPrice = 10,
            SellPrice = 200
        };
    }
    
    public static AItem CreateCrew1()
    {
        return new CrewMember()
        {
            Name = "Crew1",
            Hitpoints = 3
        };
    }
    
    public static AItem CreateChemical1()
    {
        return new ChemicalLiquid()
        {
            Name = "Chemical1",
            KaAhnung = "test"
        };
    }
    
    public static AItem CreateWeapon1()
    {
        return new Weapon()
        {
            Name = "Weapon1",
            Hit = 1,
            Crit = 2
        };
    }
}