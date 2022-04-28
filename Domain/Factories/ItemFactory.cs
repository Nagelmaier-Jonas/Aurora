using Model.Entities.Cargo;

namespace Domain.Factories;

public static class ItemFactory{
    
   
    public static ACargo CreateCrew()
    {
        return new CrewCargo()
        {
            Price = 10,
            Vitality = 10
        };
    }
    
    public static ACargo CreateChemical()
    {
        return new FuelCargo()
        {
           Price = 10,
        };
    }
}