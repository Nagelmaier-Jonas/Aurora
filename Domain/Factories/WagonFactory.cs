using Model.Entities;
using Model.Enums;

namespace Model.Factories;

public static class WagonFactory{
    public static Wagon Create(EWagonType type){
        return type switch{
            EWagonType.REINFORCED_FUEL_WAGON => CreateReinforcedFuelWagon(),
            EWagonType.REINFORCED_WAGON => CreateReinforcedWagon(),
            EWagonType.WAGON => CreateWagon(),
            EWagonType.MEDICAL_WAGON => CreateMedicalWagon(),
            EWagonType.DOUBLE_REINFORCED_FUEL_WAGON => CreateDoubleReinforcedFuelWagon()
        };
    }

    private static Wagon CreateReinforcedFuelWagon() => new Wagon{
        Code = "Reinforced Fuel Wagon",
        Price = 10,
        Image = "cards/cargo1.png"
    };

    private static Wagon CreateReinforcedWagon() => new Wagon{
        Code = "Reinforced Wagon",
        Price = 10,
        Image = "cards/cargo2.png"
    };

    private static Wagon CreateWagon() => new Wagon{
        Code = "Wagon",
        Price = 10,
        Image = "cards/cargo4.png"
    };

    private static Wagon CreateMedicalWagon() => new Wagon{
        Code = "Medical Wagon",
        Price = 10,
        Image = "cards/cargo5.png"
    };

    private static Wagon CreateDoubleReinforcedFuelWagon() => new Wagon{
        Code = "Double Reinforced Fuel Wagon",
        Price = 10,
        Image = "cards/cargo6.png"
    };
    
}