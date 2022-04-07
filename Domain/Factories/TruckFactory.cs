using Model.Entities;
using Model.Enums;

namespace Model.Factories;

public static class TruckFactory{
    public static Truck Create(ETruckType type){
        return type switch{
            ETruckType.HEAVY_TESLA_TANK => CreateHeavyTeslaTank(),
            ETruckType.TURBO_TRUCK_WITH_BIO_FUEL => CreateTurboTruckWithBiofuel(),
            ETruckType.APC => CreateApc(),
            ETruckType.RAILGUN_TRUCK => CreateRailgunTruck(),
            ETruckType.TRUCK => CreateTruck(),
            ETruckType.ATOM_TRUCK => CreateAtomTruck()
        };
    }

    private static Truck CreateHeavyTeslaTank()=> new Truck{
        Code = "Heavy Tesla Tank",
        Price = 10,
        Speed = 3,
        PullForce = 3,
        Image = "cards/truck1.png"
    };

    private static Truck CreateTurboTruckWithBiofuel()=> new Truck{
        Code = "Turbo Truck with Bio Fuel",
        Price = 10,
        Speed = 4,
        PullForce = 3,
        Image = "cards/truck2.png"
    };

    private static Truck CreateApc() => new Truck{
        Code = "APC",
        Price = 10,
        Speed = 2,
        PullForce = 3,
        Image = "cards/truck3.png"
    };


    private static Truck CreateRailgunTruck()=> new Truck{
        Code = "Railgun Truck",
        Price = 10,
        Speed = 4,
        PullForce = 3,
        Image = "cards/truck4.png"
    };

    private static Truck CreateTruck() => new Truck{
        Code = "Truck",
        Price = 10,
        Speed = 2,
        PullForce = 2,
        Image = "cards/truck5.png"
    };

    private static Truck CreateAtomTruck() => new Truck{
        Code = "Atom Truck",
        Price = 10,
        Speed = 4,
        PullForce = 3,
        Image = "cards/truck6.png"
    };
}