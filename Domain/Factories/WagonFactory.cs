using Model.Entities;

namespace Domain.Factories;

public static class WagonFactory
{
    public static Wagon CreateReinforcedFuelWagon()
    {
        return new()
        {
            Code = "Reinforced Fuel Wagon",
            Price = 10,
            Image = "cards/cargo1.png"
        };
    }

    public static Wagon CreateReinforcedWagon()
    {
        return new()
        {
            Code = "Reinforced Wagon",
            Price = 10,
            Image = "cards/cargo2.png"
        };
    }

    public static Wagon CreateWagon()
    {
        return new()
        {
            Code = "Wagon",
            Price = 10,
            Image = "cards/cargo4.png"
        };
    }

    public static Wagon CreateMedicalWagon()
    {
        return new()
        {
            Code = "Medical Wagon",
            Price = 10,
            Image = "cards/cargo5.png"
        };
    }

    public static Wagon CreateDoubleReinforcedFuelWagon()
    {
        return new()
        {
            Code = "Double Reinforced Fuel Wagon",
            Price = 10,
            Image = "cards/cargo6.png"
        };
    }
}