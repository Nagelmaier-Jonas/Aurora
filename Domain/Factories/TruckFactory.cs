using Model.Entities;

namespace Domain.Factories;

public static class TruckFactory
{
    public static Truck CreateHeavyTeslaTank()
    {
        return new()
        {
            Code = "Heavy Tesla Tank",
            Price = 10,
            Speed = 3,
            PullForce = 3,
            Image = "cards/truck1.png"
        };
    }

    public static Truck CreateTurboTruckWithBiofuel()
    {
        return new()
        {
            Code = "Turbo Truck with Bio Fuel",
            Price = 10,
            Speed = 4,
            PullForce = 3,
            Image = "cards/truck2.png"
        };
    }

    public static Truck CreateApc()
    {
        return new()
        {
            Code = "APC",
            Price = 10,
            Speed = 2,
            PullForce = 3,
            Image = "cards/truck3.png"
        };
    }


    public static Truck CreateRailgunTruck()
    {
        return new()
        {
            Code = "Railgun Truck",
            Price = 10,
            Speed = 4,
            PullForce = 3,
            Image = "cards/truck4.png"
        };
    }

    public static Truck CreateTruck()
    {
        return new()
        {
            Code = "Truck",
            Price = 10,
            Speed = 2,
            PullForce = 2,
            Image = "cards/truck5.png"
        };
    }

    public static Truck CreateAtomTruck()
    {
        return new()
        {
            Code = "Atom Truck",
            Price = 10,
            Speed = 4,
            PullForce = 3,
            Image = "cards/truck6.png"
        };
    }
}